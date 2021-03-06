﻿using System;
using System.Text;
using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar;

namespace ChangKeTec.Wms.WinForm
{
    public partial class FormSetting : Office2007Form
    {
//        const string SqlConn = "SqlConn";



        public FormSetting()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StringBuilder sbConn = new StringBuilder();
            sbConn.Append("data source =" + txtServer.Text + ";");
            sbConn.Append("initial catalog = " + txtSqlDb.Text + ";");
            sbConn.Append("user id = " + txtSqlUser.Text + ";");
            sbConn.Append("password = " + txtSqlPwd.Text + ";");
            sbConn.Append("MultipleActiveResultSets = True;");
            sbConn.Append("App = EntityFramework;");
            sbConn.Append("persist security info = True;");

            try
            {
//                string strConn = EncryptHelper.Encrypt(sbConn.ToString());
//                AppConfigHelper.SetAppValue(SqlConn, strConn);
                AppConfigHelper.SetAppValue(GlobalVar.SpareDbServer, txtServer.Text);
                AppConfigHelper.SetAppValue(GlobalVar.SpareDbPort, txtPort.Text);
                AppConfigHelper.SetAppValue(GlobalVar.SpareDbUser, txtSqlUser.Text);
                AppConfigHelper.SetAppValue(GlobalVar.SpareDbPassword, EncryptHelper.Encrypt(txtSqlPwd.Text));
                AppConfigHelper.SetAppValue(GlobalVar.SpareDbName, txtSqlDb.Text);

                AppConfigHelper.SetAppValue(GlobalVar.PowerDbServer, txtServer.Text);
                AppConfigHelper.SetAppValue(GlobalVar.PowerDbPort, txtPort.Text);
                AppConfigHelper.SetAppValue(GlobalVar.PowerDbUser, txtSqlUser.Text);
                AppConfigHelper.SetAppValue(GlobalVar.PowerDbPassword, EncryptHelper.Encrypt(txtSqlPwd.Text));
                AppConfigHelper.SetAppValue(GlobalVar.PowerDbName, txtPowerDb.Text);

                AppConfigHelper.SetAppValue(GlobalVar.UpdateServerUrl, txtWebServer.Text);
                AppConfigHelper.SetAppValue(GlobalVar.UpdateFileName, txtUpdateFileName.Text);

                StringBuilder sb = new StringBuilder();

                sb.AppendLine(AppConfigHelper.GetAppValue(GlobalVar.SpareDbServer));
                sb.AppendLine(AppConfigHelper.GetAppValue(GlobalVar.SpareDbName));
                sb.AppendLine(AppConfigHelper.GetAppValue(GlobalVar.SpareDbUser));
                sb.AppendLine(AppConfigHelper.GetAppValue(GlobalVar.SpareDbPassword));
                sb.AppendLine(AppConfigHelper.GetAppValue(GlobalVar.UpdateServerUrl));
                sb.AppendLine(AppConfigHelper.GetAppValue(GlobalVar.UpdateFileName));

//                MessageBox.Show(sb.ToString());

                Close();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex);
            }
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            try
            {

//                string strConn = EncryptHelper.Decrypt(AppConfigHelper.GetAppValue(SqlConn));
//                string[] stArray = strConn.Split(';');
//                if (stArray.Length == 0) return;
                txtServer.Text = AppConfigHelper.GetAppValue(GlobalVar.SpareDbServer);
                txtPort.Text = AppConfigHelper.GetAppValue(GlobalVar.SpareDbPort);
                txtSqlUser.Text = AppConfigHelper.GetAppValue(GlobalVar.SpareDbUser);
                txtSqlPwd.Text = EncryptHelper.Decrypt(AppConfigHelper.GetAppValue(GlobalVar.SpareDbPassword));

                txtSqlDb.Text = AppConfigHelper.GetAppValue(GlobalVar.SpareDbName);
                txtPowerDb.Text = AppConfigHelper.GetAppValue(GlobalVar.PowerDbName);

                txtWebServer.Text = AppConfigHelper.GetAppValue(GlobalVar.UpdateServerUrl);
                txtUpdateFileName.Text = AppConfigHelper.GetAppValue(GlobalVar.UpdateFileName);
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex);
            }
        }

        private static string GetConnValue(string stArray)
        {
            return (stArray.Split('='))[1].Trim();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
