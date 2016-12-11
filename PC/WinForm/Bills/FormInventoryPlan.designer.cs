namespace ChangKeTec.Wms.WinForm.Bills
{
    partial class FormInventoryPlan
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
            this.BtnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnInventoryLoc = new DevComponents.DotNetBar.ButtonItem();
            this.btnInventoryResult = new DevComponents.DotNetBar.ButtonItem();
            this.btnCancel = new DevComponents.DotNetBar.ButtonItem();
            this.btnAdjust = new DevComponents.DotNetBar.ButtonItem();
            this.ItemBtnExport = new DevComponents.DotNetBar.ButtonItem();
            this.ItemBtnPrint = new DevComponents.DotNetBar.ButtonItem();
            this.grid = new ChangKeTec.Wms.Common.UC.CktMasterDetailGrid();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BtnAdd,
            this.btnInventoryLoc,
            this.btnInventoryResult,
            this.btnCancel,
            this.btnAdjust,
            this.ItemBtnExport,
            this.ItemBtnPrint});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Margin = new System.Windows.Forms.Padding(2);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(725, 29);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // BtnAdd
            // 
            this.BtnAdd.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnAdd.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_194;
            this.BtnAdd.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Text = "新增";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnInventoryLoc
            // 
            this.btnInventoryLoc.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnInventoryLoc.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_002;
            this.btnInventoryLoc.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnInventoryLoc.Name = "btnInventoryLoc";
            this.btnInventoryLoc.Text = "维护盘点库位";
            this.btnInventoryLoc.Click += new System.EventHandler(this.btnInventoryLoc_Click);
            // 
            // btnInventoryResult
            // 
            this.btnInventoryResult.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnInventoryResult.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_053;
            this.btnInventoryResult.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnInventoryResult.Name = "btnInventoryResult";
            this.btnInventoryResult.Text = "维护盘点结果";
            this.btnInventoryResult.Click += new System.EventHandler(this.btnInventoryResult_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnCancel.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_066;
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Text = "取消计划";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdjust
            // 
            this.btnAdjust.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnAdjust.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_064;
            this.btnAdjust.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnAdjust.Name = "btnAdjust";
            this.btnAdjust.Text = "库存调整";
            this.btnAdjust.Click += new System.EventHandler(this.btnAdjust_Click);
            // 
            // ItemBtnExport
            // 
            this.ItemBtnExport.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ItemBtnExport.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_180;
            this.ItemBtnExport.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.ItemBtnExport.Name = "ItemBtnExport";
            this.ItemBtnExport.Text = "导出";
            this.ItemBtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // ItemBtnPrint
            // 
            this.ItemBtnPrint.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ItemBtnPrint.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_211;
            this.ItemBtnPrint.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.ItemBtnPrint.Name = "ItemBtnPrint";
            this.ItemBtnPrint.Text = "打印";
            this.ItemBtnPrint.Click += new System.EventHandler(this.ItemBtnPrint_Click);
            // 
            // grid
            // 
            this.grid.Detail1DataSource = null;
            this.grid.DetailPanelDock = System.Windows.Forms.DockStyle.Right;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.IsNavigatorVisible = true;
            this.grid.IsPropertyExpand = false;
            this.grid.IsPropertyVisible = true;
            this.grid.Location = new System.Drawing.Point(0, 29);
            this.grid.Margin = new System.Windows.Forms.Padding(2);
            this.grid.MasterDataSource = null;
            this.grid.Name = "grid";
            this.grid.PageIndex = 1;
            this.grid.PageSize = 100;
            this.grid.PropertyPanelDock = System.Windows.Forms.DockStyle.Left;
            this.grid.Size = new System.Drawing.Size(725, 430);
            this.grid.TabIndex = 9;
            this.grid.Total = 0;
            this.grid.PageSelectedIndexChanged += new ChangKeTec.Wms.Common.UC.CktMasterDetailGrid.PageSelectedIndexHandler(this.grid_PageSelectedIndexChanged);
            this.grid.MasterGridCellActivated += new ChangKeTec.Wms.Common.UC.CktMasterDetailGrid.CellActivatedHandler(this.grid_GridCellActivated);
            this.grid.DataRefreshed += new ChangKeTec.Wms.Common.UC.CktMasterDetailGrid.DataRefreshHandler(this.grid_DataRefreshed);
            // 
            // FormInventoryPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 459);
            this.ControlBox = false;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.bar1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormInventoryPlan";
            this.ShowIcon = false;
            this.Text = "盘点计划单";
            this.Load += new System.EventHandler(this.FormWhseReceive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem BtnAdd;
        private DevComponents.DotNetBar.ButtonItem ItemBtnExport;
        private Common.UC.CktMasterDetailGrid grid;
        private DevComponents.DotNetBar.ButtonItem ItemBtnPrint;
        private DevComponents.DotNetBar.ButtonItem btnInventoryLoc;
        private DevComponents.DotNetBar.ButtonItem btnInventoryResult;
        private DevComponents.DotNetBar.ButtonItem btnCancel;
        private DevComponents.DotNetBar.ButtonItem btnAdjust;
    }
}