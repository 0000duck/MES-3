﻿using System;
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
    public partial class FormInventoryDetail : Office2007Form
    {
        private List<VIEW_INVENTORY_DETAIL> _billList;
        private VIEW_INVENTORY_DETAIL _selectedBill;
        public FormInventoryDetail()
        {
            InitializeComponent();
            _billList = new List<VIEW_INVENTORY_DETAIL>();
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            _billList = new List<VIEW_INVENTORY_DETAIL>();
            _selectedBill = new VIEW_INVENTORY_DETAIL();
            GetBillList();
        }

        private void GetBillList()
        {
            using (SpareEntities db = EntitiesFactory.CreateSpareInstance())
            {
                _billList = ReportViewController.GetInventoryDetail(db);
                _billList = _billList.Where(p => p.差异数 != 0).ToList();
                if (!string.IsNullOrEmpty(GlobalVar.Oper.DeptCode))
                {
                    var _SLlist =
                        db.TA_STORE_LOCATION.Where(l => l.WhseCode == GlobalVar.Oper.DeptCode)
                            .Select(l => l.LocCode)
                            .ToList();
                    _billList = _billList.Where(p => _SLlist.Contains(p.盘点库位)).ToList();

                }
                grid.PrimaryGrid.DataSource = _billList;
            }
        }

        private void ItemBtnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = DataGridViewHelper.DgvToTable(grid, "VIEW_INVENTORY_DETAIL");
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
