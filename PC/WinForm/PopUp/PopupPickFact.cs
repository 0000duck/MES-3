using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using ChangKeTec.Wms.Common;
using ChangKeTec.Wms.Common.UC;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using ChangKeTec.Wms.WinForm.Util;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.WinForm.PopUp
{
    public partial class PopupPickFact: Office2007Form
    {
        private BillType _billType = BillType.PickFact;
        private TB_BILL _bill = new TB_BILL();
        private SpareEntities _db = EntitiesFactory.CreateWmsInstance();
        public PopupPickFact()
        {
            InitializeComponent();
            propertyBill.SelectedObject = _bill;
        }

        public PopupPickFact(TB_BILL bill)
        {
            _bill = bill;
            propertyBill.SelectedObject = _bill;
        }

        private void FormWhseReceive_Load(object sender, EventArgs e)
        {
            SetDetailDataSource(_bill.BillNum);
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = DataGridViewHelper.DgvToTable(grid.MasterPrimaryGrid, EnumHelper.GetDescription(_billType));
            ExcelWriter.Write(dt);
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SpareEntities db = EntitiesFactory.CreateWmsInstance();
//            BillHandler.AddMaterialAsk(db,_bill, tList);
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
            Expression<Func<TB_OUT, dynamic>> select =c => c;
            Expression<Func<TB_OUT, bool>> where = c => c.BillNum==billnum;
            Expression<Func<TB_OUT, long>> order = c => c.UID;
            grid.MasterDataSource = EniitiesHelper.GetData(_db,
                select,
                where,
                order,
                out count);
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
