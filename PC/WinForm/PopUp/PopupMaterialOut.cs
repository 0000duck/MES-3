using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using ChangKeTec.Wms.Common;
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
    public partial class PopupMaterialOut : Office2007Form
    {
        private BillType _billType = BillType.MaterialAsk;
        private TB_BILL _bill = new TB_BILL();
        private SpareEntities _db = EntitiesFactory.CreateWmsInstance();
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
                var detailList = (List<TB_OUT>)bs.DataSource;
                if (detailList.Count == 0)
                {
                    MessageHelper.ShowError("请维护领用申请明细！");
                    return;
                }
                //List<TB_OUT> detailList = (from TB_OUT d in _list select d).ToList();
                SpareEntities db = EntitiesFactory.CreateWmsInstance();
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
    }
}
