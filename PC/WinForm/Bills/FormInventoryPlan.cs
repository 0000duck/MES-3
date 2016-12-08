using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using ChangKeTec.Wms.Common;
using ChangKeTec.Wms.Common.UC;
using ChangKeTec.Wms.Controllers;
using ChangKeTec.Wms.Controllers.Bill;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using ChangKeTec.Wms.WinForm.PopUp;
using ChangKeTec.Wms.WinForm.Util;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using gregn6Lib;

namespace ChangKeTec.Wms.WinForm.Bills
{
    public partial class FormInventoryPlan : Office2007Form
    {
        private BillType _billType = BillType.StockMove;
        private GridppReport _report;
        private TB_BILL _bill = null;
        private readonly string DetailTableName = "TB_INVENTORY_DETAIL";
        private readonly string IndexColumnName = "BillNum";
        private SpareEntities _db = EntitiesFactory.CreateWmsInstance();
        public FormInventoryPlan()
        {
            InitializeComponent();
            _report = ReportHelper.InitReport(_billType);
            _report.Initialize += () => ReportHelper._report_Initialize(_report, _bill, DetailTableName, IndexColumnName);
        }

        private void FormWhseReceive_Load(object sender, EventArgs e)
        {
            SetMasterDataSource(grid.PageSize);

        }

        private void ItemBtnPrint_Click(object sender, EventArgs e)
        {
            if (_bill == null || _bill.BillNum == null)
            {
                MessageHelper.ShowInfo("请选择单据！");
                return;
            }
            ReportHelper.Print(_report);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }
        
        private void BtnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = DataGridViewHelper.DgvToTable(grid.MasterPrimaryGrid, EnumHelper.GetDescription(_billType));
            ExcelWriter.Write(dt);
        }

        private void SetMasterDataSource(int pageSize)
        {
            Expression<Func<TB_BILL, dynamic>> select =
                c =>
                    new
                    {
                        c.UID,
                        单据编号=c.BillNum,
                        单据类型 = c.BillType,
                        单据子类型 = c.SubBillType,
                        源单编号 = c.SourceBillNum,
                        开始时间 = c.StartTime,
                        结束时间 = c.FinishTime,
                        供应商编号 = c.SplyId,
                        单据时间 = c.BillTime,
                        操作员 = c.OperName,
                        状态 = ((BillState)c.State).ToString(),
                        备注 = c.Remark,
                    };
            Expression<Func<TB_BILL, bool>> where = c => c.BillType == (int)_billType;
            Expression<Func<TB_BILL, long>> order = c => c.UID;

            int total;
            grid.MasterDataSource =EniitiesHelper.GetPagedDataDesc(_db,
                select,
                where,
                order,
                grid.PageIndex, 
                grid.PageSize,
                out total);
            if (grid.Total != total) grid.Total = total;
            if (grid.PageSize != pageSize)
                grid.PageSize = pageSize;
        }

        private int SetDetailDataSource(string billNum)
        {
            int count;
            Expression<Func<TB_STOCK_MOVE, dynamic>> select = c =>
                new
                {
                    物料号 = c.PartCode,
                    批次 = c.Batch,
                    来源库位 = c.FromLocCode,
                    目标库位 = c.ToLocCode,
                    移动数量 = c.Qty,
                    备注 = c.Remark
                };
            Expression<Func<TB_STOCK_MOVE, bool>> where = c => c.BillNum == billNum;
            Expression<Func<TB_STOCK_MOVE, long>> order = c => c.UID;

            grid.Detail1DataSource = EniitiesHelper.GetData(_db,
                select,
                where,
                order,
                out count);
            return count;

        }


        private void grid_PageSelectedIndexChanged(object sender, EventArgs e)
        {
            SetMasterDataSource(grid.PageSize);
        }

        private void grid_GridCellActivated(object sender, GridCellActivatedEventArgs e)
        {
            //            MessageBox.Show(e.GridCell.GridRow.DataItem.ToString());
            SpareEntities db = EntitiesFactory.CreateWmsInstance();
            _bill = db.TB_BILL.SingleOrDefault(p => p.UID == grid.MasterUid);
            if (_bill == null) return;
            var billNum = _bill.BillNum;
            var count = SetDetailDataSource(billNum);
            grid.IsDetailVisible = count > 0;
        }

        
        private void grid_DataRefreshed(object sender, CktMasterDetailGrid.QtyEventArgs e)
        {
            SetMasterDataSource(e.PageSize);
            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            PopupInventoryLoc popup = new PopupInventoryLoc();
            popup.ShowDialog(this);
            SetMasterDataSource(grid.PageSize);
        }

        private void btnInventoryLoc_Click(object sender, EventArgs e)
        {
            if (_bill == null || _bill.BillNum == null)
            {
                MessageHelper.ShowInfo("请选择单据！");
                return;
            }
            PopupInventoryLoc popup = new PopupInventoryLoc(_bill);
            popup.ShowDialog(this);
            SetMasterDataSource(grid.PageSize);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_bill == null || _bill.BillNum == null)
            {
                MessageHelper.ShowInfo("请选择单据！");
                return;
            }
            if (_bill.State != (int) BillState.New)
            {
                MessageHelper.ShowError("非新建单据，禁止取消！");
                return;
            }
            if (MessageHelper.ShowQuestion("是否要取消盘点计划单？") == DialogResult.Yes)
            {
                BillController.UpdateState(_db, _bill, BillState.Cancelled);
                var InventoryLocs = InventoryController.GetLocList(_db, _bill.BillNum);
                foreach (var inventoryLoc in InventoryLocs)
                {
                    InventoryController.LocCancel(_db, inventoryLoc);
                }
                EntitiesFactory.SaveDb(_db);
                MessageHelper.ShowInfo("取消盘点计划成功！");
                SetMasterDataSource(grid.PageSize);
            }
        }

        private void btnInventoryResult_Click(object sender, EventArgs e)
        {
            if (_bill == null || _bill.BillNum == null)
            {
                MessageHelper.ShowInfo("请选择单据！");
                return;
            }
            if (_bill.State != (int)BillState.New && _bill.State != (int)BillState.Handling)
            {
                MessageHelper.ShowError("非新建或执行中单据，禁止维护盘点结果！");
                return;
            }
            PopupInventoryDetail popup = new PopupInventoryDetail(_bill);
            popup.ShowDialog(this);
            SetMasterDataSource(grid.PageSize);
        }

        private void btnAdjust_Click(object sender, EventArgs e)
        {
            if (_bill == null || _bill.BillNum == null)
            {
                MessageHelper.ShowInfo("请选择单据！");
                return;
            }
            if (_bill.State != (int)BillState.Handling)
            {
                MessageHelper.ShowError("非新建或执行中单据，禁止对库存进行调整！");
                return;
            }
            if (MessageHelper.ShowQuestion("是否确定要对库存进行调整？") == DialogResult.Yes)
            {
                
            }
            BillHandler.AdjustStockByInventoryLoc(_db, _bill);
            EntitiesFactory.SaveDb(_db);
            MessageHelper.ShowInfo("调整库存成功！");
            SetMasterDataSource(grid.PageSize);
        }
    }
}
