using System;
using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar;

namespace ChangKeTec.EncryptProgram
{
    public partial class FormMain2 : Office2007Form
    {
        public FormMain2()
        {
            InitializeComponent();
        }

        private void btnEn_Click(object sender, EventArgs e)
        {
            txtDe.Text = GzipHelper.GZipCompressString(txtEn.Text);
        }

        private void btnDe_Click(object sender, EventArgs e)
        {
            try
            {
                txtEn.Text = GzipHelper.GZipDecompressString(txtDe.Text);
            }
            catch (Exception)
            {
                MessageHelper.ShowError("解密失败，错误的字符串！");

            }
        }

        private void btnClearDe_Click(object sender, EventArgs e)
        {
            txtDe.Text = "";
        }

        private void btnClearEn_Click(object sender, EventArgs e)
        {
            txtEn.Text = "";
        }
    }
}
