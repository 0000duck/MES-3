using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace ChangKeTec.Wms.WinForm.PopUp
{
    public partial class PopupDateFilter : Office2007Form
    {
        public DateTime DtBegin
        {
            get { return dtInputBegin.Value; }
        }

        public DateTime DtEnd
        {
            get { return dtInputEnd.Value; }
        }

        public int BeginHour
        {
            get { return intBeginTime.Value; }
        }

        public int EndHour
        {
            get { return intEndTime.Value; }
        }

        public PopupDateFilter()
        {
            InitializeComponent();
        }

        private void frmQueryByDate_Load(object sender, EventArgs e)
        {
            dtInputEnd.Value = DateTime.Now;
            dtInputBegin.Value = DateTime.Now.AddHours(-8);
//            dtInputBegin.Value = DateTime.Now.Date.AddDays(-GlobalVar.DefaultPreDays);
        }

        private void cbFromBegin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFromBegin.Checked)
            {
                dtInputBegin.Value = new DateTime(2000, 1, 1);
                dtInputBegin.IsInputReadOnly = true;
            }
            else
            {
                dtInputBegin.IsInputReadOnly = false;
            }
        }

        private void cbToNow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFromBegin.Checked)
            {
                dtInputEnd.Value = DateTime.Now;
                dtInputEnd.IsInputReadOnly = true;
            }
            else
            {
                dtInputEnd.IsInputReadOnly = false;
            }
        }

        private void btnThisYear_Click(object sender, EventArgs e)
        {
            dtInputBegin.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtInputEnd.Value = DateTime.Now;

        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtInputBegin.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtInputEnd.Value = DateTime.Now;
        }

        private void btnThisWeek_Click(object sender, EventArgs e)
        {
            dtInputBegin.Value = DateTime.Now.Date.AddDays(1 - Convert.ToInt32(DateTime.Now.DayOfWeek.ToString("d")));
            dtInputEnd.Value = DateTime.Now;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void dtInputBegin_ValueChanged(object sender, EventArgs e)
        {
            if (dtInputBegin.Value < dtInputEnd.Value)
            {
                return;
            }
            MessageBox.Show("开始日期必须在结束日期之前！");
            dtInputBegin.Value = dtInputEnd.Value.AddDays(-1);
        }

        private void dtInputEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dtInputBegin.Value < dtInputEnd.Value)
            {
                return;
            }
            MessageBox.Show("开始日期必须在结束日期之前！");
            dtInputEnd.Value = dtInputBegin.Value.AddDays(1);
        }

        private void btnOneYear_Click(object sender, EventArgs e)
        {
            dtInputEnd.Value = DateTime.Now;
            dtInputBegin.Value = DateTime.Now.Date.AddYears(-1);

        }

        private void btnOneMonth_Click(object sender, EventArgs e)
        {

            dtInputEnd.Value = DateTime.Now;
            dtInputBegin.Value = DateTime.Now.Date.AddMonths(-1);
        }

        private void btnOneWeek_Click(object sender, EventArgs e)
        {
            dtInputEnd.Value = DateTime.Now;
            dtInputBegin.Value = DateTime.Now.Date.AddDays(-GlobalVar.DefaultPreDays);
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            intBeginTime.Value = 8;
            intEndTime.Value = 16;
        }

        private void btnBB_Click(object sender, EventArgs e)
        {
            intBeginTime.Value = 16;
            intEndTime.Value = 24;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            intBeginTime.Value = 0;
            intEndTime.Value = 8;
        }
    }
}
