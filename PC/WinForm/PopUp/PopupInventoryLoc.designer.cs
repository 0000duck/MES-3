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
            this.components = new System.ComponentModel.Container();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.btnCancel = new DevComponents.DotNetBar.ButtonItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.ItemBtnExport = new DevComponents.DotNetBar.ButtonItem();
            this.ItemBtnPrint = new DevComponents.DotNetBar.ButtonItem();
            this.BtnCommit = new DevComponents.DotNetBar.ButtonItem();
            this.propertyBill = new DevComponents.DotNetBar.AdvPropertyGrid();
            this.expandableSplitter2 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.gridColumn26 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn13 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.grid = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn5 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
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
            this.btnSave,
            this.ItemBtnExport,
            this.ItemBtnPrint,
            this.BtnCommit});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSave.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_002;
            this.btnSave.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // BtnCommit
            // 
            this.BtnCommit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnCommit.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_001;
            this.BtnCommit.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BtnCommit.Name = "BtnCommit";
            this.BtnCommit.Text = "生成盘点接口数据";
            this.BtnCommit.Visible = false;
            // 
            // propertyBill
            // 
            this.propertyBill.Dock = System.Windows.Forms.DockStyle.Left;
            this.propertyBill.GridLinesColor = System.Drawing.Color.WhiteSmoke;
            this.propertyBill.Location = new System.Drawing.Point(0, 29);
            this.propertyBill.Margin = new System.Windows.Forms.Padding(2);
            this.propertyBill.Name = "propertyBill";
            this.propertyBill.Size = new System.Drawing.Size(231, 532);
            this.propertyBill.TabIndex = 10;
            this.propertyBill.Text = "advPropertyGrid1";
            this.propertyBill.PropertyValueChanging += new DevComponents.DotNetBar.PropertyValueChangingEventHandler(this.propertyBill_PropertyValueChanging);
            // 
            // expandableSplitter2
            // 
            this.expandableSplitter2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter2.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter2.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter2.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter2.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter2.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(61)))));
            this.expandableSplitter2.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94)))));
            this.expandableSplitter2.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter2.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter2.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter2.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter2.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter2.Location = new System.Drawing.Point(231, 29);
            this.expandableSplitter2.Margin = new System.Windows.Forms.Padding(2);
            this.expandableSplitter2.Name = "expandableSplitter2";
            this.expandableSplitter2.Size = new System.Drawing.Size(4, 532);
            this.expandableSplitter2.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter2.TabIndex = 59;
            this.expandableSplitter2.TabStop = false;
            // 
            // gridColumn26
            // 
            this.gridColumn26.DataPropertyName = "Remark";
            this.gridColumn26.FillWeight = 300;
            this.gridColumn26.HeaderText = "备注";
            this.gridColumn26.MinimumWidth = 300;
            this.gridColumn26.Name = "gridColumn26";
            this.gridColumn26.ReadOnly = true;
            this.gridColumn26.Width = 300;
            // 
            // gridColumn13
            // 
            this.gridColumn13.DataPropertyName = "State";
            this.gridColumn13.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridSwitchButtonEditControl);
            this.gridColumn13.HeaderText = "状态";
            this.gridColumn13.Name = "Column6";
            this.gridColumn13.ReadOnly = true;
            this.gridColumn13.Visible = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.DataPropertyName = "GroupCode";
            this.gridColumn2.HeaderText = "库位组";
            this.gridColumn2.MinimumWidth = 200;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.ReadOnly = true;
            this.gridColumn2.Width = 200;
            // 
            // gridColumn1
            // 
            this.gridColumn1.DataPropertyName = "UID";
            this.gridColumn1.HeaderText = "UID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = false;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grid.Location = new System.Drawing.Point(235, 29);
            this.grid.Margin = new System.Windows.Forms.Padding(2);
            this.grid.Name = "grid";
            // 
            // 
            // 
            this.grid.PrimaryGrid.AutoGenerateColumns = false;
            this.grid.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.NotSet;
            this.grid.PrimaryGrid.Columns.Add(this.gridColumn1);
            this.grid.PrimaryGrid.Columns.Add(this.gridColumn3);
            this.grid.PrimaryGrid.Columns.Add(this.gridColumn5);
            this.grid.PrimaryGrid.Columns.Add(this.gridColumn2);
            this.grid.PrimaryGrid.Columns.Add(this.gridColumn13);
            this.grid.PrimaryGrid.Columns.Add(this.gridColumn26);
            // 
            // 
            // 
            this.grid.PrimaryGrid.Filter.Visible = true;
            // 
            // 
            // 
            this.grid.PrimaryGrid.GroupByRow.Visible = true;
            this.grid.PrimaryGrid.NoRowsText = "（无数据）";
            this.grid.PrimaryGrid.ShowRowGridIndex = true;
            this.grid.Size = new System.Drawing.Size(657, 532);
            this.grid.TabIndex = 63;
            this.grid.Text = "superGridControl1";
            // 
            // gridColumn3
            // 
            this.gridColumn3.DataPropertyName = "IsCheck";
            this.gridColumn3.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            this.gridColumn3.HeaderText = "选择";
            this.gridColumn3.MinimumWidth = 100;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Width = 200;
            // 
            // gridColumn5
            // 
            this.gridColumn5.DataPropertyName = "LocCode";
            this.gridColumn5.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridComboBoxExEditControl);
            this.gridColumn5.HeaderText = "库位";
            this.gridColumn5.MinimumWidth = 200;
            this.gridColumn5.Name = "gcLoc";
            this.gridColumn5.ReadOnly = true;
            this.gridColumn5.Width = 200;
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PopupInventoryLoc";
            this.ShowIcon = false;
            this.Text = "库位盘点明细";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormWhseReceive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem BtnCommit;
        private DevComponents.DotNetBar.ButtonItem ItemBtnExport;
        private DevComponents.DotNetBar.ButtonItem ItemBtnPrint;
        private DevComponents.DotNetBar.AdvPropertyGrid propertyBill;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private DevComponents.DotNetBar.ButtonItem btnCancel;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter2;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn26;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn13;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grid;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn5;
        private System.Windows.Forms.BindingSource bs;
        private DevComponents.DotNetBar.ButtonItem btnSave;
    }
}