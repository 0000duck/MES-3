using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using ChangKeTec.Wms.Common;
using ChangKeTec.Wms.Common.ComboBox;
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
    public partial class PopupInventoryDetail : Office2007Form
    {
        private BillType _billType = BillType.InventoryPlan;
        private readonly GridppReport _report;

        private TB_BILL _bill = new TB_BILL();
        private TB_INVENTORY_DETAIL _inventorydetail = new TB_INVENTORY_DETAIL();

        private readonly string DetailTableName = "TB_INVENTORY_DETAIL";
        private readonly string IndexColumnName = "BillNum";

        private SpareEntities _db = EntitiesFactory.CreateWmsInstance();

        public PopupInventoryDetail()
        {
            InitializeComponent();
            propertyBill.SelectedObject = _bill;
        }

        public PopupInventoryDetail(TB_BILL bill)
        {
            InitializeComponent();
            _bill = bill;
            _report = ReportHelper.InitReport(_billType);
            _report.Initialize += () => _report_Initialize(_report, _inventorydetail, DetailTableName, IndexColumnName);
        }

        private void _report_Initialize(GridppReport report, TB_INVENTORY_DETAIL locBill, string detailTableName, string indexColumnName)
        {
            Console.WriteLine(report.Parameters.Count);
            report.ParameterByName("BillNum").AsString = locBill.BillNum;
            report.ParameterByName("LocCode").AsString = locBill.CheckLocCode;
            report.ParameterByName("BillTime").AsString = ((DateTime)locBill.CheckTime).ToString(GlobalVar.LongTimeString);
            report.ParameterByName("OperName").AsString = locBill.OperName;
            report.ParameterByName("CheckQty").AsString = locBill.CheckQty.ToString();
            report.ConnectionString = EntitiesFactory.WmsConnectionString;
            report.DetailGrid.Recordset.ConnectionString = EntitiesFactory.WmsConnectionString;
            report.DetailGrid.Recordset.QuerySQL = $"select * from {detailTableName} where {indexColumnName} = '{locBill.BillNum}' and CheckLocCode='{_inventorydetail.CheckLocCode}'";
        }

        private void FormWhseReceive_Load(object sender, EventArgs e)
        {
            gcPart.EditorType = typeof (PartComboBox);
            gcLoc.EditorType = typeof (StoreLocComboBox);
            propertyBill.SelectedObject = _bill;
            SetDetailDataSource(_bill.BillNum); 
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = DataGridViewHelper.DgvToTable(grid.PrimaryGrid, EnumHelper.GetDescription(_billType));
            ExcelWriter.Write(dt);
        }

        private void SetDetailDataSource(string billNum)
        {
            bs.DataSource = _db.TB_INVENTORY_DETAIL.Where(p => p.BillNum == billNum).ToList();
            grid.PrimaryGrid.DataSource = bs;
            bn.BindingSource = bs;
        }

        private void propertyBill_PropertyValueChanging(object sender, PropertyValueChangingEventArgs e)
        {
            
        }

        private void ItemBtnPrint_Click(object sender, EventArgs e)
        {
            if (_inventorydetail == null || _inventorydetail.BillNum == null)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bs.EndEdit();
                var detailList = (List<TB_INVENTORY_DETAIL>) bs.DataSource;
                SpareEntities db = EntitiesFactory.CreateWmsInstance();
                BillHandler.AddOrUpdateInventoryDetail(db, _bill, detailList);
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
