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
    public partial class FormOtherOut : Office2007Form
    {
        private BillType _billType = BillType.OtherInOut;
        private readonly SubBillType _subBillType = SubBillType.OtherOut;
        private GridppReport _report;
        private TB_BILL _bill = null;
        private readonly string DetailTableName = "FormOtherOut";
        private readonly string IndexColumnName = "BillNum";
        private SpareEntities _db = EntitiesFactory.CreateSpareInstance();
        private Expression<Func<TB_BILL, bool>> _where;

        public FormOtherOut()
        {
            InitializeComponent();
            _where = c => c.BillType == (int) _billType && c.SubBillType == (int)_subBillType;
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
            Expression<Func<TB_OTHER_OUT, dynamic>> select = c =>
                new
                {
                    物料号 = c.PartCode,
                    批次 = c.Batch,
                    目标库位 = c.FromLocCode,
                    入库数量 = c.Qty,
                    单价 = c.UnitPrice,
                    金额 = c.Amount, 
                    备注 = c.Remark,
                };
            Expression<Func<TB_OTHER_OUT, bool>> where = c => c.BillNum == billNum;
            Expression<Func<TB_OTHER_OUT, long>> order = c => c.UID;

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
            PopupOtherOut popup = new PopupOtherOut(_bill);
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
                BillHandler.ExecuteSpareReturn(db, _bill, (List<TB_RETURN>)(grid.Detail1DataSource));
                EntitiesFactory.SaveDb(db);
                MessageHelper.ShowInfo("保存成功！");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (_bill == null || _bill.BillNum == null)
                {
                    MessageHelper.ShowInfo("请选择单据！");
                    return;
                }
                BillController.UpdateState(_db, _bill, BillState.Cancelled);
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
            PopupOtherOut popup = new PopupOtherOut();
            popup.ShowDialog(this);
            SetMasterDataSource(grid.PageIndex, grid.PageSize);
        }
    }
}
