    using System;
using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
using System.Linq;
using System.Linq.Expressions;
using ChangKeTec.Wms.Common;
    using ChangKeTec.Wms.Common.ComboBox;
    using ChangKeTec.Wms.Common.UC;
using ChangKeTec.Wms.Controllers;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using ChangKeTec.Wms.WinForm.Util;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.WinForm.PopUp
{
    public partial class PopupSpareReturn : Office2007Form
    {
        private BillType _billType = BillType.SpareReturn;
        private TB_BILL _bill = new TB_BILL();
        private SpareEntities _db = EntitiesFactory.CreateWmsInstance();
        public PopupSpareReturn()
        {
            InitializeComponent();
            propertyBill.SelectedObject = _bill;
        }

        public PopupSpareReturn(TB_BILL bill)
        {
            InitializeComponent();
            _bill = bill;
        }

        private DateTime _Date = DateTime.Today;
        [PropertyDateTimeEditor(), Description("日期编辑")]
        public DateTime BillTime
        {
            get { return _Date; }
            set { _Date = value; OnPropertyChanged(new PropertyChangedEventArgs("BillTime")); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler eh = PropertyChanged;
            if (eh != null) eh(this, e);
        }

        private void FormWhseReceive_Load(object sender, EventArgs e)
        {
            gcPartCode.EditorType = typeof (PartComboBox);
            gcDeptCode.EditorType = typeof(DeptComboBox);
            gcProjectCode.EditorType = typeof(ProjectComboBox);
            gcWorklineCode.EditorType = typeof(WorkLineComboBox);
            gcEqptCode.EditorType = typeof(PartComboBox);
            if (_bill.UID == 0)
            {
                _bill.BillType = (int)BillType.SpareReturn;
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
                if (_bill.BillType != (int)BillType.SpareReturn)
                {
                    MessageHelper.ShowError("请输入有效的单据类型！领用归还单据类型为：" + (int)BillType.SpareReturn);
                    return;
                }
                var detailList = (List<TB_RETURN>)bs.DataSource;
                if (detailList.Count == 0)
                {
                    MessageHelper.ShowError("请维护领用还回明细！");
                    return;
                }
                //List<TB_RETURN> detailList = (from TB_RETURN d in _list select d).ToList();
                SpareEntities db = EntitiesFactory.CreateWmsInstance();
                BillHandler.AddMaterialReturn(db, _bill, detailList);
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
            Expression<Func<TB_RETURN, dynamic>> select = c => c;
            Expression<Func<TB_RETURN, bool>> where = c => c.BillNum==billnum;
            Expression<Func<TB_RETURN, long>> order = c => c.UID;
            _list = EniitiesHelper.GetData(_db,
                select,
                where,
                order,
                out count);
            bs.DataSource = _db.TB_RETURN.Where(p => p.BillNum == billnum).ToList();
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

        private void grid_CellValueChanged(object sender, GridCellValueChangedEventArgs e)
        {
            GridCell cell = e.GridCell;
            var row = (GridRow)e.GridPanel.Rows[cell.RowIndex];
            //根据出库数量，自动计算金额
            if (cell.GridColumn == gcInQty)
            {
                if (Convert.ToString(row.Cells[gcUnitPrice].Value) != "" && Convert.ToString(row.Cells[gcInQty].Value) != "")
                {
                    row.Cells[gcAmount].Value = (decimal)row.Cells[gcUnitPrice].Value * (decimal)row.Cells[gcInQty].Value;
                }
            }
        }
    }
}
