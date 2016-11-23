using System;
using System.Windows.Forms;
using ChangKeTec.Wms.Controllers.BaseData;
using ChangKeTec.Wms.Controllers.Log;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar;

namespace ChangKeTec.Wms.WinForm
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
                TS_OPERATOR oper = new TS_OPERATOR();
                string operCode = txtOperCode.Text;
                string password = EncryptHelper.Encrypt(txtPassword.Text);
                using (PowerEntities powerdb = EntitiesFactory.CreatePowerInstance())
                {
                    oper = OperController.Login(powerdb, operCode, password);
                    if (oper == null)
                    {
                        MessageHelper.ShowError("错误的用户名或密码，登录失败！");
                        txtOperCode.Focus();
                        txtOperCode.SelectAll();
                        return;
                    }
                    this.DialogResult = DialogResult.OK;
                    //EntitiesFactory.SaveDb(powerdb);
                    GlobalVar.Oper = oper;
                    GlobalVar.PowerMenuList = PowerController.GetPowerMenuList(powerdb, GlobalVar.PortalCode,
                        oper.OperCode);
                    GlobalVar.NotifytypeList = PowerController.GetNotiFyTypeList(powerdb, GlobalVar.PortalCode,
                        oper.OperCode);
                }

                using (SpareEntities wmsdb = EntitiesFactory.CreateWmsInstance())
                {



                    OperLogController.AddLog(wmsdb, LogType.Login, oper.OperName, operCode, "登录成功");
                    EntitiesFactory.SaveDb(wmsdb);
                    GlobalVar.InitGlobalVar(wmsdb, GlobalVar.Oper);
                }
            }
            catch (WmsException ex)
            {
                 MessageHelper.ShowInfo(ex.ToString());
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException;
                MessageHelper.ShowError((string.IsNullOrEmpty(inner?.Message)) ? ex : inner);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdv_Click(object sender, EventArgs e)
        {
           FormSetting form = new FormSetting();
            form.ShowDialog(this);
            lblDbName.Text = AppConfigHelper.GetAppValue(GlobalVar.WmsDbName);

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            lblVersion.Text = @"Version " + Application.ProductVersion;
            lblDbName.Text = AppConfigHelper.GetAppValue(GlobalVar.WmsDbName);
        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }
    }
}

