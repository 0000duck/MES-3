using System;
using ChangKeTec.PowerForm.Bll;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar;

namespace ChangKeTec.PowerForm
{
    public partial class FormModifyPassword : Office2007Form
    {
        public FormModifyPassword()
        {
            InitializeComponent();
            
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (txtOldPwd.Text.Trim() == string.Empty)
            {
                MessageHelper.ShowInfo("原密码不能为空");
                return;
            }
            if (txtNewPwd.Text.Trim() == string.Empty)
            {
                MessageHelper.ShowInfo("新密码不能为空");
                return;
            }
            if (txtNewPwd.Text.Length < 6||txtNewPwd.Text.Length>20)
            {
                MessageHelper.ShowInfo("新密码长度应该在6到20位之间");
                return;
            }

            if (txtNewPwd.Text != txtNewPwd2.Text)
            {
                MessageHelper.ShowInfo("两次输入的新密码不一致，请重新输入");
                return;
            }
            string enOldPwd = EncryptHelper.Encrypt(txtOldPwd.Text);
            if (enOldPwd != GlobalVar.Oper.OperPassword)
            {
                MessageHelper.ShowInfo("原密码输入错误");
                return;
            }
            if (enOldPwd == txtNewPwd.Text)
            {
                MessageHelper.ShowInfo("新密码不能与原密码相同");
                return;
            }
            string enNewPwd = EncryptHelper.Encrypt(txtNewPwd.Text);
            GlobalVar.Oper.OperPassword = enNewPwd;
            using (PowerEntities db = EntitiesFactory.CreatePowerInstance())
            {
                var oper = new TS_OPERATOR();
                oper.OperCode = GlobalVar.Oper.OperCode;
                oper.OperName = GlobalVar.Oper.OperName;
                oper.OperPassword = GlobalVar.Oper.OperPassword;
                OperController.AddOrUpdate(db, oper,GlobalVar.Oper);
                MessageHelper.ShowInfo("密码修改成功");
                EntitiesFactory.SaveDb(db);

            }
            Close();

        }

        private void FormModifyPassword_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
