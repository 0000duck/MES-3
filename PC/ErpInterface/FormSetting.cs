using System;
using System.Text;
using System.Windows.Forms;
using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar;

namespace ChangKeTec.Wms.ErpInterface
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

            try
            {
                AppConfigHelper.SetAppValue(GlobalVar.SpareServer, spareServer.Text);
                AppConfigHelper.SetAppValue(GlobalVar.SparePort, sparePort.Text);
                AppConfigHelper.SetAppValue(GlobalVar.SpareDb, spareDb.Text);
                AppConfigHelper.SetAppValue(GlobalVar.SpareUser, spareUser.Text);
                AppConfigHelper.SetAppValue(GlobalVar.SparePassword, EncryptHelper.Encrypt(sparePwd.Text));

                AppConfigHelper.SetAppValue(GlobalVar.InterfaceServer, OAServer.Text);
                AppConfigHelper.SetAppValue(GlobalVar.InterfacePort, OAPort.Text);
                AppConfigHelper.SetAppValue(GlobalVar.InterfaceDb, OADb.Text);
                AppConfigHelper.SetAppValue(GlobalVar.InterfaceUser, OAUser.Text);
                AppConfigHelper.SetAppValue(GlobalVar.InterfacePassword, EncryptHelper.Encrypt(OAPwd.Text));

                AppConfigHelper.SetAppValue(GlobalVar.LocalRoot, txtPathRoot.Text);
                AppConfigHelper.SetAppValue(GlobalVar.PathFromErp, txtPathFromErp.Text);
                AppConfigHelper.SetAppValue(GlobalVar.PathToErp, txtPathToErp.Text);
                AppConfigHelper.SetAppValue(GlobalVar.PathBak, txtPathBak.Text);

                AppConfigHelper.SetAppValue(GlobalVar.ErpPutDuration, intErpPut.Text);
                AppConfigHelper.SetAppValue(GlobalVar.ErpGetDuration, intErpGet.Text);
                AppConfigHelper.SetAppValue(GlobalVar.MesGetDuration, intMesGet.Text);
                AppConfigHelper.SetAppValue(GlobalVar.VinExeDuration, intVinExe.Text);
                AppConfigHelper.SetAppValue(GlobalVar.JisSortDuration, intJisSort.Text);
                AppConfigHelper.SetAppValue(GlobalVar.JisPartDuration, intJisPart.Text);
                DialogResult = DialogResult.OK;


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
                spareServer.Text = AppConfigHelper.GetAppValue(GlobalVar.SpareServer);
                sparePort.Text = AppConfigHelper.GetAppValue(GlobalVar.SparePort);
                spareDb.Text = AppConfigHelper.GetAppValue(GlobalVar.SpareDb);
                spareUser.Text = AppConfigHelper.GetAppValue(GlobalVar.SpareUser);
                sparePwd.Text = EncryptHelper.Decrypt(AppConfigHelper.GetAppValue(GlobalVar.SparePassword));

                OAServer.Text = AppConfigHelper.GetAppValue(GlobalVar.InterfaceServer);
                OAPort.Text = AppConfigHelper.GetAppValue(GlobalVar.InterfacePort);
                OADb.Text = AppConfigHelper.GetAppValue(GlobalVar.InterfaceDb);
                OAUser.Text = AppConfigHelper.GetAppValue(GlobalVar.InterfaceUser);
                OAPwd.Text = EncryptHelper.Decrypt(AppConfigHelper.GetAppValue(GlobalVar.InterfacePassword));

                txtPathRoot.Text = AppConfigHelper.GetAppValue(GlobalVar.LocalRoot);
                txtPathFromErp.Text = AppConfigHelper.GetAppValue(GlobalVar.PathFromErp);
                txtPathToErp.Text = AppConfigHelper.GetAppValue(GlobalVar.PathToErp);
                txtPathBak.Text = AppConfigHelper.GetAppValue(GlobalVar.PathBak);
           
                intErpPut.Text = AppConfigHelper.GetAppValue(GlobalVar.ErpPutDuration);
                intErpGet.Text = AppConfigHelper.GetAppValue(GlobalVar.ErpGetDuration);
                intMesGet.Text = AppConfigHelper.GetAppValue(GlobalVar.MesGetDuration);
                intVinExe.Text = AppConfigHelper.GetAppValue(GlobalVar.VinExeDuration);
                intJisSort.Text = AppConfigHelper.GetAppValue(GlobalVar.JisSortDuration);
                intJisPart.Text = AppConfigHelper.GetAppValue(GlobalVar.JisPartDuration);
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
