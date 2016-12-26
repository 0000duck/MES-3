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
    public partial class PopupInventoryLocGroup : Office2007Form
    {
        private BillType _billType = BillType.InventoryPlan;
        private readonly GridppReport _report;

        private VW_BILL _bill = new VW_BILL();
        private TB_INVENTORY_LOC _inventoryLoc = new TB_INVENTORY_LOC();

        private readonly string DetailTableName = "TB_INVENTORY_LOC";
        private readonly string IndexColumnName = "BillNum";

        private SpareEntities _db = EntitiesFactory.CreateSpareInstance();
        private List<TA_STORE_GROUP> _listGroup = new List<TA_STORE_GROUP>();
        


        public PopupInventoryLocGroup()
        {
            InitializeComponent();
            propertyBill.SelectedObject = _bill;
        }

        public PopupInventoryLocGroup(VW_BILL bill)
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
            _listGroup = _db.TA_STORE_GROUP.ToList();
            if (_bill.UID == 0)
            {
                _bill.单据类型 = (int)BillType.InventoryPlan;
                _bill.制单日期 = DateTime.Now;
                _bill.操作者 = GlobalVar.Oper.OperName;
            }
            propertyBill.SelectedObject = _bill;
            SetLocDataSource(_bill.单据编号); 
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = DataGridViewHelper.DgvToTable(grid.PrimaryGrid, EnumHelper.GetDescription(_billType));
            ExcelWriter.Write(dt);
        }

        private void SetLocDataSource(string billnum)
        {           
            bs.DataSource = _listGroup;
//            foreach (var group in _listGroup)
//            {
//                var listloc = _db.TA_STORE_LOCATION.Where(p => p.GroupCode == group.GroupCode).ToList();
//                foreach (var loc in listloc)
//                {
//                    if (InventoryController.GetLoc(_db, _bill.单据编号, loc.LocCode) != null)
//                    {
//                        group.IsCheck = true;
//                    }
//                }
//            }
            grid.PrimaryGrid.DataSource = bs;
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
                if (_bill.单据类型 != (int)BillType.InventoryPlan)
                {
                    MessageHelper.ShowError("请输入有效的单据类型！盘点单据类型为：" + (int)BillType.InventoryPlan);
                    return;
                }
                var detailList = new List<TB_INVENTORY_LOC>();
                foreach (var group in _listGroup)
                {
                    if (group.IsCheck)
                    {
                        var loclist = _db.TA_STORE_LOCATION.Where(p => p.GroupCode == group.GroupCode).ToList();
                        foreach (var loc in loclist)
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
                }
                if (detailList.Count == 0)
                {
                    MessageHelper.ShowError("请选择要盘点的库位！");
                    return;
                }
                //List<TB_ASK> detailList = (from TB_ASK d in _list select d).ToList();
                SpareEntities db = EntitiesFactory.CreateSpareInstance();
                BillHandler.AddInventoryLoc(db, _bill.VWToBill(GlobalVar.Oper.DeptCode), detailList);
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
