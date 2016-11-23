namespace ChangKeTec.Wms.WinForm.PopUp
{
    partial class PopupInventoryLoc
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
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.btnCancel = new DevComponents.DotNetBar.ButtonItem();
            this.ItemBtnExport = new DevComponents.DotNetBar.ButtonItem();
            this.ItemBtnPrint = new DevComponents.DotNetBar.ButtonItem();
            this.BtnSave = new DevComponents.DotNetBar.ButtonItem();
            this.grid = new ChangKeTec.Wms.Common.UC.CktMasterDetailGrid();
            this.propertyBill = new DevComponents.DotNetBar.AdvPropertyGrid();
            this.expandableSplitter2 = new DevComponents.DotNetBar.ExpandableSplitter();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBill)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnClose,
            this.btnCancel,
            this.ItemBtnExport,
            this.ItemBtnPrint,
            this.BtnSave});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(892, 29);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnClose
            // 
            this.btnClose.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnClose.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_230;
            this.btnClose.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnCancel.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_066;
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.ItemBtnPrint.Text = "打印盘点明细";
            this.ItemBtnPrint.Click += new System.EventHandler(this.ItemBtnPrint_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnSave.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_001;
            this.BtnSave.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Text = "生成盘点接口数据";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // grid
            // 
            this.grid.Detail1DataSource = null;
            this.grid.DetailPanelDock = System.Windows.Forms.DockStyle.Right;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.IsNavigatorVisible = false;
            this.grid.IsPropertyExpand = false;
            this.grid.IsPropertyVisible = false;
            this.grid.Location = new System.Drawing.Point(235, 29);
            this.grid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grid.MasterDataSource = null;
            this.grid.Name = "grid";
            this.grid.PageIndex = 1;
            this.grid.PageSize = 100;
            this.grid.PropertyPanelDock = System.Windows.Forms.DockStyle.Left;
            this.grid.Size = new System.Drawing.Size(657, 532);
            this.grid.TabIndex = 9;
            this.grid.Total = 0;
            this.grid.MasterGridCellActivated += new ChangKeTec.Wms.Common.UC.CktMasterDetailGrid.CellActivatedHandler(this.grid_GridCellActivated);
            this.grid.DataRefreshed += new ChangKeTec.Wms.Common.UC.CktMasterDetailGrid.DataRefreshHandler(this.grid_DataRefreshed);
            // 
            // propertyBill
            // 
            this.propertyBill.Dock = System.Windows.Forms.DockStyle.Left;
            this.propertyBill.GridLinesColor = System.Drawing.Color.WhiteSmoke;
            this.propertyBill.Location = new System.Drawing.Point(0, 29);
            this.propertyBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.propertyBill.Name = "propertyBill";
            this.propertyBill.Size = new System.Drawing.Size(231, 532);
            this.propertyBill.TabIndex = 10;
            this.propertyBill.Text = "advPropertyGrid1";
            this.propertyBill.PropertyValueChanging += new DevComponents.DotNetBar.PropertyValueChangingEventHandler(this.propertyBill_PropertyValueChanging);
            // 
            // expandableSplitter2
            // 
            this.expandableSplitter2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter2.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter2.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter2.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.expandableSplitter2.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.expandableSplitter2.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.expandableSplitter2.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter2.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(200)))), ((int)(((byte)(103)))));
            this.expandableSplitter2.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(135)))));
            this.expandableSplitter2.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter2.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter2.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter2.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.expandableSplitter2.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter2.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.expandableSplitter2.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter2.Location = new System.Drawing.Point(231, 29);
            this.expandableSplitter2.Margin = new System.Windows.Forms.Padding(2);
            this.expandableSplitter2.Name = "expandableSplitter2";
            this.expandableSplitter2.Size = new System.Drawing.Size(4, 532);
            this.expandableSplitter2.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter2.TabIndex = 59;
            this.expandableSplitter2.TabStop = false;
            // 
            // PopupInventoryLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 561);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.expandableSplitter2);
            this.Controls.Add(this.propertyBill);
            this.Controls.Add(this.bar1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PopupInventoryLoc";
            this.ShowIcon = false;
            this.Text = "库位盘点明细";
            this.Load += new System.EventHandler(this.FormWhseReceive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem BtnSave;
        private DevComponents.DotNetBar.ButtonItem ItemBtnExport;
        private Common.UC.CktMasterDetailGrid grid;
        private DevComponents.DotNetBar.ButtonItem ItemBtnPrint;
        private DevComponents.DotNetBar.AdvPropertyGrid propertyBill;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private DevComponents.DotNetBar.ButtonItem btnCancel;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter2;
    }
}