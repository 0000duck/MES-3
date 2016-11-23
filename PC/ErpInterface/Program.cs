using System;
using System.Windows.Forms;
using ChangKeTec.Wms.Utils;

namespace ChangKeTec.Wms.ErpInterface
{
    static class Program
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
            }
            else
            {


                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMain());
            }
        }
    }
}
