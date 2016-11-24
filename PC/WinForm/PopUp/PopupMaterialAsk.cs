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

        private void FormWhseReceive_Load(object sender, EventArgs e)
        {
            propertyBill.SelectedObject = _bill;
            SetDetailDataSource(_bill.BillNum);
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = DataGridViewHelper.DgvToTable(grid.MasterPrimaryGrid, EnumHelper.GetDescription(_billType));
            ExcelWriter.Write(dt);
        }

        List<dynamic> _list;

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                List<TB_ASK> detailList = (from TB_ASK d in _list select d).ToList();
                SpareEntities db = EntitiesFactory.CreateWmsInstance();
                BillHandler.AddMaterialAsk(db, _bill, detailList);
                EntitiesFactory.SaveDb(db);
            }
            catch (Exception ex)
            {
                MessageHelper.ShowInfo(ex.ToString());
            }
        }

        private int SetDetailDataSource(string billnum)
        {
            int count;
            Expression<Func<TB_ASK, dynamic>> select =c => c;
            Expression<Func<TB_ASK, bool>> where = c => c.BillNum==billnum;
            Expression<Func<TB_ASK, long>> order = c => c.UID;
            _list = EniitiesHelper.GetData(_db,
                select,
                where,
                order,
                out count);
            grid.MasterDataSource = _list;
            List<string> readonlyColumns = new List<string> { "UID", "单据号", };
            foreach (GridColumn column in grid.MasterPrimaryGrid.Columns)
            {
                if (readonlyColumns.Contains(column.DataPropertyName))
                    column.ReadOnly = true;
                else
                    column.ReadOnly = false;
            }
            return count;

            

        }


        

        private void grid_GridCellActivated(object sender, GridCellActivatedEventArgs e)
        {

        }

        
        private void grid_DataRefreshed(object sender, CktMasterDetailGrid.QtyEventArgs e)
        {
            SetDetailDataSource(_bill.BillNum);
            
        }

        private void propertyBill_PropertyValueChanging(object sender, PropertyValueChangingEventArgs e)
        {
            e.Handled = true;
        }
    }
}
