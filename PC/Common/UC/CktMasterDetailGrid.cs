using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChangKeTec.Wms.Models;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.Common.UC
{
    public partial class CktMasterDetailGrid : UserControl
    {
        private int _total;

        public int Total
        {
            get { return _total; }
            set
            {
                _total = value;
                lblTotalCount.Text = $"共{value}行";
                SetPageCount(value);
            }
        }

        private void SetPageCount(int total)
        {
            if (_total == 0) return;
            PageCount = (int) Math.Ceiling((decimal) total/_pageSize);
            cbPageIndex.Items.Clear();
            for (int i = 1; i <= PageCount; i++)
            {
                cbPageIndex.Items.Add(i);
            }
            lblPage.Text = $"/{PageCount}页";
            PageIndex = 1;
//            if (cbPage.SelectedIndex < 0)
//                cbPage.SelectedIndex = 0;
        }

        private int _pageSize;

        public int PageSize
        {
            get { return _pageSize; }
            set
            {
                if (cbPageSize.SelectedItem == null) return;
                if (_pageSize == Convert.ToInt32(cbPageSize.SelectedItem)) return;
                _pageSize = value;
                cbPageSize.SelectedItem = _pageSize;
                SetPageCount(_total);
            }
        }

        private int _pageIndex=1;
        private int _pageCount;
        private int _masterUid;

        public int PageIndex
        {
            get { return _pageIndex; }
            set
            {
                if (cbPageIndex.SelectedItem == null) return;
                if (_pageIndex == Convert.ToInt32(cbPageIndex.SelectedItem))return;
                _pageIndex = value;
                cbPageIndex.SelectedItem = _pageIndex;
            }
        }

        public int MasterUid
        {
            get { return _masterUid; }
            private set { _masterUid = value; }
        }

        public int PageCount
        {
            get { return _pageCount; }
            private set { _pageCount = value; }
        }

        public object MasterDataSource
        {
            get { return bsMaster.DataSource; }
            set
            {
                if (value == null) GridMaster.Visible = false;
                else
                {
                    GridMaster.Visible = true;
                    bsMaster.DataSource = value;
                }

            }
        }

        public object Detail1DataSource
        {
            get { return bsDetail.DataSource; }
            set { bsDetail.DataSource = value; }
        }

        public bool IsMasterReadOnly
        {

            set
            {
                GridMaster.PrimaryGrid.ReadOnly = value;
                btnAdd.Enabled = !value;
                btnDelete.Enabled = !value;
            }
        }

        public bool IsNavigatorVisible
        {
            get { return bnMaster.Visible; }
            set { bnMaster.Visible = value; }
        }

        public bool IsPropertyExpand
        {
            get { return epProperty.Expanded; }
            set { epProperty.Expanded = value; }
        }

        public bool IsPropertyVisible
        {
            get { return epProperty.Visible; }
            set { epProperty.Visible = value; }
        }

        public bool IsDetailVisible
        {
            set
            {
                esp.Visible = value;
                epDetail.Visible = value;
//                epDetail.SendToBack();
            }
        }


        public GridPanel MasterPrimaryGrid => GridMaster.PrimaryGrid;

        public DockStyle PropertyPanelDock
        {
            get { return epProperty.Dock; }
            set { epProperty.Dock = value; }
        }

        public DockStyle DetailPanelDock
        {
            get { return epDetail.Dock; }
            set { epDetail.Dock = value; }
        }

        public CktMasterDetailGrid()
        {
            InitializeComponent();
            GridMaster.PrimaryGrid.DataSource = bsMaster;
            GridDetail.PrimaryGrid.DataSource = bsDetail;
            GridDetail.PrimaryGrid.ReadOnly = true;
            bnMaster.BindingSource = bsMaster;
            IsPropertyVisible = true;
            IsDetailVisible = false;
            _pageSize = 100;
            PageIndex = 1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData(this,new QtyEventArgs(_pageIndex,_pageSize));
        }

        public delegate void PageSelectedIndexHandler(object sender, EventArgs e);

        public event PageSelectedIndexHandler PageSelectedIndexChanged;

        private void cbPageIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            var page = Convert.ToInt32(cbPageIndex.SelectedItem);
//            if (page == 0) return;
            if (_pageIndex == page) return;
            _pageIndex = page;
            try
            {
                PageSelectedIndexChanged?.Invoke(sender, e);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public delegate void CellActivatedHandler(object sender, GridCellActivatedEventArgs e);

        public event CellActivatedHandler MasterGridCellActivated;

        private void GridMaster_CellActivated(object sender, GridCellActivatedEventArgs e)
        {
            if (e.NewActiveCell.RowIndex < 0 || e.NewActiveCell.ColumnIndex < 0) return;

            _masterUid = Convert.ToInt32(e.NewActiveCell.GridRow.Cells["UID"].Value);
            esp.BringToFront();
            if (epProperty.Visible) pg.SelectedObject = e.NewActiveCell.GridRow.DataItem;
           
            try
            {
                MasterGridCellActivated?.Invoke(sender, e);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void cbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pageIndex = Convert.ToInt32(cbPageIndex.SelectedItem);
            var pageSize = Convert.ToInt32(cbPageSize.SelectedItem);
//            if (_pageSize == pageSize) return;
//            _pageSize = pageSize;
            RefreshData(this,new QtyEventArgs(pageIndex,pageSize));
        }

        public delegate void DataRefreshHandler(object sender, QtyEventArgs e);

        public event DataRefreshHandler DataRefreshed;

        private void RefreshData(object sender, QtyEventArgs e)
        {
//            _pageIndex = 1;
//            cbPage.Text = _currentPage.ToString();
            try
            {
                DataRefreshed?.Invoke(sender, e);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public class QtyEventArgs : EventArgs
        {
            public QtyEventArgs(int pageIndex,int pageSize)
            {
                PageIndex = pageIndex;
                PageSize = pageSize;
            }

            public int PageIndex { get; set; }
            public int PageSize { get; set; }

        }

        private void btnPrePage_Click(object sender, EventArgs e)
        {
            if (_pageIndex == 1) return;
            _pageIndex--;
            btnNextPage.Enabled = true;
            if (_pageIndex == 1)
            {
                btnPrePage.Enabled = false;
            }

            cbPageIndex.Text = _pageIndex.ToString();
            RefreshData(this,new QtyEventArgs(_pageIndex,_pageSize));
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {

            if (_pageIndex == _pageCount) return;
            _pageIndex++;
            btnPrePage.Enabled = true;
            if (_pageIndex == _pageCount)
            {
                btnNextPage.Enabled = false;
            }
            cbPageIndex.Text = _pageIndex.ToString();
            RefreshData(this, new QtyEventArgs(_pageIndex,_pageSize));
        }

        public delegate void CellDoubleClickHandler(object sender, GridCellDoubleClickEventArgs e);

        public event CellDoubleClickHandler MasterGridCellDoubleClick;

        private void GridMaster_CellDoubleClick(object sender, GridCellDoubleClickEventArgs e)
        {
            try
            {
                MasterGridCellDoubleClick?.Invoke(sender, e);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        /*
                        public delegate void CellClickHandler(object sender, GridCellClickEventArgs e);

                        public event CellClickHandler GridCellClick;

                        private void GridMaster_CellClick(object sender, GridCellClickEventArgs e)
                        {
                            if (e.GridCell.RowIndex < 0 || e.GridCell.ColumnIndex < 0) return;

                            MasterUid = Convert.ToInt32(e.GridCell.GridRow.Cells["UID"].Value);

                            if (epProperty.Visible) pg.SelectedObject = e.GridCell.GridRow.DataItem;
                            try
                            {
                                GridCellClick?.Invoke(sender, e);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.ToString());
                            }
                        }
                */
    }
}
