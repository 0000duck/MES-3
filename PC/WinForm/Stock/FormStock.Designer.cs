namespace ChangKeTec.Wms.WinForm.Stock
{
    partial class FormStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnSell = new DevComponents.DotNetBar.ButtonItem();
            this.ItemBtnExport = new DevComponents.DotNetBar.ButtonItem();
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.gridStock = new ChangKeTec.Wms.Common.UC.CktMasterDetailGrid();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.gridStockDetail = new ChangKeTec.Wms.Common.UC.CktMasterDetailGrid();
            this.stockDetail = new DevComponents.DotNetBar.SuperTabItem();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSell,
            this.ItemBtnExport});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(1189, 30);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnSell
            // 
            this.btnSell.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSell.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_253;
            this.btnSell.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnSell.Name = "btnSell";
            this.btnSell.Text = "销售选中明细";
            this.btnSell.Visible = false;
            // 
            // ItemBtnExport
            // 
            this.ItemBtnExport.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ItemBtnExport.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_180;
            this.ItemBtnExport.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.ItemBtnExport.Name = "ItemBtnExport";
            this.ItemBtnExport.Text = "导出";
            this.ItemBtnExport.Click += new System.EventHandler(this.ItemBtnExport_Click);
            // 
            // superTabControl1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Controls.Add(this.superTabControlPanel2);
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControl1.Location = new System.Drawing.Point(0, 30);
            this.superTabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 1;
            this.superTabControl1.Size = new System.Drawing.Size(1189, 671);
            this.superTabControl1.TabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.superTabControl1.TabIndex = 1;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1,
            this.stockDetail});
            this.superTabControl1.Text = "superTabControl1";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.gridStock);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 31);
            this.superTabControlPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(1189, 640);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // gridStock
            // 
            this.gridStock.Detail1DataSource = null;
            this.gridStock.DetailPanelDock = System.Windows.Forms.DockStyle.Right;
            this.gridStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridStock.IsNavigatorVisible = false;
            this.gridStock.IsPropertyExpand = false;
            this.gridStock.IsPropertyVisible = false;
            this.gridStock.Location = new System.Drawing.Point(0, 0);
            this.gridStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridStock.MasterDataSource = null;
            this.gridStock.Name = "gridStock";
            this.gridStock.PageIndex = 1;
            this.gridStock.PageSize = 100;
            this.gridStock.PropertyPanelDock = System.Windows.Forms.DockStyle.Left;
            this.gridStock.Size = new System.Drawing.Size(1189, 640);
            this.gridStock.TabIndex = 0;
            this.gridStock.Total = 0;
            this.gridStock.PageSelectedIndexChanged += new ChangKeTec.Wms.Common.UC.CktMasterDetailGrid.PageSelectedIndexHandler(this.gridStock_PageSelectedIndexChanged);
            this.gridStock.DataRefreshed += new ChangKeTec.Wms.Common.UC.CktMasterDetailGrid.DataRefreshHandler(this.gridStock_DataRefreshed);
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "库存统计";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.gridStockDetail);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 31);
            this.superTabControlPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(1189, 640);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.stockDetail;
            // 
            // gridStockDetail
            // 
            this.gridStockDetail.Detail1DataSource = null;
            this.gridStockDetail.DetailPanelDock = System.Windows.Forms.DockStyle.Right;
            this.gridStockDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridStockDetail.IsNavigatorVisible = true;
            this.gridStockDetail.IsPropertyExpand = false;
            this.gridStockDetail.IsPropertyVisible = true;
            this.gridStockDetail.Location = new System.Drawing.Point(0, 0);
            this.gridStockDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridStockDetail.MasterDataSource = null;
            this.gridStockDetail.Name = "gridStockDetail";
            this.gridStockDetail.PageIndex = 1;
            this.gridStockDetail.PageSize = 100;
            this.gridStockDetail.PropertyPanelDock = System.Windows.Forms.DockStyle.Left;
            this.gridStockDetail.Size = new System.Drawing.Size(1189, 640);
            this.gridStockDetail.TabIndex = 0;
            this.gridStockDetail.Total = 0;
            this.gridStockDetail.PageSelectedIndexChanged += new ChangKeTec.Wms.Common.UC.CktMasterDetailGrid.PageSelectedIndexHandler(this.gridStockDetail_PageSelectedIndexChanged);
            this.gridStockDetail.MasterGridCellActivated += new ChangKeTec.Wms.Common.UC.CktMasterDetailGrid.CellActivatedHandler(this.gridStockDetail_MasterGridCellActivated);
            this.gridStockDetail.DataRefreshed += new ChangKeTec.Wms.Common.UC.CktMasterDetailGrid.DataRefreshHandler(this.gridStockDetail_DataRefreshed);
            // 
            // stockDetail
            // 
            this.stockDetail.AttachedControl = this.superTabControlPanel2;
            this.stockDetail.GlobalItem = false;
            this.stockDetail.Name = "stockDetail";
            this.stockDetail.Text = "库存明细";
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 701);
            this.ControlBox = false;
            this.Controls.Add(this.superTabControl1);
            this.Controls.Add(this.bar1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormStock";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FormLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem ItemBtnExport;
        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem stockDetail;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.ButtonItem btnSell;
        private Common.UC.CktMasterDetailGrid gridStock;
        private Common.UC.CktMasterDetailGrid gridStockDetail;
    }
}