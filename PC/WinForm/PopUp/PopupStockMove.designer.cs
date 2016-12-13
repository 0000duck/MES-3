namespace ChangKeTec.Wms.WinForm.PopUp
{
    partial class PopupStockMove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupStockMove));
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.BtnSave = new DevComponents.DotNetBar.ButtonItem();
            this.ItemBtnExport = new DevComponents.DotNetBar.ButtonItem();
            this.propertyBill = new DevComponents.DotNetBar.AdvPropertyGrid();
            this.cktMasterDetailGrid4 = new ChangKeTec.Wms.Common.UC.CktMasterDetailGrid();
            this.cktMasterDetailGrid3 = new ChangKeTec.Wms.Common.UC.CktMasterDetailGrid();
            this.cktMasterDetailGrid2 = new ChangKeTec.Wms.Common.UC.CktMasterDetailGrid();
            this.cktMasterDetailGrid1 = new ChangKeTec.Wms.Common.UC.CktMasterDetailGrid();
            this.expandableSplitter2 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.bn = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.grid = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.gcUID = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gcBillNum = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gcPartCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gcBatch = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gcFromLocCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gcToLocCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gcQty = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gcRemark = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBill)).BeginInit();
            this.propertyBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).BeginInit();
            this.bn.SuspendLayout();
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
            this.BtnSave,
            this.ItemBtnExport});
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
            // BtnSave
            // 
            this.BtnSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Text = "保存";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
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
            // propertyBill
            // 
            this.propertyBill.Controls.Add(this.cktMasterDetailGrid4);
            this.propertyBill.Controls.Add(this.cktMasterDetailGrid3);
            this.propertyBill.Controls.Add(this.cktMasterDetailGrid2);
            this.propertyBill.Controls.Add(this.cktMasterDetailGrid1);
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
            // cktMasterDetailGrid4
            // 
            this.cktMasterDetailGrid4.Detail1DataSource = null;
            this.cktMasterDetailGrid4.DetailPanelDock = System.Windows.Forms.DockStyle.Right;
            this.cktMasterDetailGrid4.IsNavigatorVisible = true;
            this.cktMasterDetailGrid4.IsPropertyExpand = false;
            this.cktMasterDetailGrid4.IsPropertyVisible = true;
            this.cktMasterDetailGrid4.Location = new System.Drawing.Point(0, 0);
            this.cktMasterDetailGrid4.Margin = new System.Windows.Forms.Padding(2);
            this.cktMasterDetailGrid4.MasterDataSource = null;
            this.cktMasterDetailGrid4.Name = "cktMasterDetailGrid4";
            this.cktMasterDetailGrid4.PageIndex = 1;
            this.cktMasterDetailGrid4.PageSize = 100;
            this.cktMasterDetailGrid4.PropertyPanelDock = System.Windows.Forms.DockStyle.Left;
            this.cktMasterDetailGrid4.Size = new System.Drawing.Size(885, 530);
            this.cktMasterDetailGrid4.TabIndex = 7;
            this.cktMasterDetailGrid4.Total = 0;
            // 
            // cktMasterDetailGrid3
            // 
            this.cktMasterDetailGrid3.Detail1DataSource = null;
            this.cktMasterDetailGrid3.DetailPanelDock = System.Windows.Forms.DockStyle.Right;
            this.cktMasterDetailGrid3.IsNavigatorVisible = true;
            this.cktMasterDetailGrid3.IsPropertyExpand = false;
            this.cktMasterDetailGrid3.IsPropertyVisible = true;
            this.cktMasterDetailGrid3.Location = new System.Drawing.Point(0, 0);
            this.cktMasterDetailGrid3.Margin = new System.Windows.Forms.Padding(2);
            this.cktMasterDetailGrid3.MasterDataSource = null;
            this.cktMasterDetailGrid3.Name = "cktMasterDetailGrid3";
            this.cktMasterDetailGrid3.PageIndex = 1;
            this.cktMasterDetailGrid3.PageSize = 100;
            this.cktMasterDetailGrid3.PropertyPanelDock = System.Windows.Forms.DockStyle.Left;
            this.cktMasterDetailGrid3.Size = new System.Drawing.Size(885, 530);
            this.cktMasterDetailGrid3.TabIndex = 6;
            this.cktMasterDetailGrid3.Total = 0;
            // 
            // cktMasterDetailGrid2
            // 
            this.cktMasterDetailGrid2.Detail1DataSource = null;
            this.cktMasterDetailGrid2.DetailPanelDock = System.Windows.Forms.DockStyle.Right;
            this.cktMasterDetailGrid2.IsNavigatorVisible = true;
            this.cktMasterDetailGrid2.IsPropertyExpand = false;
            this.cktMasterDetailGrid2.IsPropertyVisible = true;
            this.cktMasterDetailGrid2.Location = new System.Drawing.Point(0, 0);
            this.cktMasterDetailGrid2.Margin = new System.Windows.Forms.Padding(2);
            this.cktMasterDetailGrid2.MasterDataSource = null;
            this.cktMasterDetailGrid2.Name = "cktMasterDetailGrid2";
            this.cktMasterDetailGrid2.PageIndex = 1;
            this.cktMasterDetailGrid2.PageSize = 100;
            this.cktMasterDetailGrid2.PropertyPanelDock = System.Windows.Forms.DockStyle.Left;
            this.cktMasterDetailGrid2.Size = new System.Drawing.Size(885, 530);
            this.cktMasterDetailGrid2.TabIndex = 5;
            this.cktMasterDetailGrid2.Total = 0;
            // 
            // cktMasterDetailGrid1
            // 
            this.cktMasterDetailGrid1.Detail1DataSource = null;
            this.cktMasterDetailGrid1.DetailPanelDock = System.Windows.Forms.DockStyle.Right;
            this.cktMasterDetailGrid1.IsNavigatorVisible = true;
            this.cktMasterDetailGrid1.IsPropertyExpand = false;
            this.cktMasterDetailGrid1.IsPropertyVisible = true;
            this.cktMasterDetailGrid1.Location = new System.Drawing.Point(0, 0);
            this.cktMasterDetailGrid1.Margin = new System.Windows.Forms.Padding(2);
            this.cktMasterDetailGrid1.MasterDataSource = null;
            this.cktMasterDetailGrid1.Name = "cktMasterDetailGrid1";
            this.cktMasterDetailGrid1.PageIndex = 1;
            this.cktMasterDetailGrid1.PageSize = 100;
            this.cktMasterDetailGrid1.PropertyPanelDock = System.Windows.Forms.DockStyle.Left;
            this.cktMasterDetailGrid1.Size = new System.Drawing.Size(885, 530);
            this.cktMasterDetailGrid1.TabIndex = 4;
            this.cktMasterDetailGrid1.Total = 0;
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
            // bn
            // 
            this.bn.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bn.CountItem = this.bindingNavigatorCountItem;
            this.bn.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bn.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bn.Location = new System.Drawing.Point(235, 29);
            this.bn.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn.Name = "bn";
            this.bn.PositionItem = this.bindingNavigatorPositionItem;
            this.bn.Size = new System.Drawing.Size(657, 27);
            this.bn.TabIndex = 60;
            this.bn.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 24);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grid.Location = new System.Drawing.Point(235, 56);
            this.grid.Margin = new System.Windows.Forms.Padding(2);
            this.grid.Name = "grid";
            // 
            // 
            // 
            this.grid.PrimaryGrid.AutoGenerateColumns = false;
            this.grid.PrimaryGrid.Columns.Add(this.gcUID);
            this.grid.PrimaryGrid.Columns.Add(this.gcBillNum);
            this.grid.PrimaryGrid.Columns.Add(this.gcPartCode);
            this.grid.PrimaryGrid.Columns.Add(this.gcBatch);
            this.grid.PrimaryGrid.Columns.Add(this.gcFromLocCode);
            this.grid.PrimaryGrid.Columns.Add(this.gcToLocCode);
            this.grid.PrimaryGrid.Columns.Add(this.gcQty);
            this.grid.PrimaryGrid.Columns.Add(this.gcRemark);
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
            this.grid.Size = new System.Drawing.Size(657, 505);
            this.grid.TabIndex = 61;
            this.grid.Text = "superGridControl1";
            this.grid.CellValueChanged += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellValueChangedEventArgs>(this.grid_CellValueChanged);
            // 
            // gcUID
            // 
            this.gcUID.DataPropertyName = "UID";
            this.gcUID.HeaderText = "UID";
            this.gcUID.Name = "gridColumn1";
            this.gcUID.Visible = false;
            // 
            // gcBillNum
            // 
            this.gcBillNum.DataPropertyName = "BillNum";
            this.gcBillNum.HeaderText = "单据号";
            this.gcBillNum.Name = "gridColumn2";
            // 
            // gcPartCode
            // 
            this.gcPartCode.DataPropertyName = "PartCode";
            this.gcPartCode.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridComboBoxExEditControl);
            this.gcPartCode.HeaderText = "零件号";
            this.gcPartCode.Name = "gridColumn3";
            // 
            // gcBatch
            // 
            this.gcBatch.DataPropertyName = "Batch";
            this.gcBatch.HeaderText = "批次";
            this.gcBatch.Name = "gridColumn3";
            // 
            // gcFromLocCode
            // 
            this.gcFromLocCode.DataPropertyName = "FromLocCode";
            this.gcFromLocCode.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridComboBoxExEditControl);
            this.gcFromLocCode.HeaderText = "来源库位";
            this.gcFromLocCode.Name = "gridColumn4";
            // 
            // gcToLocCode
            // 
            this.gcToLocCode.DataPropertyName = "ToLocCode";
            this.gcToLocCode.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridComboBoxExEditControl);
            this.gcToLocCode.HeaderText = "目标库位";
            this.gcToLocCode.Name = "gridColumn5";
            // 
            // gcQty
            // 
            this.gcQty.DataPropertyName = "Qty";
            this.gcQty.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridIntegerInputEditControl);
            this.gcQty.HeaderText = "移动数量";
            this.gcQty.Name = "gridColumn6";
            // 
            // gcRemark
            // 
            this.gcRemark.DataPropertyName = "Remark";
            this.gcRemark.HeaderText = "备注";
            this.gcRemark.Name = "gridColumn17";
            // 
            // PopupStockMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 561);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.bn);
            this.Controls.Add(this.expandableSplitter2);
            this.Controls.Add(this.propertyBill);
            this.Controls.Add(this.bar1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PopupStockMove";
            this.ShowIcon = false;
            this.Text = "新增移库单";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormWhseReceive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBill)).EndInit();
            this.propertyBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bn)).EndInit();
            this.bn.ResumeLayout(false);
            this.bn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem BtnSave;
        private DevComponents.DotNetBar.ButtonItem ItemBtnExport;
        private DevComponents.DotNetBar.AdvPropertyGrid propertyBill;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter2;
        private Common.UC.CktMasterDetailGrid cktMasterDetailGrid4;
        private Common.UC.CktMasterDetailGrid cktMasterDetailGrid3;
        private Common.UC.CktMasterDetailGrid cktMasterDetailGrid2;
        private Common.UC.CktMasterDetailGrid cktMasterDetailGrid1;
        private System.Windows.Forms.BindingNavigator bn;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bs;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grid;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gcUID;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gcBillNum;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gcPartCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gcBatch;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gcToLocCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gcQty;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gcRemark;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gcFromLocCode;
    }
}