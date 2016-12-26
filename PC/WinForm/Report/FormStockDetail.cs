using System;
using System.Collections.Generic;
using System.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ChangKeTec.Wms.Common;
using ChangKeTec.Wms.Controllers;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar;

namespace ChangKeTec.Wms.WinForm.Report
{
    public partial class FormStockDetail : Office2007Form
    {
        private List<VIEW_STOCK_DETAIL> _billList;
        private VIEW_STOCK_DETAIL _selectedBill;
        public FormStockDetail()
        {
            InitializeComponent();
            _billList = new List<VIEW_STOCK_DETAIL>();
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            _billList = new List<VIEW_STOCK_DETAIL>();
            _selectedBill = new VIEW_STOCK_DETAIL();
            GetBillList();
            
        }

        private void GetBillList()
        {
            using (SpareEntities db = EntitiesFactory.CreateSpareInstance())
            {
                _billList = ReportViewController.GetStockDetail(db);
                if (!string.IsNullOrEmpty(GlobalVar.Oper.DeptCode))
                {
                    var _SLlist =
                        db.TA_STORE_LOCATION.Where(l => l.WhseCode == GlobalVar.Oper.DeptCode)
                            .Select(l => l.LocCode)
                            .ToList();
                    _billList = _billList.Where(p => _SLlist.Contains(p.库位)).ToList();

                }
                grid.PrimaryGrid.DataSource = _billList;
                var totalQty = _billList.Sum(p => p.数量);
                var totalAmount = _billList.Sum(p => p.金额);
                grid.PrimaryGrid.Footer.Text = "库存总量："+ totalQty + " 金额：" + totalAmount;
            }
        }

        private void ItemBtnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = DataGridViewHelper.DgvToTable(grid, "VIEW_STOCK_DETAIL");
            ExcelWriter.Write(dt);
        }

        private void dgvBill_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
//            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
//            var row = dgvBill.Rows[e.RowIndex];
//            var reportId = row.Cells["PartCode"].Value;
//            if (reportId == null)
//            {
//                return;
//            }
//            _selectedBill = _billList.SingleOrDefault(p => p.零件号 == reportId.ToString());
        }
    }
}
