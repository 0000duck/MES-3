using System;
using System.Windows.Forms;

namespace ChangKeTec.Wms.Utils
{
    public static class MessageHelper
    {
        public static void ShowError(Exception ex)
        {
            MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LogHelper.Write(ex.ToString());
        }

        public static void ShowError(string msg)
        {
            MessageBox.Show(msg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LogHelper.Write(msg);
        }
        public static DialogResult ShowWarning(string msg)
        {
           return MessageBox.Show(msg, "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
        public static DialogResult ShowQuestion(string msg)
        {
           return MessageBox.Show(msg, "问题", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void ShowInfo(string msg)
        {
            MessageBox.Show(msg, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
