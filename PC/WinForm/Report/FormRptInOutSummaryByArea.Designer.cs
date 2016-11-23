namespace ChangKeTec.Wms.WinForm.Report
{
    partial class FormRptInOutSummaryByArea
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.ItemBtnExport = new DevComponents.DotNetBar.ButtonItem();
            this.btnFilter = new DevComponents.DotNetBar.ButtonItem();
            this.txtSearch = new DevComponents.DotNetBar.TextBoxItem();
            this.btnSearch = new DevComponents.DotNetBar.ButtonItem();
            this.btnReset = new DevComponents.DotNetBar.ButtonItem();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.dgvBill = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.PartCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ItemBtnExport,
            this.btnFilter,
            this.txtSearch,
            this.btnSearch,
            this.btnReset});
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
            // ItemBtnExport
            // 
            this.ItemBtnExport.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ItemBtnExport.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_180;
            this.ItemBtnExport.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.ItemBtnExport.Name = "ItemBtnExport";
            this.ItemBtnExport.Text = "导出";
            this.ItemBtnExport.Click += new System.EventHandler(this.ItemBtnExport_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnFilter.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_024;
            this.btnFilter.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnFilter.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Text = "筛选";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.TextBoxWidth = 200;
            this.txtSearch.WatermarkColor = System.Drawing.SystemColors.GrayText;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSearch.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_249;
            this.btnSearch.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Text = "搜索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnReset.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_231;
            this.btnReset.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnReset.Name = "btnReset";
            this.btnReset.Text = "重置";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.dgvBill);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 29);
            this.panelEx2.Margin = new System.Windows.Forms.Padding(2);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(892, 532);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 5;
            this.panelEx2.Text = "panelEx2";
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartCode,
            this.InQty,
            this.OutQty,
            this.StockQty,
            this.colArea});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBill.EnableHeadersVisualStyles = false;
            this.dgvBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvBill.Location = new System.Drawing.Point(0, 0);
            this.dgvBill.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBill.RowTemplate.Height = 27;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBill.Size = new System.Drawing.Size(892, 532);
            this.dgvBill.TabIndex = 0;
            this.dgvBill.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellEnter);
            // 
            // PartCode
            // 
            this.PartCode.DataPropertyName = "零件号";
            this.PartCode.HeaderText = "零件号";
            this.PartCode.Name = "PartCode";
            this.PartCode.ReadOnly = true;
            this.PartCode.Width = 150;
            // 
            // InQty
            // 
            this.InQty.DataPropertyName = "入库数量";
            this.InQty.HeaderText = "入库数量";
            this.InQty.Name = "InQty";
            this.InQty.ReadOnly = true;
            this.InQty.Width = 96;
            // 
            // OutQty
            // 
            this.OutQty.DataPropertyName = "出库数量";
            this.OutQty.HeaderText = "出库数量";
            this.OutQty.Name = "OutQty";
            this.OutQty.ReadOnly = true;
            this.OutQty.Width = 96;
            // 
            // StockQty
            // 
            this.StockQty.DataPropertyName = "库存数量";
            this.StockQty.HeaderText = "库存数量";
            this.StockQty.Name = "StockQty";
            this.StockQty.ReadOnly = true;
            // 
            // colArea
            // 
            this.colArea.DataPropertyName = "库区";
            this.colArea.HeaderText = "库区";
            this.colArea.Name = "colArea";
            this.colArea.ReadOnly = true;
            // 
            // FormIOSUMMARYByArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 561);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.bar1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRptInOutSummaryByArea";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FormLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnFilter;
        private DevComponents.DotNetBar.TextBoxItem txtSearch;
        private DevComponents.DotNetBar.ButtonItem btnSearch;
        private DevComponents.DotNetBar.ButtonItem btnReset;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvBill;
        private DevComponents.DotNetBar.ButtonItem ItemBtnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn InQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArea;
    }
}