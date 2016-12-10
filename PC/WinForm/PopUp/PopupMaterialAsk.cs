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
    public partial class PopupMaterialAsk: Office2007Form
    {
        private BillType _billType = BillType.MaterialAsk;
        private TB_BILL _bill = new TB_BILL();
        private SpareEntities _db = EntitiesFactory.CreateWmsInstance();
        public PopupMaterialAsk()
        {
            InitializeComponent();
            propertyBill.SelectedObject = _bill;
        }

        public PopupMaterialAsk(TB_BILL bill)
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
            gcEqptCode.EditorType = typeof(EqptComboBox);

            if (_bill.UID == 0)
            {
                _bill.BillType = (int) BillType.MaterialAsk;
                //默认领用
                _bill.SubBillType = (int) SubBillType.SpareOut;
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
                if (_bill.BillType != (int) BillType.MaterialAsk)
                {
                    MessageHelper.ShowError("请输入有效的单据类型！申请单单据类型为：" + (int)BillType.MaterialAsk);
                    return;
                }
                if (_bill.SubBillType != (int) SubBillType.SpareLoan && _bill.SubBillType != (int) SubBillType.SpareOut)
                {
                    MessageHelper.ShowError("维护的子单据类型无效！领用出库类型为：" + (int)SubBillType.SpareOut + "借用出库类型为：" +(int) SubBillType.SpareLoan);
                    return;
                }
                var detailList = (List<TB_ASK>)bs.DataSource;
                if (detailList.Count == 0)
                {
                    MessageHelper.ShowError("请维护领用申请明细！");
                    return;
                }
                //List<TB_ASK> detailList = (from TB_ASK d in _list select d).ToList();
                SpareEntities db = EntitiesFactory.CreateWmsInstance();
                BillHandler.AddMaterialAsk(db, _bill, detailList);
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
            Expression<Func<TB_ASK, dynamic>> select = c =>
                new
                {
                    c.UID,
                    c.BillNum,
                    c.PartCode,
                    c.Qty,
                    c.DeptCode,
                    c.ProjectCode,
                    c.WorklineCode,
                    c.EqptCode,
                    c.AskUser,
                    c.AskTime,
                    c.ConfirmUser,
                    c.ConfirmTime,
                    c.State,
                    c.Remark
                };
            Expression<Func<TB_ASK, bool>> where = c => c.BillNum==billnum;
            Expression<Func<TB_ASK, long>> order = c => c.UID;
            _list = EniitiesHelper.GetData(_db,
                select,
                where,
                order,
                out count);
            bs.DataSource = _db.TB_ASK.Where(p => p.BillNum == billnum).ToList();
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
                row.Cells[gcAskTime].Value = DateTime.Now;
            }
        }
    }
}
