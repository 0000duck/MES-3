using System;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;
using System.Windows.Forms;
//using Ionic.Zip;


namespace ChangKeTec.Wms.AutoUpdate
{
    public partial class FormAutoUpdate : Form
    {
        readonly Timer timer = new Timer();
        readonly string _remoteZipFile = GlobalVar.ServerUrl + GlobalVar.FilePath + "/" + GlobalVar.FileName;
        readonly string _localZipFile = Application.StartupPath + "\\" + GlobalVar.FileName;
        private int _percent = 0;


        private readonly string _updatePath = Application.StartupPath + "\\" +
                                              GlobalVar.FileName.Remove(GlobalVar.FileName.IndexOf(".zip"));
        
        public FormAutoUpdate()
        {
            InitializeComponent();
            
            timer.Tick += TimerTick;
            if (File.Exists(_localZipFile))
            {
                try
                {
                    File.Delete(_localZipFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
            if (Directory.Exists(_updatePath))
            {
                try
                {
                    Directory.Delete(_updatePath, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            //检查服务端是否有新版本程序
            GetUpdateFile();
            timer.Enabled = true;
        }


        private void GetUpdateFile()
        {

            try
            {

                var wc = new WebClient();
                //wc.DownloadFile(download, filename);
                wc.DownloadFileAsync(new Uri(_remoteZipFile), _localZipFile);
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileCompleted += wc_DownloadFileCompleted;
                wc.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //解压下载后的文件
            if (File.Exists(_localZipFile))
            {
                //后改的 先解压滤波zip植入ini然后再重新压缩
                if (!Directory.Exists(_updatePath))
                {
                    Directory.CreateDirectory(_updatePath);
                }

                //开始解压压缩包

                ZipFile.ExtractToDirectory(_localZipFile, _updatePath);

                /*
                using (ZipFile zip = ZipFile.Read(_localZipFile))
                {
                    zip.ExtractAll(_updatePath, ExtractExistingFileAction.OverwriteSilently);
                }
                */


                try
                {
                    //复制新文件替换旧文件
                    DirectoryInfo folder = new DirectoryInfo(_updatePath);
                    foreach (FileInfo file in folder.GetFiles())
                    {
                        if(file.Name.Contains("Ionic.Zip.dll"))continue;
                        if(file.Name.Contains("AutoUpdate"))continue;
                        File.Copy(file.FullName, Application.StartupPath + "\\" + file.Name, true);
                    }
                    //Directory.Delete(_updatePath, true);
                    File.Delete(_localZipFile);
                    //覆盖完成 重新启动程序
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.FileName = GlobalVar.SoftWareName;
                    process.StartInfo.WorkingDirectory = Application.StartupPath;//要掉用得exe路径例如:"C:\windows";               
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();

                    Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("请关闭系统后重新执行更新操作!\n"+ ex.Message);
                    Application.Exit();
                }

            }
        }

        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            _percent = e.ProgressPercentage;
            pbDownload.Value = e.ProgressPercentage;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            lblPercent.Text = @"下载进度:" + _percent + "%";
            if (_percent == 100)
            {
                timer.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void FormAutoUpdate_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("下载地址：" + _remoteZipFile);
            sb.AppendLine("新程序版本：" + GlobalVar.NewVersion);
            sb.AppendLine("更新说明：");
            sb.AppendLine(GlobalVar.Desc);
            txtDesc.Text = sb.ToString();
        }

    }
}
