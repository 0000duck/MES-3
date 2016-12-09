namespace ChangKeTec.Wms.Common.UC
{
    partial class CktMasterDetailGrid
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CktMasterDetailGrid));
            this.GridMaster = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.bsMaster = new System.Windows.Forms.BindingSource(this.components);
            this.esp = new DevComponents.DotNetBar.ExpandableSplitter();
            this.epProperty = new DevComponents.DotNetBar.ExpandablePanel();
            this.pg = new DevComponents.DotNetBar.AdvPropertyGrid();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTotalCount = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cbPageIndex = new System.Windows.Forms.ToolStripComboBox();
            this.lblPage = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pb = new System.Windows.Forms.ToolStripProgressBar();
            this.bnMaster = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.btnPrePage = new System.Windows.Forms.ToolStripButton();
            this.btnNextPage = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbPageSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.epDetail = new DevComponents.DotNetBar.ExpandablePanel();
            this.GridDetail = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.bsDetail = new System.Windows.Forms.BindingSource(this.components);
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaster)).BeginInit();
            this.epProperty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnMaster)).BeginInit();
            this.bnMaster.SuspendLayout();
            this.epDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridMaster
            // 
            this.GridMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridMaster.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.GridMaster.Location = new System.Drawing.Point(0, 0);
            this.GridMaster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GridMaster.Name = "GridMaster";
            // 
            // 
            // 
            // 
            // 
            // 
            this.GridMaster.PrimaryGrid.Caption.Text = "";
            this.GridMaster.PrimaryGrid.DataSource = this.bsMaster;
            this.GridMaster.PrimaryGrid.EnableCellRangeMarkup = true;
            this.GridMaster.PrimaryGrid.EnableColumnFiltering = true;
            this.GridMaster.PrimaryGrid.EnableFiltering = true;
            // 
            // 
            // 
            this.GridMaster.PrimaryGrid.Filter.ShowPanelFilterExpr = true;
            this.GridMaster.PrimaryGrid.Filter.Visible = true;
            // 
            // 
            // 
            this.GridMaster.PrimaryGrid.GroupByRow.Visible = true;
            this.GridMaster.PrimaryGrid.ShowRowGridIndex = true;
            this.GridMaster.Size = new System.Drawing.Size(551, 503);
            this.GridMaster.TabIndex = 0;
            this.GridMaster.Text = "superGridControl1";
            this.GridMaster.CellActivated += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellActivatedEventArgs>(this.GridMaster_CellActivated);
            this.GridMaster.CellDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellDoubleClickEventArgs>(this.GridMaster_CellDoubleClick);
            // 
            // esp
            // 
            this.esp.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.esp.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.esp.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.esp.Dock = System.Windows.Forms.DockStyle.Right;
            this.esp.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.esp.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.esp.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.esp.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.esp.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.esp.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.esp.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.esp.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.esp.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(61)))));
            this.esp.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94)))));
            this.esp.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.esp.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.esp.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.esp.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.esp.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.esp.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.esp.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.esp.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.esp.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.esp.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.esp.Location = new System.Drawing.Point(581, 0);
            this.esp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.esp.Name = "esp";
            this.esp.Size = new System.Drawing.Size(4, 503);
            this.esp.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.esp.TabIndex = 3;
            this.esp.TabStop = false;
            // 
            // epProperty
            // 
            this.epProperty.CanvasColor = System.Drawing.SystemColors.Control;
            this.epProperty.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.LeftToRight;
            this.epProperty.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.epProperty.Controls.Add(this.pg);
            this.epProperty.DisabledBackColor = System.Drawing.Color.Empty;
            this.epProperty.Dock = System.Windows.Forms.DockStyle.Left;
            this.epProperty.Expanded = false;
            this.epProperty.ExpandedBounds = new System.Drawing.Rectangle(589, 0, 269, 503);
            this.epProperty.Location = new System.Drawing.Point(0, 0);
            this.epProperty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.epProperty.Name = "epProperty";
            this.epProperty.Size = new System.Drawing.Size(30, 503);
            this.epProperty.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.epProperty.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.epProperty.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.epProperty.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
            this.epProperty.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.epProperty.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.epProperty.Style.GradientAngle = 90;
            this.epProperty.TabIndex = 12;
            this.epProperty.TitleHeight = 29;
            this.epProperty.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.epProperty.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.epProperty.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.epProperty.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.epProperty.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.epProperty.TitleStyle.GradientAngle = 90;
            this.epProperty.TitleText = "查看详情";
            // 
            // pg
            // 
            this.pg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pg.GridLinesColor = System.Drawing.Color.WhiteSmoke;
            this.pg.Location = new System.Drawing.Point(0, 29);
            this.pg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pg.Name = "pg";
            this.pg.Size = new System.Drawing.Size(30, 474);
            this.pg.TabIndex = 4;
            this.pg.Text = "advPropertyGrid1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 24);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(47, 24);
            this.lblTotalCount.Text = "共{0}行";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // cbPageIndex
            // 
            this.cbPageIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPageIndex.Name = "cbPageIndex";
            this.cbPageIndex.Size = new System.Drawing.Size(75, 27);
            this.cbPageIndex.SelectedIndexChanged += new System.EventHandler(this.cbPageIndex_SelectedIndexChanged);
            // 
            // lblPage
            // 
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(40, 24);
            this.lblPage.Text = "/{0}页";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // pb
            // 
            this.pb.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(75, 24);
            this.pb.Visible = false;
            // 
            // bnMaster
            // 
            this.bnMaster.AddNewItem = this.btnAdd;
            this.bnMaster.CountItem = this.bindingNavigatorCountItem;
            this.bnMaster.DeleteItem = this.btnDelete;
            this.bnMaster.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bnMaster.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bnMaster.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnDelete,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.toolStripSeparator1,
            this.btnPrePage,
            this.btnNextPage,
            this.cbPageIndex,
            this.lblPage,
            this.toolStripSeparator2,
            this.lblTotalCount,
            this.btnRefresh,
            this.pb,
            this.toolStripLabel1,
            this.cbPageSize,
            this.toolStripLabel2});
            this.bnMaster.Location = new System.Drawing.Point(0, 503);
            this.bnMaster.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnMaster.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnMaster.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnMaster.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnMaster.Name = "bnMaster";
            this.bnMaster.PositionItem = this.bindingNavigatorPositionItem;
            this.bnMaster.Size = new System.Drawing.Size(885, 27);
            this.bnMaster.TabIndex = 1;
            this.bnMaster.Text = "bindingNavigator1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(24, 24);
            this.btnAdd.Text = "新添";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeftAutoMirrorImage = true;
            this.btnDelete.Size = new System.Drawing.Size(24, 24);
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            // btnPrePage
            // 
            this.btnPrePage.Image = ((System.Drawing.Image)(resources.GetObject("btnPrePage.Image")));
            this.btnPrePage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrePage.Name = "btnPrePage";
            this.btnPrePage.Size = new System.Drawing.Size(68, 24);
            this.btnPrePage.Text = "上一页";
            this.btnPrePage.Click += new System.EventHandler(this.btnPrePage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Image = ((System.Drawing.Image)(resources.GetObject("btnNextPage.Image")));
            this.btnNextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(68, 24);
            this.btnNextPage.Text = "下一页";
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(56, 24);
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 24);
            this.toolStripLabel1.Text = "每页";
            // 
            // cbPageSize
            // 
            this.cbPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPageSize.Items.AddRange(new object[] {
            "50",
            "100",
            "200",
            "500",
            "1000",
            "5000",
            "10000",
            "100000"});
            this.cbPageSize.Name = "cbPageSize";
            this.cbPageSize.Size = new System.Drawing.Size(75, 27);
            this.cbPageSize.SelectedIndexChanged += new System.EventHandler(this.cbPageSize_SelectedIndexChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(20, 24);
            this.toolStripLabel2.Text = "行";
            // 
            // epDetail
            // 
            this.epDetail.CanvasColor = System.Drawing.SystemColors.Control;
            this.epDetail.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.LeftToRight;
            this.epDetail.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.epDetail.Controls.Add(this.GridDetail);
            this.epDetail.DisabledBackColor = System.Drawing.Color.Empty;
            this.epDetail.Dock = System.Windows.Forms.DockStyle.Right;
            this.epDetail.Location = new System.Drawing.Point(585, 0);
            this.epDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.epDetail.Name = "epDetail";
            this.epDetail.Size = new System.Drawing.Size(300, 503);
            this.epDetail.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.epDetail.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.epDetail.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.epDetail.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
            this.epDetail.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.epDetail.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.epDetail.Style.GradientAngle = 90;
            this.epDetail.TabIndex = 19;
            this.epDetail.TitleHeight = 29;
            this.epDetail.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.epDetail.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.epDetail.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.epDetail.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.epDetail.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.epDetail.TitleStyle.GradientAngle = 90;
            this.epDetail.TitleText = "查看明细";
            // 
            // GridDetail
            // 
            this.GridDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridDetail.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.GridDetail.Location = new System.Drawing.Point(0, 29);
            this.GridDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GridDetail.Name = "GridDetail";
            // 
            // 
            // 
            this.GridDetail.PrimaryGrid.DataSource = this.bsDetail;
            this.GridDetail.PrimaryGrid.EnableCellRangeMarkup = true;
            this.GridDetail.PrimaryGrid.EnableColumnFiltering = true;
            this.GridDetail.PrimaryGrid.EnableFiltering = true;
            // 
            // 
            // 
            this.GridDetail.PrimaryGrid.Filter.ShowPanelFilterExpr = true;
            this.GridDetail.PrimaryGrid.Filter.Visible = true;
            this.GridDetail.Size = new System.Drawing.Size(300, 474);
            this.GridDetail.TabIndex = 4;
            this.GridDetail.Text = "superGridControl1";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.GridMaster);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelEx1.Location = new System.Drawing.Point(30, 0);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(551, 503);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.LightYellow;
            this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.LightYellow;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 23;
            this.panelEx1.Text = "无数据";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX1.Location = new System.Drawing.Point(0, 0);
            this.labelX1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(551, 503);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "无数据";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // CktMasterDetailGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.esp);
            this.Controls.Add(this.epProperty);
            this.Controls.Add(this.epDetail);
            this.Controls.Add(this.bnMaster);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CktMasterDetailGrid";
            this.Size = new System.Drawing.Size(885, 530);
            ((System.ComponentModel.ISupportInitialize)(this.bsMaster)).EndInit();
            this.epProperty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnMaster)).EndInit();
            this.bnMaster.ResumeLayout(false);
            this.bnMaster.PerformLayout();
            this.epDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl GridMaster;
        public System.Windows.Forms.BindingSource bsMaster;
        private DevComponents.DotNetBar.ExpandableSplitter esp;
        private DevComponents.DotNetBar.ExpandablePanel epProperty;
        private DevComponents.DotNetBar.AdvPropertyGrid pg;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripLabel lblTotalCount;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox cbPageIndex;
        private System.Windows.Forms.ToolStripLabel lblPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripProgressBar pb;
        private System.Windows.Forms.BindingNavigator bnMaster;
        private DevComponents.DotNetBar.ExpandablePanel epDetail;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl GridDetail;
        private System.Windows.Forms.BindingSource bsDetail;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnPrePage;
        private System.Windows.Forms.ToolStripButton btnNextPage;
        private System.Windows.Forms.ToolStripComboBox cbPageSize;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}
