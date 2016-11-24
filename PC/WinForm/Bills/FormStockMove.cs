using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using ChangKeTec.Wms.Common;
using ChangKeTec.Wms.Common.UC;
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
    public partial class FormStockMove: Office2007Form
    {
        private BillType _billType = BillType.StockMove;
        private GridppReport _report;
        private TB_BILL _bill = null;
        private readonly string DetailTableName = "TB_STOCK_MOVE";
        private readonly string IndexColumnName = "BillNum";
        private SpareEntities _db = EntitiesFactory.CreateWmsInstance();
        public FormStockMove()
        {
            InitializeComponent();
            _report = ReportHelper.InitReport(_billType);
            _report.Initialize += () => ReportHelper._report_Initialize(_report, _bill, DetailTableName, IndexColumnName);
        }



        private void FormWhseReceive_Load(object sender, EventArgs e)
        {
            SetMasterDataSource(grid.PageSize);

        }



        private void btnFilter_Click(object sender, EventArgs e)
        {

        }
        
        private void BtnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = DataGridViewHelper.DgvToTable(grid.MasterPrimaryGrid, EnumHelper.GetDescription(_billType));
            ExcelWriter.Write(dt);
        }



        private void BtnDeliver_Click(object sender, EventArgs e)
        {
        
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
            Expression<Func<TB_STOCK_MOVE, dynamic>> select = c => c;
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

        private void ItemBtnPrint_Click(object sender, EventArgs e)
        {
            if (_bill == null || _bill.BillNum == null)
            {
                MessageHelper.ShowInfo("请选择单据！");
                return;
            }
            ReportHelper.Print(_report);
        }
    }
}
