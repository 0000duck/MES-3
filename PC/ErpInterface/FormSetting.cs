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
                AppConfigHelper.SetAppValue(GlobalVar.WmsServer, wmsServer.Text);
                AppConfigHelper.SetAppValue(GlobalVar.WmsPort, wmsPort.Text);
                AppConfigHelper.SetAppValue(GlobalVar.WmsDb, wmsDb.Text);
                AppConfigHelper.SetAppValue(GlobalVar.WmsUser, wmsUser.Text);
                AppConfigHelper.SetAppValue(GlobalVar.WmsPassword, EncryptHelper.Encrypt(wmsPwd.Text));

                AppConfigHelper.SetAppValue(GlobalVar.JisServer, jisServer.Text);
                AppConfigHelper.SetAppValue(GlobalVar.JisPort, jisPort.Text);
                AppConfigHelper.SetAppValue(GlobalVar.JisDb, jisDb.Text);
                AppConfigHelper.SetAppValue(GlobalVar.JisUser, jisUser.Text);
                AppConfigHelper.SetAppValue(GlobalVar.JisPassword, EncryptHelper.Encrypt(jisPwd.Text));

                AppConfigHelper.SetAppValue(GlobalVar.MesServer, mesServer.Text);
                AppConfigHelper.SetAppValue(GlobalVar.MesPort, mesPort.Text);
                AppConfigHelper.SetAppValue(GlobalVar.MesDb, mesDb.Text);
                AppConfigHelper.SetAppValue(GlobalVar.MesUser, mesUser.Text);
                AppConfigHelper.SetAppValue(GlobalVar.MesPassword, EncryptHelper.Encrypt(mesPwd.Text));

                AppConfigHelper.SetAppValue(GlobalVar.FtpServer, FtpServer.Text);
                AppConfigHelper.SetAppValue(GlobalVar.FtpPort, FtpPort.Text);
                AppConfigHelper.SetAppValue(GlobalVar.FtpUser, FtpUser.Text);
                AppConfigHelper.SetAppValue(GlobalVar.FtpPassword, EncryptHelper.Encrypt(FtpPassword.Text));
                AppConfigHelper.SetAppValue(GlobalVar.FtpRootPath, FtpRootPath.Text);
                AppConfigHelper.SetAppValue(GlobalVar.FtpFromErp, FtpFromErp.Text);
                AppConfigHelper.SetAppValue(GlobalVar.FtpToErp, FtpToErp.Text);

                AppConfigHelper.SetAppValue(GlobalVar.LocalRoot, txtPathRoot.Text);
                AppConfigHelper.SetAppValue(GlobalVar.PathFromErp, txtPathFromErp.Text);
                AppConfigHelper.SetAppValue(GlobalVar.PathToErp, txtPathToErp.Text);
                AppConfigHelper.SetAppValue(GlobalVar.PathBak, txtPathBak.Text);

                AppConfigHelper.SetAppValue(GlobalVar.JisSortPath, jisSortPath.Text);
                AppConfigHelper.SetAppValue(GlobalVar.JisSortPathBak, jisSortPathBak.Text);

                AppConfigHelper.SetAppValue(GlobalVar.ErpPutDuration, intErpPut.Value.ToString());
                AppConfigHelper.SetAppValue(GlobalVar.ErpGetDuration, intErpGet.Value.ToString());
                AppConfigHelper.SetAppValue(GlobalVar.MesGetDuration, intMesGet.Value.ToString());
                AppConfigHelper.SetAppValue(GlobalVar.VinExeDuration, intVinExe.Value.ToString());
                AppConfigHelper.SetAppValue(GlobalVar.JisSortDuration, intJisSort.Value.ToString());
                AppConfigHelper.SetAppValue(GlobalVar.JisPartDuration, intJisPart.Value.ToString());
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

                wmsServer.Text = AppConfigHelper.GetAppValue(GlobalVar.WmsServer);
                wmsPort.Text = AppConfigHelper.GetAppValue(GlobalVar.WmsPort);
                wmsDb.Text = AppConfigHelper.GetAppValue(GlobalVar.WmsDb);
                wmsUser.Text = AppConfigHelper.GetAppValue(GlobalVar.WmsUser);
                wmsPwd.Text = EncryptHelper.Decrypt(AppConfigHelper.GetAppValue(GlobalVar.WmsPassword));

                jisServer.Text = AppConfigHelper.GetAppValue(GlobalVar.JisServer);
                jisPort.Text = AppConfigHelper.GetAppValue(GlobalVar.JisPort);
                jisDb.Text = AppConfigHelper.GetAppValue(GlobalVar.JisDb);
                jisUser.Text = AppConfigHelper.GetAppValue(GlobalVar.JisUser);
                jisPwd.Text = EncryptHelper.Decrypt(AppConfigHelper.GetAppValue(GlobalVar.JisPassword));

                mesServer.Text = AppConfigHelper.GetAppValue(GlobalVar.MesServer);
                mesPort.Text = AppConfigHelper.GetAppValue(GlobalVar.MesPort);
                mesDb.Text = AppConfigHelper.GetAppValue(GlobalVar.MesDb);
                mesUser.Text = AppConfigHelper.GetAppValue(GlobalVar.MesUser);
                mesPwd.Text = EncryptHelper.Decrypt(AppConfigHelper.GetAppValue(GlobalVar.MesPassword));

                FtpServer.Text = AppConfigHelper.GetAppValue(GlobalVar.FtpServer);
                FtpPort.Text = AppConfigHelper.GetAppValue(GlobalVar.FtpPort);
                FtpUser.Text = AppConfigHelper.GetAppValue(GlobalVar.FtpUser);
                FtpPassword.Text = EncryptHelper.Decrypt(AppConfigHelper.GetAppValue(GlobalVar.FtpPassword));
                FtpRootPath.Text = AppConfigHelper.GetAppValue(GlobalVar.FtpRootPath);
                FtpFromErp.Text = AppConfigHelper.GetAppValue(GlobalVar.FtpFromErp);
                FtpToErp.Text = AppConfigHelper.GetAppValue(GlobalVar.FtpToErp);

                txtPathRoot.Text = AppConfigHelper.GetAppValue(GlobalVar.LocalRoot);
                txtPathFromErp.Text = AppConfigHelper.GetAppValue(GlobalVar.PathFromErp);
                txtPathToErp.Text = AppConfigHelper.GetAppValue(GlobalVar.PathToErp);
                txtPathBak.Text = AppConfigHelper.GetAppValue(GlobalVar.PathBak);

                jisSortPath.Text = AppConfigHelper.GetAppValue(GlobalVar.JisSortPath);
                jisSortPathBak.Text = AppConfigHelper.GetAppValue(GlobalVar.JisSortPathBak);

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
