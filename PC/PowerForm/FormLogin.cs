using System;
using System.Windows.Forms;
using ChangKeTec.PowerForm.Bll;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar;

namespace ChangKeTec.PowerForm
{
    public partial class FormLogin : Office2007Form
    {
        public FormLogin()
        {
            InitializeComponent();           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOperCode.Text == "")
                {
                    MessageHelper.ShowError("请输入人员编号！");
                    txtOperCode.Focus();
                    return;
                }
                string operCode = txtOperCode.Text;
                string password = EncryptHelper.Encrypt(txtPassword.Text);
                using (PowerEntities db = EntitiesFactory.CreatePowerInstance())
                {
                    var oper = OperController.CheckUser(db, operCode, password);
                    if (oper == null)
                    {
                        MessageHelper.ShowError("错误的用户名或密码，登录失败！");
                        txtOperCode.Focus();
                        txtOperCode.SelectAll();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                        GlobalVar.InitGlobalVar(db, oper);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex);
            }
        }

        private void btnAdv_Click(object sender, EventArgs e)
        {
           FormSetting form = new FormSetting();
            form.ShowDialog(this);
            lblDbName.Text = AppConfigHelper.GetAppValue(GlobalVar.PwerDbName);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            lblVersion.Text = @"Version " + Application.ProductVersion;
            lblDbName.Text = AppConfigHelper.GetAppValue(GlobalVar.PwerDbName);
        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }

        private void txtOperCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                txtPassword.Focus();
                txtPassword.SelectAll();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnLogin_Click(sender,null);
            }
        }
    }
}

