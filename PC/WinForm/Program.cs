using System;
using System.Windows.Forms;
using ChangKeTec.Wms.AutoUpdate;
using ChangKeTec.Wms.Utils;

namespace ChangKeTec.Wms.WinForm
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {

            if (ProgramHelper.HasExist())
            {
                Application.Exit();
                return;
            }


            string serverUrl = AppConfigHelper.GetAppValue("UpdateServerUrl");
            string updateXmlFileName = AppConfigHelper.GetAppValue("UpdateFileName");
            AutoUpdater updater = new AutoUpdater();
            //"http://127.0.0.1/", "PcUpdate.xml"
            if (updater.CheckUpdateLoad(serverUrl, updateXmlFileName))
            {
                Application.Exit();
            }
            else
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);


                FormLogin frmL = new FormLogin();
                frmL.ShowDialog();

                if (GlobalVar.Oper == null)
                {
                    return;
                }
                if (GlobalVar.Oper.OperCode != "" && GlobalVar.Oper != null)
                {
                    Application.Run(new FormMain());
                }
            }
        }
    }
}
