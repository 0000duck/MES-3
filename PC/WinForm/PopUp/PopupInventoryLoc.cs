using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using ChangKeTec.Wms.Common;
using ChangKeTec.Wms.Controllers;
using ChangKeTec.Wms.Controllers.Bill;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using ChangKeTec.Wms.WinForm.Util;
using DevComponents.DotNetBar;
using gregn6Lib;

namespace ChangKeTec.Wms.WinForm.PopUp
{
    public partial class PopupInventoryLoc: Office2007Form
    {
        private BillType _billType = BillType.InventoryPlan;
        private readonly GridppReport _report;

        private TB_BILL _bill = new TB_BILL();
        private TB_INVENTORY_LOC _inventoryLoc = new TB_INVENTORY_LOC();

        private readonly string DetailTableName = "TB_INVENTORY_LOC";
        private readonly string IndexColumnName = "BillNum";

        private SpareEntities _db = EntitiesFactory.CreateWmsInstance();
        private List<TA_STORE_LOCATION> _listLoc = new List<TA_STORE_LOCATION>();
        


        public PopupInventoryLoc()
        {
            InitializeComponent();
            propertyBill.SelectedObject = _bill;
        }

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
            report.ParameterByName("OperName").AsString = locBill.OperName;
            report.ParameterByName("State").AsString = locBill.State.ToString();
            report.ParameterByName("Remark").AsString = locBill.Remark;
            report.ConnectionString = EntitiesFactory.WmsConnectionString;
            report.DetailGrid.Recordset.ConnectionString = EntitiesFactory.WmsConnectionString;
            report.DetailGrid.Recordset.QuerySQL = $"select * from {detailTableName} where {indexColumnName} = '{locBill.BillNum}' and CheckLocCode='{_inventoryLoc.LocCode}'";
        }

        private void FormWhseReceive_Load(object sender, EventArgs e)
        {
            _listLoc = _db.TA_STORE_LOCATION.ToList();
            propertyBill.SelectedObject = _bill;
            SetLocDataSource(_bill.BillNum); 
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = DataGridViewHelper.DgvToTable(grid.PrimaryGrid, EnumHelper.GetDescription(_billType));
            ExcelWriter.Write(dt);
        }

        private void SetLocDataSource(string billnum)
        {           
            bs.DataSource = _listLoc;
            foreach (var loc in _listLoc)
            {
                if (InventoryController.GetLoc(_db, _bill.BillNum, loc.LocCode) != null)
                {
                    loc.IsCheck = true;
                }
            }
            grid.PrimaryGrid.DataSource = bs;
//            int count;
//            Expression<Func<TB_INVENTORY_LOC, dynamic>> select =c => c;
//            Expression<Func<TB_INVENTORY_LOC, bool>> where = c => c.BillNum==billnum;
//            Expression<Func<TB_INVENTORY_LOC, long>> order = c => c.UID;
//                
//            _list = EniitiesHelper.GetData(_db,
//                @select,
//                @where,
//                order,
//                out count);
//            grid.PrimaryGrid.DataSource = _list;
//            return count;
        }

        private int SetDetailDataSource(string billNum, string locCode)
        {
            int count;
            Expression<Func<TB_INVENTORY_DETAIL, dynamic>> select = c => c;
            Expression<Func<TB_INVENTORY_DETAIL, bool>> where = c => c.BillNum == billNum && c.CheckLocCode==locCode;
            Expression<Func<TB_INVENTORY_DETAIL, long>> order = c => c.UID;

            grid.PrimaryGrid.DataSource = EniitiesHelper.GetData(_db,
                select,
                where,
                order,
                out count);
            return count;
        }

        private void propertyBill_PropertyValueChanging(object sender, PropertyValueChangingEventArgs e)
        {
            
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bs.EndEdit();
                var detailList = new List<TB_INVENTORY_LOC>();
                foreach (var loc in _listLoc)
                {
                    if (loc.IsCheck)
                    {
                        var detail = new TB_INVENTORY_LOC()
                        {
                            LocCode = loc.LocCode,
                            BillTime = DateTime.Now,
                            State = 0
                        };
                        detailList.Add(detail);
                    }
                }
                if (detailList.Count == 0)
                {
                    MessageHelper.ShowError("请选择要盘点的库位！");
                    return;
                }
                //List<TB_ASK> detailList = (from TB_ASK d in _list select d).ToList();
                SpareEntities db = EntitiesFactory.CreateWmsInstance();
                BillHandler.AddInventoryLoc(db, _bill, detailList);
                EntitiesFactory.SaveDb(db);
                MessageHelper.ShowInfo("保存成功！");
            }
            catch (Exception ex)
            {
                MessageHelper.ShowInfo(ex.ToString());
            }
        }
    }
}
