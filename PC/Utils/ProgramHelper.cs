using System.Windows.Forms;

namespace ChangKeTec.Wms.Utils
{
    public class ProgramHelper
    {
        public static bool HasExist()
        {
            bool notExist;
            System.Threading.Mutex run = new System.Threading.Mutex(true, Application.ProductName, out notExist); //核心代码
            if (notExist) return false;
            MessageBox.Show(Application.ProductName + "已运行，无法重复启动。");
            return true;
        } 
    }
}