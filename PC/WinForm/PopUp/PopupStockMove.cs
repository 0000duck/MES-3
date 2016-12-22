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
    using ChangKeTec.Wms.Controllers.Bill;
    using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using ChangKeTec.Wms.WinForm.Util;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.WinForm.PopUp
{
    public partial class PopupStockMove : Office2007Form
    {
        private BillType _billType = BillType.StockMove;
        private VW_BILL _bill = new VW_BILL();
        private SpareEntities _db = EntitiesFactory.CreateSpareInstance();
        public PopupStockMove()
        {
            InitializeComponent();
            propertyBill.SelectedObject = _bill;
        }

        public PopupStockMove(VW_BILL bill)
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
            gcPartCode.EditorType = typeof (PartComboTree);
            gcToLocCode.EditorType = typeof (StoreLocComboBox);
            if (_bill.UID == 0)
            {
                _bill.单据类型 = (int)BillType.StockMove;
                _bill.制单日期 = DateTime.Now;
            }
            propertyBill.SelectedObject = _bill;
            SetDetailDataSource(_bill.单据编号);
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
                if (_bill.单据类型 != (int)BillType.StockMove)
                {
                    MessageHelper.ShowError("请输入有效的单据类型！移库单据类型为：" + (int)BillType.StockMove);
                    return;
                }
                var detailList = (List<TB_STOCK_MOVE>)bs.DataSource;
                if (detailList.Count == 0)
                {
                    MessageHelper.ShowError("请维护移动明细！");
                    return;
                }
                SpareEntities db = EntitiesFactory.CreateSpareInstance();
                BillHandler.AddStockMove(db, _bill.VWToBill(), detailList);
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
            Expression<Func<TB_STOCK_MOVE, dynamic>> select = c => c;
            Expression<Func<TB_STOCK_MOVE, bool>> where = c => c.BillNum==billnum;
            Expression<Func<TB_STOCK_MOVE, long>> order = c => c.UID;
            _list = EniitiesHelper.GetData(_db,
                select,
                where,
                order,
                out count);
            bs.DataSource = _db.TB_STOCK_MOVE.Where(p => p.BillNum == billnum).ToList();
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
            SetDetailDataSource(_bill.单据编号);
            
        }

        private void propertyBill_PropertyValueChanging(object sender, PropertyValueChangingEventArgs e)
        {
            //e.Handled = true;
        }

        private void grid_CellValueChanged(object sender, GridCellValueChangedEventArgs e)
        {
            GridCell cell = e.GridCell;
            var row = (GridRow)e.GridPanel.Rows[cell.RowIndex];
            //根据选择的零件号，获取库存批次，单价
            if (cell.GridColumn == gcPartCode)
            {
                var stockDetail = StockDetailController.GetListByPartCode(_db, cell.Value.ToString()).OrderBy(p => p.Batch).FirstOrDefault();
                row.Cells[gcBatch].Value = stockDetail.Batch;
                row.Cells[gcFromLocCode].Value = stockDetail.LocCode;
            }
        }
    }
}
