using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ChangKeTec.Wms.Common;
using ChangKeTec.Wms.Controllers;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Util;
using ChangKeTec.Wms.Utils;
using ChangKeTec.Wms.WinForm.PopUp;
using ChangKeTec.Wms.WinForm.Util;
using DevComponents.DotNetBar;

namespace ChangKeTec.Wms.WinForm.Report
{
    public partial class FormIOSUMMARYByStore : Office2007Form
    {
        private DateTime _beginTime = DateTime.Now.AddDays(-1);
        private DateTime _endTime = DateTime.Now.AddDays(1);
        private List<VIEW_IO_SUMMARY_ByStock> _billList;
        private VIEW_IO_SUMMARY_ByStock _selectedBill;
        public FormIOSUMMARYByStore()
        {
            InitializeComponent();
            _billList = new List<VIEW_IO_SUMMARY_ByStock>();
            dgvBill.AutoGenerateColumns = false;
        }



        private void FormLog_Load(object sender, EventArgs e)
        {
            _billList = new List<VIEW_IO_SUMMARY_ByStock>();
            _selectedBill = new VIEW_IO_SUMMARY_ByStock();
            GetBillList();
        }

        private void GetBillList()
        {
            using (SpareEntities db = EntitiesFactory.CreateSpareInstance())
            {
                _billList = ReportViewController.GetIoSummarysByStockDetailList(db,_beginTime, _endTime);
                dgvBill.DataSource = ListHelper.ListToDataTable(_billList);
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            var txt = txtSearch.Text;
            if (txt.Length < 2)
            {
                MessageBox.Show("请输入至少2个字符！");
                return;
            }
            var list = ListHelper.SearchList(_billList.ToList(), txt);

            _billList = new List<VIEW_IO_SUMMARY_ByStock>(list);
            dgvBill.DataSource = _billList;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            GetBillList();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            PopupDateFilter dateFilter = new PopupDateFilter();
            DialogResult dr = dateFilter.ShowDialog();
            if(dr!=DialogResult.OK)return;
            _beginTime = dateFilter.DtBegin;
            _endTime = dateFilter.DtEnd;
            GetBillList();
        }

        private void ItemBtnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = DataGridViewHelper.DgvToTable(dgvBill, "VIEW_IO_SUMMARY_ByStock");
            ExcelWriter.Write(dt);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char) Keys.Enter) return;
            Search();
        }

        private void dgvBill_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            var row = dgvBill.Rows[e.RowIndex];
            var reportId = row.Cells["PartCode"].Value;
            if (reportId == null)
            {
                return;
            }
//            _selectedBill = _billList.SingleOrDefault(p => p.零件号 == reportId.ToString());
        }
    }
}
