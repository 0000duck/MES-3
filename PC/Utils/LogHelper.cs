using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ChangKeTec.Wms.Utils
{
    public static class LogHelper
    {
        public static string Path = "";

        public static void Write(string path, string content)
        {
            try
            {

                var strPath = IoHelper.GetDllPath() + "//"+path;
                if (!Directory.Exists(strPath))
                {
                    Directory.CreateDirectory(strPath);
                }
                string filename = string.Concat(new[]
                {
                    strPath,
                    "//",
                    DateTime.Now.ToLongDateString(),
                    ".txt"
                });
                StreamWriter sw = new StreamWriter(filename, true, Encoding.Unicode);
                sw.WriteLine(DateTime.Now.ToString("yyyyMMdd"));
                sw.WriteLine(content);
//                sw.WriteLine("-------------------------------------");
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public static void Write(string content)
        {
            try
            {

                Path = IoHelper.GetDllPath() + "//Logs";
                if (!Directory.Exists(Path))
                {
                    Directory.CreateDirectory(Path);
                }
                string filename = string.Concat(new[]
                {
                    Path,
                    "//",
                    DateTime.Now.ToLongDateString(),
                    ".txt"
                });
                StreamWriter sw = new StreamWriter(filename, true, Encoding.Unicode);
                sw.WriteLine(DateTime.Now.ToString("HH:mm:ss fff")+"\t"+content);
//                sw.WriteLine("-------------------------------------");
                sw.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void WriteEx(Exception ex)
        {
            Write(ex.ToString());
        }

      


    }
}