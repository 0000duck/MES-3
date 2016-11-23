using System;
using System.Configuration;
using System.Windows.Forms;

namespace ChangKeTec.Wms.AutoUpdate
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string[] strArgs;
            if (args.Length > 0)
            {
                strArgs = args[0].Split(',');
            }
            else
            {
                //                strArgs =
                //                    "'http://192.168.1.213:80/','Wms.WinForm.exe','1.0.0.3','PcUpdate','update1.0.0.3.zip','2016-03-15','初始版本'"
                //                        .Split(',');
                strArgs = ConfigurationManager.AppSettings.Get("DefaultArgs").Split(',');
            }
            GlobalVar.ServerUrl = strArgs[0].Trim('\'');
            GlobalVar.SoftWareName = strArgs[1].Trim('\'');
            GlobalVar.NewVersion = strArgs[2].Trim('\'');
            GlobalVar.FilePath = strArgs[3].Trim('\'');
            GlobalVar.FileName = strArgs[4].Trim('\'');
            GlobalVar.LastUpdateTime = strArgs[5].Trim('\'');
            GlobalVar.Desc = strArgs[6].Trim('\'');
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAutoUpdate());
        }
    }
}
