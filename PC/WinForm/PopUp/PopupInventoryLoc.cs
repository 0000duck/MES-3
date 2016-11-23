using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
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
using gregn6Lib;

namespace ChangKeTec.Wms.WinForm.PopUp
{
    public partial class PopupInventoryLoc: Office2007Form
    {
        private BillType _billType = BillType.InventoryLoc;
        private readonly GridppReport _report;

        private readonly TB_BILL _bill;
        private TB_INVENTORY_LOC _inventoryLoc = new TB_INVENTORY_LOC();

        private readonly string DetailTableName = "TB_INVENTORY_DETAIL";
        private readonly string IndexColumnName = "BillNum";

        SpareEntities _db = EntitiesFactory.CreateWmsInstance();

        public PopupInventoryLoc(TB_BILL bill)
        {
            InitializeComponent();
            _bill = bill;
            _report = ReportHelper.InitReport(_billType);
            _report.Initialize += () => _report_Initialize(_report, _inventoryLoc, DetailTableName, IndexColumnName);
        }

        private void _report_Initialize(GridppReport report, TB_INVENTORY_LOC locBill, string detailTableName, string indexColumnName)
        {


            Console.WriteLine(report.Parameters.Count);
            report.ParameterByName("BillNum").AsString = locBill.BillNum;
            report.ParameterByName("LocCode").AsString = locBill.LocCode;
            report.ParameterByName("BillTime").AsString = locBill.BillTime.ToString(GlobalVar.LongTimeString);
            report.ParameterByName("CheckBeginTime").AsString = locBill.CheckBeginTime;
            report.ParameterByName("CheckEndTime").AsString = locBill.CheckEndTime;
            report.ParameterByName("ReCheckBeginTime").AsString = locBill.ReCheckBeginTime;
            report.ParameterByName("ReCheckEndTime").AsString = locBill.ReCheckEndTime;
            report.ParameterByName("OperName").AsString = locBill.OperName;
            report.ParameterByName("State").AsString = locBill.State.ToString();
            report.ParameterByName("Remark").AsString = locBill.Remark;
            report.ConnectionString = EntitiesFactory.WmsConnectionString;
            report.DetailGrid.Recordset.ConnectionString = EntitiesFactory.WmsConnectionString;
            report.DetailGrid.Recordset.QuerySQL = $"select * from {detailTableName} where {indexColumnName} = '{locBill.BillNum}' and CheckLocCode='{_inventoryLoc.LocCode}'";
        }

        private void FormWhseReceive_Load(object sender, EventArgs e)
        {
            propertyBill.SelectedObject = _bill;
            SetLocDataSource(_bill.BillNum);
        }



        private void BtnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = DataGridViewHelper.DgvToTable(grid.MasterPrimaryGrid, EnumHelper.GetDescription(_billType));
            ExcelWriter.Write(dt);
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
         
        }
        List<dynamic> _list;

        private int SetLocDataSource(string billnum)
        {
            int count;
            Expression<Func<VIEW_INVENTORY_LOC, dynamic>> select =c => c;
            Expression<Func<VIEW_INVENTORY_LOC, bool>> where = c => c.单据号==billnum;
            Expression<Func<VIEW_INVENTORY_LOC, long>> order = c => c.UID;
                
            _list = EniitiesHelper.GetData(_db,
                @select,
                @where,
                order,
                out count);
            grid.MasterDataSource = _list;
            grid.MasterPrimaryGrid.ReadOnly = true;
            return count;
        }

        private void grid_GridCellActivated(object sender, GridCellActivatedEventArgs e)
        {
            //            MessageBox.Show(e.GridCell.GridRow.DataItem.ToString());
            _inventoryLoc = _db.TB_INVENTORY_LOC.Single(p => p.UID == grid.MasterUid);
            if (_inventoryLoc == null) return;
            var count = SetDetailDataSource(_inventoryLoc.BillNum, _inventoryLoc.LocCode);
            grid.IsDetailVisible = count > 0;
        }

        private int SetDetailDataSource(string billNum, string locCode)
        {
            int count;
            Expression<Func<VIEW_INVENTORY_DETAIL, dynamic>> select = c => c;
            Expression<Func<VIEW_INVENTORY_DETAIL, bool>> where = c => c.单据号 == billNum && c.盘点库位==locCode;
            Expression<Func<VIEW_INVENTORY_DETAIL, long>> order = c => c.UID;

            grid.Detail1DataSource = EniitiesHelper.GetData(_db,
                select,
                where,
                order,
                out count);
            return count;
        }

        private void grid_DataRefreshed(object sender, CktMasterDetailGrid.QtyEventArgs e)
        {
            SetLocDataSource(_bill.BillNum);
            
        }

        private void propertyBill_PropertyValueChanging(object sender, PropertyValueChangingEventArgs e)
        {
            e.Handled = true;
        }

        private void ItemBtnPrint_Click(object sender, EventArgs e)
        {
            if (_inventoryLoc == null || _inventoryLoc.BillNum == null)
            {
                MessageHelper.ShowInfo("请选择单据！");
                return;
            }
            ReportHelper.Print(_report);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_inventoryLoc == null || _inventoryLoc.BillNum == null)
            {
                MessageHelper.ShowInfo("请选择单据！");
                return;
            }
            try
            {
                BillHandler.CancelInventoryLoc(_db, _inventoryLoc);
                MessageHelper.ShowInfo("取消盘点库位:" + _inventoryLoc.BillNum + "." + _inventoryLoc.LocCode);
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex.ToString());
                throw;
            }


        }
    }
}
