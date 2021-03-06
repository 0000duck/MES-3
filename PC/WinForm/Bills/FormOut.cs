﻿using System;
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
    public partial class FormOut : Office2007Form
    {
        private BillType _billType = BillType.MaterialDeliver;
        private GridppReport _report;
        private VW_BILL _bill = null;
        private readonly string DetailTableName = "TB_OUT";
        private readonly string IndexColumnName = "BillNum";

        SpareEntities _db = EntitiesFactory.CreateSpareInstance();

        public FormOut()
        {
            InitializeComponent();
//            _report = ReportHelper.InitReport(_billType);
//            _report.Initialize += () => ReportHelper._report_Initialize(_report, _bill, DetailTableName, IndexColumnName);
        }

        private void FormWhseReceive_Load(object sender, EventArgs e)
        {
            SetMasterDataSource(1,grid.PageSize);
        }
        
        private void BtnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = DataGridViewHelper.DgvToTable(grid.MasterPrimaryGrid,EnumHelper.GetDescription(_billType));
            ExcelWriter.Write(dt);
        }

        private void SetMasterDataSource(int pageIndex,int pageSize)
        {
            Expression<Func<TB_BILL, dynamic>> select =
                c =>
                    new
                    {
                        c.UID,
                        单据编号=c.BillNum,
                        单据类型 = c.BillType,
                        子单据类型 = c.SubBillType,
//                        单据子类型 = c.SubBillType,
//                        采购订单编号 = c.SourceBillNum,
//                        发货单编号 = c.SourceBillNum2,
//                        开始时间 = c.StartTime,
//                        结束时间 = c.FinishTime,
//                        供应商编号 = c.SplyId,
//                        客户编号 = c.CustId,
                        单据时间 = c.BillTime,
                        操作员 = c.OperName,
                        状态 = ((BillState)c.State).ToString(),
                        备注 = c.Remark,
                    };
            Expression<Func<TB_BILL, bool>> where ;
            if (string.IsNullOrEmpty(GlobalVar.Oper.DeptCode))
            {
                where = c => c.BillType == (int)_billType;
            }
            else
            {
                where = c => c.BillType == (int)_billType && c.Factory == GlobalVar.Oper.DeptCode;
            }
            Expression<Func<TB_BILL, long>> order = c => c.UID;

            int total;
            grid.MasterDataSource =EniitiesHelper.GetPagedDataDesc(_db,
                select,
                where,
                order,
                pageIndex,
                pageSize,
                out total);
            if (grid.Total != total)
                grid.Total = total;
            if (grid.PageIndex != pageIndex)
                grid.PageIndex = pageIndex;
            if (grid.PageSize != pageSize)
                grid.PageSize = pageSize;
        }

        private int SetDetailDataSource(string billNum)
        {
            int count;
            Expression<Func<TB_OUT, dynamic>> select = c =>
                new
                {
                    物料号 = c.PartCode,
                    批次 = c.Batch,
                    来源库位 = c.FromLocCode,
                    申请数量 = c.BillQty,
                    出库数量 = c.OutQty,
                    单价 = c.UnitPrice,
                    金额 = c.Amount,
                    部门 = c.DeptCode,
                    项目 = c.ProjectCode,
                    产线 = c.WorklineCode,
                    设备 = c.EqptCode,
                    申请人  = c.AskUser,
                    申请时间 = c.AskTime,
                    批准人 = c.ConfirmUser,
                    批准时间 = c.ConfirmTime,
                    状态 = ((BillState)c.State).ToString(),
                    备注 = c.Remark,
                };
            Expression<Func<TB_OUT, bool>> where = c => c.BillNum == billNum;
            Expression<Func<TB_OUT, long>> order = c => c.UID;

            grid.Detail1DataSource = EniitiesHelper.GetData(_db,
                select,
                where,
                order,
                out count);
            return count;

        }


        private void grid_PageSelectedIndexChanged(object sender, EventArgs e)
        {
            SetMasterDataSource(grid.PageIndex, grid.PageSize);
        }

        private void grid_GridCellActivated(object sender, GridCellActivatedEventArgs e)
        {
            //            MessageBox.Show(e.GridCell.GridRow.DataItem.ToString());
            _bill = BillController.GetVWBill(_db, grid.MasterUid);
            if (_bill == null) return;
            var count = SetDetailDataSource(_bill.单据编号);
            grid.IsDetailVisible = count > 0;
        }

        
        private void grid_DataRefreshed(object sender, CktMasterDetailGrid.QtyEventArgs e)
        {
            SetMasterDataSource(e.PageIndex,e.PageSize);
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                BillHandler.CancelMaterialAsk(_db, _bill.VWToBill(GlobalVar.Oper.DeptCode));
                NotifyController.AddNotify(_db, _bill.操作者, NotifyType.MaterialOutCancel, _bill.单据编号, "");
                EntitiesFactory.SaveDb(_db);
                SetMasterDataSource(grid.PageIndex, grid.PageSize);
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex.ToString());

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PopupMaterialOut popup = new PopupMaterialOut();
            popup.ShowDialog(this);
            SetMasterDataSource(1, grid.PageSize);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            PopupMaterialOut popup = new PopupMaterialOut(_bill);
            popup.ShowDialog(this);
            SetMasterDataSource(grid.PageIndex, grid.PageSize);
        }

        private void ItemBtnPrint_Click(object sender, EventArgs e)
        {
            if (_bill == null || _bill.单据编号 == null)
            {
                MessageHelper.ShowInfo("请选择单据！");
                return;
            }
            ReportHelper.Print(_report);
        }

        private void ItemBtnImport_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeliver_Click(object sender, EventArgs e)
        {
            if (_bill == null || _bill.单据编号 == null)
            {
                MessageHelper.ShowInfo("请选择单据");
                return;
            }
            if (MessageHelper.ShowQuestion("确定要执行选定的领用单？") == DialogResult.Yes)
            {
                SpareEntities db = EntitiesFactory.CreateSpareInstance();
                var outlist = SpareOutController.GetList(db, _bill.单据编号);
                foreach (var spout in outlist)
                {
                    if (string.IsNullOrEmpty(spout.TakeUser))
                    {
                        MessageHelper.ShowError("领用详细中的领用人信息不能为空！");
                        return;
                    }
                }
                BillHandler.FinishMaterialOut(db, _bill.VWToBill(GlobalVar.Oper.DeptCode), outlist);
                EntitiesFactory.SaveDb(db);
                NotifyController.AddStockSafeQty(db, GlobalVar.Oper.OperName);
                MessageHelper.ShowInfo("保存成功！");
            }
        }

        private void ItemBtnReturn_Click(object sender, EventArgs e)
        {
            if (_bill == null || _bill.单据编号 == null)
            {
                MessageHelper.ShowInfo("请选择单据");
                return;
            }

            if (_bill.状态 != (int)BillState.Finished)
            {
                MessageHelper.ShowInfo("选中单据状态错误，无法执行");
                return;
            }
            var details = SpareOutController.GetList(_db, _bill.单据编号);
            try
            {
                string strInfo = BillHandler.HandleMaterialReturn(_db, _bill.VWToBill(GlobalVar.Oper.DeptCode), details);
                if (strInfo != "OK")
                {
                    MessageHelper.ShowError(strInfo);
                }
                else
                {
                    MessageHelper.ShowInfo("生成领用还回单成功");
                    EntitiesFactory.SaveDb(_db);
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex.ToString());
                throw;
            }
        }
    }
}
