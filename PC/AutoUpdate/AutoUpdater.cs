using System;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ChangKeTec.Wms.AutoUpdate
{
    public class AutoUpdater
    {
        private string _serverUrl;
        private string _softwareName;
        private string _newVersion;
        private string _filePath;
        private string _fileName;
        private string _lastUpdateTime;
        private string _desc;

        //"http://127.0.0.1/", "PcUpdate.xml"
        public bool CheckUpdateLoad(string serverUrl, string updateXmlFileName)
        {
            bool result = false;
            _serverUrl = serverUrl;
            try
            {
                if (CheckUpdate(serverUrl,updateXmlFileName))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("检查到新版本:" + _newVersion);
                    sb.AppendLine("更新时间:" + _lastUpdateTime);
                    sb.AppendLine("更新说明:" + _desc);
                    sb.AppendLine("是否更新？");
                    var dr = MessageBox.Show(sb.ToString(), @"发现新版本:"+_newVersion, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        //string path = Application.StartupPath.Replace("program", "");
                        string path = Application.StartupPath;
                        StringBuilder args = new StringBuilder();
                        args.Append("'" + _serverUrl + "',");
                        args.Append("'" + _softwareName + "',");
                        args.Append("'"+_newVersion + "',");
                        args.Append("'"+_filePath + "',");
                        args.Append("'"+_fileName + "',");
                        args.Append("'"+_lastUpdateTime + "',");
                        args.Append("'"+_desc + "'");

                        System.Diagnostics.Process process = new System.Diagnostics.Process
                        {
                            StartInfo =
                            {
                                FileName = "Wms.AutoUpdate.exe",
                                WorkingDirectory = path,
                                CreateNoWindow = true,
                                Arguments = args.ToString(),
                            }
                        };
//                        MessageBox.Show(process.StartInfo.FileName+" "+process.StartInfo.Arguments);
                        process.Start();
                        result = true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = false;
            }
            return result;
        }


        private bool CheckUpdate(string serverUrl, string updateXmlFileName)
        {

            var fullFileName = serverUrl + updateXmlFileName;
            try
            {
                var wc = new WebClient();
                var stream = wc.OpenRead(fullFileName);
                //http://127.0.0.1/PcUpdate.xml
                var xmlDoc = new XmlDocument();
                if (stream != null) xmlDoc.Load(stream);
                XmlNode rootNode = xmlDoc.SelectSingleNode("AutoUpdate");
                if (rootNode != null)
                    foreach (XmlNode node in rootNode.ChildNodes.Cast<XmlNode>().Where(node => node.Name == "SoftWare"))
                    {
                        if (node.Attributes != null) _softwareName = node.Attributes["Name"].Value;
                        foreach (XmlNode n in node.ChildNodes)
                        {
                            switch (n.Name)
                            {
                                case "Version":
                                    _newVersion = n.InnerText;
                                    break;
                                case "FilePath":
                                    _filePath = n.InnerText;
                                    break;
                                case "FileName":
                                    _fileName = n.InnerText;
                                    break;
                                case "LastUpdateTime":
                                    _lastUpdateTime = n.InnerText;
                                    break;
                                case "Desc":
                                    _desc = n.InnerText;
                                    break;
                            }
                        }
                    }


                Version newVersion = new Version(_newVersion);
                Version oldVersion = Assembly.LoadFrom(_softwareName).GetName().Version;
                var tm = oldVersion.CompareTo(newVersion);

                var hasUpdate = tm < 0;
                return hasUpdate;
            }
            catch (Exception ex)
            {
                throw new Exception("更新出现错误，请确认网络连接无误后重试！\n" + fullFileName + "\n"+ ex.Message);
            }
        }
    }
}