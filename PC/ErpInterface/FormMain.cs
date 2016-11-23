using System;
using System.ComponentModel;
using System.Windows.Forms;
using ChangKeTec.Wms.Common;
using ChangKeTec.Wms.Controllers;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar;

namespace ChangKeTec.Wms.ErpInterface
{
    public partial class FormMain : Office2007Form
    {
        private Timer _timerErpGet;
        private Timer _timerErpPut;
        private Timer _timer;
        private QadInterface _qadInterface;
        public FormMain()
        {
            InitializeComponent();
            Init();
//            StringRedir r = new StringRedir(ref txtLog);
            StringRedir r = new StringRedir(ref listView1);
            Console.SetOut(r);
        }


        private int erpGetDuration=Convert.ToInt32(AppConfigHelper.GetAppValue(GlobalVar.ErpGetDuration));
        int mesGetDuration = Convert.ToInt32(AppConfigHelper.GetAppValue(GlobalVar.MesGetDuration));
        int erpPutDuration = Convert.ToInt32(AppConfigHelper.GetAppValue(GlobalVar.ErpPutDuration));
        int vinExeDuration = Convert.ToInt32(AppConfigHelper.GetAppValue(GlobalVar.VinExeDuration));
        int jisSortDuration = Convert.ToInt32(AppConfigHelper.GetAppValue(GlobalVar.JisSortDuration));
        int jisPartDuration = Convert.ToInt32(AppConfigHelper.GetAppValue(GlobalVar.JisPartDuration));

        private void Init()
        {
            var localRoot = AppConfigHelper.GetAppValue(GlobalVar.LocalRoot);
            var pathGet = AppConfigHelper.GetAppValue(GlobalVar.PathFromErp);
            var pathPut = AppConfigHelper.GetAppValue(GlobalVar.PathToErp);
            var pathBackup = AppConfigHelper.GetAppValue(GlobalVar.PathBak);

            var ftpServer = AppConfigHelper.GetAppValue(GlobalVar.FtpServer);
            var ftpPort = AppConfigHelper.GetAppValue(GlobalVar.FtpPort);
            var ftpUser = AppConfigHelper.GetAppValue(GlobalVar.FtpUser);
            var ftpPassword = EncryptHelper.Decrypt(AppConfigHelper.GetAppValue(GlobalVar.FtpPassword));
            var ftpRootPath = AppConfigHelper.GetAppValue(GlobalVar.FtpRootPath);
            var ftpFromErp = AppConfigHelper.GetAppValue(GlobalVar.FtpFromErp);
            var ftpToErp = AppConfigHelper.GetAppValue(GlobalVar.FtpToErp);

            var jisSortPath = AppConfigHelper.GetAppValue(GlobalVar.JisSortPath);
            var jisSortPathBak = AppConfigHelper.GetAppValue(GlobalVar.JisSortPathBak);

            erpGetDuration = Convert.ToInt32(AppConfigHelper.GetAppValue(GlobalVar.ErpGetDuration));
            mesGetDuration = Convert.ToInt32(AppConfigHelper.GetAppValue(GlobalVar.MesGetDuration));
            erpPutDuration = Convert.ToInt32(AppConfigHelper.GetAppValue(GlobalVar.ErpPutDuration));
            vinExeDuration = Convert.ToInt32(AppConfigHelper.GetAppValue(GlobalVar.VinExeDuration));
            jisSortDuration = Convert.ToInt32(AppConfigHelper.GetAppValue(GlobalVar.JisSortDuration));
            jisPartDuration = Convert.ToInt32(AppConfigHelper.GetAppValue(GlobalVar.JisPartDuration));

            lblErpGet.Text = erpGetDuration.ToString();
            lblErpPut.Text = erpPutDuration.ToString();
            lblMes.Text = mesGetDuration.ToString();
            lblVin.Text = vinExeDuration.ToString();
            lblJisSort.Text = jisSortDuration.ToString();
            lblJisPart.Text = (jisPartDuration*60*60).ToString();

            _qadInterface = new QadInterface(localRoot, pathGet, pathPut, pathBackup, ftpServer, ftpPort, ftpUser,
                ftpPassword, ftpRootPath, ftpFromErp, ftpToErp);



            _timerErpGet = new Timer {Interval = erpGetDuration*1000};
            _timerErpGet.Tick += TimerErpGetTick;

            _timerErpPut = new Timer {Interval = erpPutDuration*1000};
            _timerErpPut.Tick += TimerErpPutTick;

         

            _timer = new Timer {Interval = 1000};
            _timer.Tick += _timer_Tick;
            btnStart.Enabled = true;
            btnStop.Enabled = false;

        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            if (sbErpGet.Value) lblErpGet.Text = (Convert.ToInt16(lblErpGet.Text) - 1).ToString();
            if (sbErpPut.Value) lblErpPut.Text = (Convert.ToInt16(lblErpPut.Text) - 1).ToString();
            if (sbMesGet.Value) lblMes.Text = (Convert.ToInt16(lblMes.Text) - 1).ToString();
            if (sbVinExe.Value) lblVin.Text = (Convert.ToInt16(lblVin.Text) - 1).ToString();
            if (sbJisSortGet.Value) lblJisSort.Text = (Convert.ToInt16(lblJisSort.Text) - 1).ToString();
            if (sbJisPartGet.Value) lblJisPart.Text = (Convert.ToInt16(lblJisPart.Text) - 1).ToString();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Console.WriteLine(@"系统启动");
            lblErpGet.Visible = sbErpGet.Value;
            if (sbErpGet.Value)
            {
                _qadInterface.Receive();
                _timerErpGet.Start();
                Console.WriteLine(@"启动：获取ERP接口数据，执行周期："+ _timerErpGet.Interval/1000+"秒");
            }
            lblErpPut.Visible = sbErpPut.Value;
            if (sbErpPut.Value)
            {
                _qadInterface.Send();
                _timerErpPut.Start();
                Console.WriteLine(@"启动：发送ERP接口数据，执行周期：" + _timerErpPut.Interval / 1000 + "秒");
            }
          
            _timer.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Console.WriteLine( @"系统停止");
            if (_timerErpGet.Enabled)
            {
                _timerErpGet.Stop();
                Console.WriteLine(@"停止：获取ERP接口数据");
            }
            if (_timerErpPut.Enabled)
            {
                _timerErpPut.Stop();
                Console.WriteLine(@"停止：发送ERP接口数据");
            }
          
            _timer.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnErpGet_Click(object sender, EventArgs e)
        {
            Console.WriteLine( @"手动获取ERP");
            _qadInterface.Receive();
        }

        private void btnErpPut_Click(object sender, EventArgs e)
        {
            Console.WriteLine( @"手动发送ERP");
            _qadInterface.Send();
        }


        private void btnSetting_Click(object sender, EventArgs e)
        {
            FormSetting form = new FormSetting();
            var dr= form.ShowDialog(this);
            if (dr != DialogResult.OK) return;
            Init();

        }

        private void TimerErpPutTick(object sender, EventArgs e)
        {
            lblErpPut.Text = erpPutDuration.ToString();
            _qadInterface.Send();
        }

        private void TimerErpGetTick(object sender, EventArgs e)
        {
            lblErpGet.Text = erpGetDuration.ToString();
            _qadInterface.Receive();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            var str = listView1.SelectedItems[0].SubItems[1].Text;
            txtLog.Text = str;
//            toolTip1.SetToolTip(listView1,str);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
