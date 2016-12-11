using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using ChangKeTec.Wms.Common;
using ChangKeTec.Wms.Common.UC;
using ChangKeTec.Wms.Controllers;
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
    public partial class FormReturn: Office2007Form
    {
        private BillType _billType = BillType.SpareReturn;
        private readonly SubBillType _subBillType;
        private GridppReport _report;
        private TB_BILL _bill = null;
        private readonly string DetailTableName = "TB_RETURN";
        private readonly string IndexColumnName = "BillNum";
        private SpareEntities _db = EntitiesFactory.CreateSpareInstance();
        private Expression<Func<TB_BILL, bool>> _where;

        public FormReturn()
        {
            InitializeComponent();
            _where = c => c.BillType == (int) _billType;
//            _report = ReportHelper.InitReport(_billType);
//            _report.Initialize += () => ReportHelper._report_Initialize(_report, _bill, DetailTableName, IndexColumnName);
        }

        private void FormWhseReceive_Load(object sender, EventArgs e)
        {
            SetMasterDataSource(grid.PageIndex,grid.PageSize);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }
        
        private void BtnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = DataGridViewHelper.DgvToTable(grid.MasterPrimaryGrid, EnumHelper.GetDescription(_billType));
            ExcelWriter.Write(dt);
        }

        private void SetMasterDataSource(int pageIndex, int pageSize)
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
                        供应商编号 = c.SplyId,
                        单据时间 = c.BillTime,
                        操作员 = c.OperName,
                        状态 = ((BillState)c.State).ToString(),
                        备注 = c.Remark,
                    };
            Expression<Func<TB_BILL, long>> order = c => c.UID;

            int total;
            grid.MasterDataSource =EniitiesHelper.GetPagedDataDesc(_db,
                select,
                _where,
                order,
                grid.PageIndex, 
                grid.PageSize,
                out total);
            if (grid.Total != total) grid.Total = total;
            if (grid.PageIndex != pageIndex)
                grid.PageIndex = pageIndex;
            if (grid.PageSize != pageSize)
                grid.PageSize = pageSize;
        }

        private int SetDetailDataSource(string billNum)
        {
            int count;
            Expression<Func<TB_RETURN, dynamic>> select = c =>
                new
                {
                    物料号 = c.PartCode,
                    批次 = c.Batch,
                    目标库位 = c.ToLocCode,
                    出库数量 = c.OutQty,
                    入库数量 = c.InQty,
                    单价 = c.UnitPrice,
                    金额 = c.Amount,
                    部门 = c.DeptCode,
                    项目 = c.ProjectCode,
                    产线 = c.WorklineCode,
                    设备 = c.EqptCode,
                    申请人 = c.AskUser,
                    申请时间 = c.AskTime,
                    批准人 = c.ConfirmUser,
                    批准时间 = c.ConfirmTime,
                    领取人 = c.TakeUser,
                    领取时间 = c.TakeTime,
                    归还人 = c.ReturnUser,
                    归还时间 = c.ReturnTime,
                    状态 = ((BillState)c.State).ToString(),
                    备注 = c.Remark,
                };
            Expression<Func<TB_RETURN, bool>> where = c => c.BillNum == billNum;
            Expression<Func<TB_RETURN, long>> order = c => c.UID;

            grid.Detail1DataSource = EniitiesHelper.GetData(_db,
                select,
                where,
                order,
                out count);
            return count;
        }

        private void grid_PageSelectedIndexChanged(object sender, EventArgs e)
        {
            SetMasterDataSource(grid.PageIndex,grid.PageSize);
        }

        private void grid_GridCellActivated(object sender, GridCellActivatedEventArgs e)
        {
            //            MessageBox.Show(e.GridCell.GridRow.DataItem.ToString());
            SpareEntities db = EntitiesFactory.CreateSpareInstance();
            _bill = db.TB_BILL.SingleOrDefault(p => p.UID == grid.MasterUid);
            if (_bill == null) return;
            var billNum = _bill.BillNum;
            var count = SetDetailDataSource(billNum);
            grid.IsDetailVisible = count > 0;
        }
        
        private void grid_DataRefreshed(object sender, CktMasterDetailGrid.QtyEventArgs e)
        {
            SetMasterDataSource(e.PageIndex,e.PageSize);    
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

        private void btnModify_Click(object sender, EventArgs e)
        {
            PopupSpareReturn popup = new PopupSpareReturn(_bill);
            popup.ShowDialog(this);
            SetMasterDataSource(grid.PageIndex, grid.PageSize);
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (_bill == null || _bill.BillNum == null)
            {
                MessageHelper.ShowInfo("请选择单据！");
                return;
            }
            if (MessageHelper.ShowQuestion("确定要执行选定的领用还回单？") == DialogResult.Yes)
            {
                SpareEntities db = EntitiesFactory.CreateSpareInstance();
                var returnlist = db.TB_RETURN.Where(p => p.BillNum == _bill.BillNum).ToList();
                BillHandler.ExecuteSpareReturn(db, _bill, returnlist);
                EntitiesFactory.SaveDb(db);
                MessageHelper.ShowInfo("保存成功！");
            }
        }
    }
}
