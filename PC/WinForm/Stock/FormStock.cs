using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using ChangKeTec.Wms.Common;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using ChangKeTec.Wms.WinForm.PopUp;
using ChangKeTec.Wms.WinForm.Util;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.WinForm.Stock
{
    public partial class FormStock : Office2007Form
    {
        private readonly string _storeArea;
        private SpareEntities _db = EntitiesFactory.CreateWmsInstance();
        public FormStock()
        {
            InitializeComponent();
            Init();
            _storeArea = null;
            btnSell.Visible = false;
            gridStockDetail.MasterPrimaryGrid.CheckBoxes = true;

        }
        public FormStock(string storeArea)
        {
            InitializeComponent();
            Init();
            _storeArea = storeArea;
            btnSell.Visible = storeArea == StoreArea.SALE.ToString();

        }
        private void Init()
        {
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            GetStockList();
            superTabControl1.SelectedTab = superTabItem1;
        }

        private void GetStockList()
        {
            try
            {
                SetStockMasterDataSource(gridStock.PageSize);
                SetStockDetailMasterDataSource(gridStockDetail.PageSize);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void SetStockMasterDataSource(int pageSize)
        {
            Expression<Func<VIEW_STOCK, dynamic>> select = c => c;


            Expression<Func<VIEW_STOCK, bool>> where;
            if (_storeArea == null)
                where = c => true;
            else
            {
                var locs = GlobalBuffer.LocList.Where(p => p.AreaCode == _storeArea).Select(p=>p.LocCode);
                where = c => locs.Contains(c.库位);
            }
            Expression<Func<VIEW_STOCK, long>> order = c => c.UID;
            var grid = gridStock;
            int total;
            grid.MasterDataSource = EniitiesHelper.GetPagedDataAsc(_db,
                select,
                where,
                order,
                grid.PageIndex, grid.PageSize, out total);
            if (grid.Total != total) grid.Total = total;
            if (grid.PageSize != pageSize)
                grid.PageSize = pageSize;
        }


        private void SetStockDetailMasterDataSource(int pageSize)
        {
            Expression<Func<VIEW_STOCK_DETAIL, dynamic>> select = c => c;
            Expression<Func<VIEW_STOCK_DETAIL, bool>> where;
            if (_storeArea == null)
                where = c => true;
            else
            {
                var locs = GlobalBuffer.LocList.Where(p => p.AreaCode == _storeArea).Select(p => p.LocCode);
                where = c => locs.Contains(c.库位);
            }
            Expression<Func<VIEW_STOCK_DETAIL, long>> order = c => c.UID;
            var grid = gridStockDetail;
            int total;
            grid.MasterDataSource = EniitiesHelper.GetPagedDataAsc(_db,
                select,
                where,
                order,
                grid.PageIndex, grid.PageSize, out total);
            if (grid.Total != total) grid.Total = total;
            if (grid.PageSize != pageSize)
                grid.PageSize = pageSize;
        }


        private void ItemBtnExport_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = DataGridViewHelper.DgvToTable(gridStockDetail.MasterPrimaryGrid, "StockDetail");
            ds.Tables.Add(dt);
            dt = DataGridViewHelper.DgvToTable(gridStock.MasterPrimaryGrid, "ReportOf" + "Stock");
            ds.Tables.Add(dt);
            ExcelWriter.Write(ds);
        }




        private void gridStock_DataRefreshed(object sender, Common.UC.CktMasterDetailGrid.QtyEventArgs e)
        {
            SetStockMasterDataSource(e.PageSize);

        }

        private void gridStock_PageSelectedIndexChanged(object sender, EventArgs e)
        {
            SetStockMasterDataSource(gridStock.PageSize);

        }

        private void gridStockDetail_DataRefreshed(object sender, Common.UC.CktMasterDetailGrid.QtyEventArgs e)
        {
            SetStockDetailMasterDataSource(e.PageSize);
        }

        private void gridStockDetail_MasterGridCellActivated(object sender, DevComponents.DotNetBar.SuperGrid.GridCellActivatedEventArgs e)
        {
            SpareEntities db = EntitiesFactory.CreateWmsInstance();
            var vinCode = db.TS_STOCK_DETAIL.Single(p => p.UID == gridStockDetail.MasterUid).Batch;
//            var count = SetVinPartMasterDataSource(vinCode);
//            gridStockDetail.IsDetailVisible = count > 0;
            
        }

        private void gridStockDetail_PageSelectedIndexChanged(object sender, EventArgs e)
        {
            SetStockDetailMasterDataSource(gridStockDetail.PageSize);
        }
    }
}
