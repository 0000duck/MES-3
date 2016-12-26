namespace ChangKeTec.Wms.WinForm.PopUp
{
    partial class PopupStockChoice
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
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnFilter = new DevComponents.DotNetBar.ButtonItem();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.gpFilter = new System.Windows.Forms.GroupBox();
            this.cbKW = new System.Windows.Forms.CheckBox();
            this.tbKW = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbModel = new System.Windows.Forms.CheckBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbName = new System.Windows.Forms.CheckBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grid = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.gcPartCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn13 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn26 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gcBatch = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gcKW = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gcUnitPrice = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.gpFilter.SuspendLayout();
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
            this.btnSave,
            this.btnFilter});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Margin = new System.Windows.Forms.Padding(2);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(672, 29);
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
            // btnSave
            // 
            this.btnSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSave.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_002;
            this.btnSave.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "确定";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnFilter.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_249;
            this.btnFilter.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Text = "过滤";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // gpFilter
            // 
            this.gpFilter.Controls.Add(this.cbKW);
            this.gpFilter.Controls.Add(this.tbKW);
            this.gpFilter.Controls.Add(this.label3);
            this.gpFilter.Controls.Add(this.cbModel);
            this.gpFilter.Controls.Add(this.tbModel);
            this.gpFilter.Controls.Add(this.label2);
            this.gpFilter.Controls.Add(this.cbName);
            this.gpFilter.Controls.Add(this.tbName);
            this.gpFilter.Controls.Add(this.label1);
            this.gpFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpFilter.Location = new System.Drawing.Point(0, 29);
            this.gpFilter.Name = "gpFilter";
            this.gpFilter.Size = new System.Drawing.Size(672, 113);
            this.gpFilter.TabIndex = 1;
            this.gpFilter.TabStop = false;
            this.gpFilter.Text = "查询条件";
            // 
            // cbKW
            // 
            this.cbKW.AutoSize = true;
            this.cbKW.Location = new System.Drawing.Point(26, 83);
            this.cbKW.Name = "cbKW";
            this.cbKW.Size = new System.Drawing.Size(15, 14);
            this.cbKW.TabIndex = 8;
            this.cbKW.UseVisualStyleBackColor = true;
            // 
            // tbKW
            // 
            this.tbKW.Location = new System.Drawing.Point(106, 81);
            this.tbKW.Name = "tbKW";
            this.tbKW.Size = new System.Drawing.Size(156, 21);
            this.tbKW.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "库位";
            // 
            // cbModel
            // 
            this.cbModel.AutoSize = true;
            this.cbModel.Location = new System.Drawing.Point(26, 56);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(15, 14);
            this.cbModel.TabIndex = 5;
            this.cbModel.UseVisualStyleBackColor = true;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(106, 54);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(156, 21);
            this.tbModel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "规格型号";
            // 
            // cbName
            // 
            this.cbName.AutoSize = true;
            this.cbName.Checked = true;
            this.cbName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbName.Location = new System.Drawing.Point(26, 29);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(15, 14);
            this.cbName.TabIndex = 2;
            this.cbName.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(106, 27);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(156, 21);
            this.tbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "备件名称";
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grid.Location = new System.Drawing.Point(0, 142);
            this.grid.Margin = new System.Windows.Forms.Padding(2);
            this.grid.Name = "grid";
            // 
            // 
            // 
            this.grid.PrimaryGrid.AutoGenerateColumns = false;
            this.grid.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            this.grid.PrimaryGrid.Columns.Add(this.gcPartCode);
            this.grid.PrimaryGrid.Columns.Add(this.gridColumn2);
            this.grid.PrimaryGrid.Columns.Add(this.gridColumn13);
            this.grid.PrimaryGrid.Columns.Add(this.gridColumn26);
            this.grid.PrimaryGrid.Columns.Add(this.gcBatch);
            this.grid.PrimaryGrid.Columns.Add(this.gcKW);
            this.grid.PrimaryGrid.Columns.Add(this.gcUnitPrice);
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
            this.grid.Size = new System.Drawing.Size(672, 419);
            this.grid.TabIndex = 64;
            this.grid.Text = "superGridControl1";
            this.grid.CellActivated += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellActivatedEventArgs>(this.grid_CellActivated);
            this.grid.CellDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellDoubleClickEventArgs>(this.grid_CellDoubleClick);
            // 
            // gcPartCode
            // 
            this.gcPartCode.DataPropertyName = "零件号";
            this.gcPartCode.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridComboBoxExEditControl);
            this.gcPartCode.HeaderText = "备件编号";
            this.gcPartCode.MinimumWidth = 200;
            this.gcPartCode.Name = "gcPartCode";
            this.gcPartCode.ReadOnly = true;
            this.gcPartCode.Width = 200;
            // 
            // gridColumn2
            // 
            this.gridColumn2.DataPropertyName = "ERP零件号";
            this.gridColumn2.HeaderText = "ERP零件号";
            this.gridColumn2.MinimumWidth = 200;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.ReadOnly = true;
            this.gridColumn2.Width = 200;
            // 
            // gridColumn13
            // 
            this.gridColumn13.DataPropertyName = "零件描述1";
            this.gridColumn13.HeaderText = "备件名称";
            this.gridColumn13.Name = "Column6";
            this.gridColumn13.ReadOnly = true;
            // 
            // gridColumn26
            // 
            this.gridColumn26.DataPropertyName = "零件描述2";
            this.gridColumn26.FillWeight = 300;
            this.gridColumn26.HeaderText = "备件描述";
            this.gridColumn26.MinimumWidth = 300;
            this.gridColumn26.Name = "gridColumn26";
            this.gridColumn26.ReadOnly = true;
            this.gridColumn26.Width = 300;
            // 
            // gcBatch
            // 
            this.gcBatch.DataPropertyName = "批次";
            this.gcBatch.HeaderText = "批次";
            this.gcBatch.Name = "gcBatch";
            // 
            // gcKW
            // 
            this.gcKW.DataPropertyName = "库位";
            this.gcKW.HeaderText = "库位";
            this.gcKW.Name = "gcKW";
            // 
            // gcUnitPrice
            // 
            this.gcUnitPrice.DataPropertyName = "单价";
            this.gcUnitPrice.HeaderText = "单价";
            this.gcUnitPrice.Name = "gcUnitPrice";
            // 
            // PopupStockChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 561);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.gpFilter);
            this.Controls.Add(this.bar1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PopupStockChoice";
            this.ShowIcon = false;
            this.Text = "备件信息选择";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormWhseReceive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.gpFilter.ResumeLayout(false);
            this.gpFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private System.Windows.Forms.BindingSource bs;
        private DevComponents.DotNetBar.ButtonItem btnSave;
        private DevComponents.DotNetBar.ButtonItem btnFilter;
        private System.Windows.Forms.GroupBox gpFilter;
        private System.Windows.Forms.CheckBox cbModel;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grid;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gcPartCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn13;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn26;
        private System.Windows.Forms.CheckBox cbKW;
        private System.Windows.Forms.TextBox tbKW;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gcBatch;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gcKW;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gcUnitPrice;
    }
}