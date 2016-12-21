using System;
using System.IO;
using System.Windows.Forms;
using ChangKeTec.Wms.WinForm.Update;
using DevComponents.DotNetBar;

namespace ChangKeTec.Wms.WinForm.PopUp
{
    public partial class PopupAbout : Office2007Form
    {
        public PopupAbout()
        {
            InitializeComponent();
        }

        private void PopupAbout_Load(object sender, EventArgs e)
        {
            try
            {
                lblVersion.Text = @"Version " + Application.ProductVersion;
                string strUpdateLog = File.ReadAllText(Application.StartupPath + "\\UpdateLog.txt");
                txtUpdateLog.Text = strUpdateLog;

            }
            catch (Exception)
            {
                
                throw;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabelChangKeTec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabelChangKeTec.Links[0].LinkData = "http://www.changketec.com";
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void btnSysRefresh_Click(object sender, EventArgs e)
        {
            frmUpdateSetting frm = new frmUpdateSetting();
            frm.ShowDialog();
        }
    }
}
