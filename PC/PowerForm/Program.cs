using System;
using System.Windows.Forms;
using ChangKeTec.Wms.Utils;

namespace ChangKeTec.PowerForm
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (ProgramHelper.HasExist())
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
                if (GlobalVar.Oper.OperCode == "" || GlobalVar.Oper == null) return;
                try
                {
                    Application.Run(new FormMain());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        
    }
}
