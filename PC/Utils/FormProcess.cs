using System;
using System.Windows.Forms;

namespace ChangKeTec.Wms.Utils
{
    public partial class FormProcess : Form
    {
        public FormProcess()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 设置提示信息
        /// </summary>
        public string MessageInfo
        {
            set { labelInfor.Text = value; }
        }

        /// <summary>
        /// 设置进度条显示值
        /// </summary>
        public int ProcessValue
        {
            set { SysPBar.Value = value; }
        }

        /// <summary>
        /// 设置进度条样式
        /// </summary>
        public ProgressBarStyle ProcessStyle
        {
            set { SysPBar.Style = value; }
        }

        private void FormProcess_Load(object sender, EventArgs e)
        {
            SysPBar.Left = 20;
            SysPBar.Width = Width - 40;
        }
    }
}

