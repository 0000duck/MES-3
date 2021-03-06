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
    public partial class FormCalSafeQty : Office2007Form
    {
        private List<VIEW_CalSafeQty> _billList;
        private VIEW_CalSafeQty _selectedBill;
        public FormCalSafeQty()
        {
            InitializeComponent();
            _billList = new List<VIEW_CalSafeQty>();
        }



        private void FormLog_Load(object sender, EventArgs e)
        {
            _billList = new List<VIEW_CalSafeQty>();
            _selectedBill = new VIEW_CalSafeQty();
            GetBillList();
        }

        private void GetBillList()
        {
            using (SpareEntities db = EntitiesFactory.CreateSpareInstance())
            {
                _billList = ReportViewController.GetSafeQtysList(db);
                if (!string.IsNullOrEmpty(GlobalVar.Oper.DeptCode))
                {
                    _billList = _billList.Where(p => p.仓库 == GlobalVar.Oper.DeptCode).ToList();
                }
                grid.PrimaryGrid.DataSource = _billList;
            }
        }

        private void ItemBtnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = DataGridViewHelper.DgvToTable(grid, "VIEW_CalSafeQty");
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
