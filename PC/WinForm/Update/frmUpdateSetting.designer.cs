namespace ChangKeTec.Wms.WinForm.Update
{
    partial class frmUpdateSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateSetting));
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.btnRefresh = new DevComponents.DotNetBar.ButtonItem();
            this.btnSelectAll = new DevComponents.DotNetBar.ButtonItem();
            this.btnUnSelectAll = new DevComponents.DotNetBar.ButtonItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.expandableSplitter2 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.grid = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.gcCheck = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gclFile = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gclFileSize = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gclModifyDate = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gcsFileSize = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gcsModifyDate = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gcFullName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
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
            this.btnRefresh,
            this.btnSelectAll,
            this.btnUnSelectAll,
            this.btnSave});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Margin = new System.Windows.Forms.Padding(2);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(764, 29);
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
            // btnRefresh
            // 
            this.btnRefresh.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSelectAll.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_203;
            this.btnSelectAll.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Text = "全选";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnUnSelectAll
            // 
            this.btnUnSelectAll.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnUnSelectAll.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_184;
            this.btnUnSelectAll.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnUnSelectAll.Name = "btnUnSelectAll";
            this.btnUnSelectAll.Text = "非全选";
            this.btnUnSelectAll.Click += new System.EventHandler(this.btnUnSelectAll_Click);
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
            this.expandableSplitter2.Location = new System.Drawing.Point(0, 29);
            this.expandableSplitter2.Margin = new System.Windows.Forms.Padding(2);
            this.expandableSplitter2.Name = "expandableSplitter2";
            this.expandableSplitter2.Size = new System.Drawing.Size(4, 357);
            this.expandableSplitter2.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter2.TabIndex = 59;
            this.expandableSplitter2.TabStop = false;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grid.Location = new System.Drawing.Point(4, 29);
            this.grid.Margin = new System.Windows.Forms.Padding(2);
            this.grid.Name = "grid";
            // 
            // 
            // 
            this.grid.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            this.grid.PrimaryGrid.Columns.Add(this.gcCheck);
            this.grid.PrimaryGrid.Columns.Add(this.gclFile);
            this.grid.PrimaryGrid.Columns.Add(this.gclFileSize);
            this.grid.PrimaryGrid.Columns.Add(this.gclModifyDate);
            this.grid.PrimaryGrid.Columns.Add(this.gcsFileSize);
            this.grid.PrimaryGrid.Columns.Add(this.gcsModifyDate);
            this.grid.PrimaryGrid.Columns.Add(this.gcFullName);
            // 
            // 
            // 
            this.grid.PrimaryGrid.Filter.Visible = true;
            // 
            // 
            // 
            this.grid.PrimaryGrid.GroupByRow.Visible = true;
            this.grid.PrimaryGrid.GroupHeaderClickBehavior = DevComponents.DotNetBar.SuperGrid.GroupHeaderClickBehavior.Select;
            this.grid.PrimaryGrid.GroupHeaderKeyBehavior = DevComponents.DotNetBar.SuperGrid.GroupHeaderKeyBehavior.Select;
            this.grid.PrimaryGrid.NoRowsText = "（无数据）";
            this.grid.PrimaryGrid.ShowRowGridIndex = true;
            this.grid.Size = new System.Drawing.Size(760, 357);
            this.grid.TabIndex = 63;
            this.grid.Text = "superGridControl1";
            // 
            // gcCheck
            // 
            this.gcCheck.DataPropertyName = "Check";
            this.gcCheck.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            this.gcCheck.HeaderText = "上传";
            this.gcCheck.Name = "gcCheck";
            // 
            // gclFile
            // 
            this.gclFile.DataPropertyName = "FileName";
            this.gclFile.HeaderText = "文件名";
            this.gclFile.Name = "gcFile";
            this.gclFile.ReadOnly = true;
            // 
            // gclFileSize
            // 
            this.gclFileSize.DataPropertyName = "lFileSize";
            this.gclFileSize.HeaderText = "文件大小";
            this.gclFileSize.Name = "gclFileSize";
            this.gclFileSize.ReadOnly = true;
            // 
            // gclModifyDate
            // 
            this.gclModifyDate.DataPropertyName = "lModifyDate";
            this.gclModifyDate.HeaderText = "更新日期";
            this.gclModifyDate.Name = "gclModifyDate";
            this.gclModifyDate.ReadOnly = true;
            // 
            // gcsFileSize
            // 
            this.gcsFileSize.DataPropertyName = "sFileSize";
            this.gcsFileSize.HeaderText = "文件大小";
            this.gcsFileSize.Name = "gcsFileSize";
            this.gcsFileSize.ReadOnly = true;
            // 
            // gcsModifyDate
            // 
            this.gcsModifyDate.DataPropertyName = "sModifyDate";
            this.gcsModifyDate.HeaderText = "更新日期";
            this.gcsModifyDate.Name = "gcsModifyDate";
            this.gcsModifyDate.ReadOnly = true;
            // 
            // gcFullName
            // 
            this.gcFullName.DataPropertyName = "FullName";
            this.gcFullName.HeaderText = "文件路径";
            this.gcFullName.Name = "gcFullName";
            this.gcFullName.ReadOnly = true;
            // 
            // frmUpdateSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 386);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.expandableSplitter2);
            this.Controls.Add(this.bar1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUpdateSetting";
            this.ShowIcon = false;
            this.Text = "软件更新";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUpdateSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnUnSelectAll;
        private DevComponents.DotNetBar.ButtonItem btnSelectAll;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private DevComponents.DotNetBar.ButtonItem btnRefresh;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter2;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grid;
        private System.Windows.Forms.BindingSource bs;
        private DevComponents.DotNetBar.ButtonItem btnSave;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gcCheck;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gclFile;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gclFileSize;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gclModifyDate;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gcsFileSize;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gcsModifyDate;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gcFullName;
    }
}