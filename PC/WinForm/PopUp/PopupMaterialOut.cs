using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using ChangKeTec.Wms.Common;
using ChangKeTec.Wms.Common.UC;
using ChangKeTec.Wms.Common.ComboBox;
using ChangKeTec.Wms.Controllers;
using ChangKeTec.Wms.Controllers.Bill;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using ChangKeTec.Wms.WinForm.Util;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.WinForm.PopUp
{
    public partial class PopupMaterialOut : Office2007Form
    {
        private BillType _billType = BillType.MaterialDeliver;
        private TB_BILL _bill = new TB_BILL();
        private SpareEntities _db = EntitiesFactory.CreateSpareInstance();
        public PopupMaterialOut()
        {
            InitializeComponent();
            propertyBill.SelectedObject = _bill;
        }

        public PopupMaterialOut(TB_BILL bill)
        {
            InitializeComponent();
            _bill = bill;
        }

        private void FormWhseReceive_Load(object sender, EventArgs e)
        {
            gcPartCode.EditorType = typeof(PartComboTree);
            gcDeptCode.EditorType = typeof(DeptComboBox);
            gcProjectCode.EditorType = typeof(ProjectComboBox);
            gcWorkLineCode.EditorType = typeof(WorkLineComboBox);
            gcEqptCode.EditorType = typeof(MachineComboBox);
            if (_bill.UID == 0)
            {
                _bill.BillType = (int)BillType.MaterialDeliver;
                _bill.BillTime = DateTime.Now;
            }
            propertyBill.SelectedObject = _bill;
            SetDetailDataSource(_bill.BillNum);
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = DataGridViewHelper.DgvToTable(grid.PrimaryGrid, EnumHelper.GetDescription(_billType));
            ExcelWriter.Write(dt);
        }

        List<dynamic> _list;

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bs.EndEdit();
                if (_bill.BillType != (int)BillType.MaterialDeliver)
                {
                    MessageHelper.ShowError("请输入有效的出库类型！出库单据类型为：" + (int)BillType.MaterialDeliver);
                    return;
                }
                if (_bill.SubBillType != (int)SubBillType.SpareLoan && _bill.SubBillType != (int)SubBillType.SpareOut)
                {
                    MessageHelper.ShowError("维护的子单据类型无效！领用出库类型为：" + (int)SubBillType.SpareOut + "借用出库类型为：" + (int)SubBillType.SpareLoan);
                    return;
                }
                var detailList = (List<TB_OUT>)bs.DataSource;
                if (detailList.Count == 0)
                {
                    MessageHelper.ShowError("请维护领用申请明细！");
                    return;
                }
                //List<TB_OUT> detailList = (from TB_OUT d in _list select d).ToList();
                SpareEntities db = EntitiesFactory.CreateSpareInstance();
                BillHandler.AddMaterialOut(db, _bill, detailList);
                EntitiesFactory.SaveDb(db);
                MessageHelper.ShowInfo("保存成功！");
            }
            catch (Exception ex)
            {
                MessageHelper.ShowInfo(ex.ToString());
            }
        }

        private int SetDetailDataSource(string billnum)
        {
            int count;
            Expression<Func<TB_OUT, dynamic>> select = c => c;
            Expression<Func<TB_OUT, bool>> where = c => c.BillNum==billnum;
            Expression<Func<TB_OUT, long>> order = c => c.UID;
            _list = EniitiesHelper.GetData(_db,
                select,
                where,
                order,
                out count);
            bs.DataSource = _db.TB_OUT.Where(p => p.BillNum == billnum).ToList();
            //bs.DataSource = _list;
            grid.PrimaryGrid.DataSource = bs;            
            bn.BindingSource = bs;
            List<string> readonlyColumns = new List<string> { "UID", "单据号", };
            foreach (GridColumn column in grid.PrimaryGrid.Columns)
            {
                if (readonlyColumns.Contains(column.DataPropertyName))
                    column.ReadOnly = true;
                else
                    column.ReadOnly = false;
            }
            return count;
        }

        private void grid_DataRefreshed(object sender, CktMasterDetailGrid.QtyEventArgs e)
        {
            SetDetailDataSource(_bill.BillNum);           
        }

        private void propertyBill_PropertyValueChanging(object sender, PropertyValueChangingEventArgs e)
        {
            //e.Handled = true;
        }

        private void grid_RowClick(object sender, GridRowClickEventArgs e)
        {
            int rowindex = e.GridRow.RowIndex;
            GridRow row = (GridRow)grid.PrimaryGrid.Rows[rowindex];
            if (row.Cells[gcUID].Value.ToString() == "0" && Convert.ToString(row.Cells[gcPartCode].Value) == "")
            {
                row.Cells[gcTakeTime].Value = DateTime.Now;
            }
        }

        private void grid_CellValueChanged(object sender, GridCellValueChangedEventArgs e)
        {
            GridCell cell = e.GridCell;
            var row = (GridRow) e.GridPanel.Rows[cell.RowIndex];
            //根据选择的零件号，获取库存批次，单价
            if (cell.GridColumn == gcPartCode)
            {
                var stockDetail = StockDetailController.GetListByPartCode(_db, cell.Value.ToString()).OrderBy(p=>p.Batch).FirstOrDefault();
                row.Cells[gcBatch].Value = stockDetail.Batch;
                row.Cells[gcUnitPrice].Value = stockDetail.UnitPrice;
                row.Cells[gcFromLocCode].Value = stockDetail.LocCode;
            }
            //根据出库数量，自动计算金额
            if (cell.GridColumn == gcOutQty)
            {
                if (Convert.ToString(row.Cells[gcUnitPrice].Value) != "" && Convert.ToString(row.Cells[gcOutQty].Value) != "")
                {
                    row.Cells[gcAmount].Value = (decimal)row.Cells[gcUnitPrice].Value*(decimal)row.Cells[gcOutQty].Value;
                }
            }
        }
    }
}
