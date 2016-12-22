namespace ChangKeTec.Wms.WinForm.Bills
{
    partial class FormOtherOut
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
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnModify = new DevComponents.DotNetBar.ButtonItem();
            this.btnCancel = new DevComponents.DotNetBar.ButtonItem();
            this.ItemBtnExport = new DevComponents.DotNetBar.ButtonItem();
            this.ItemBtnPrint = new DevComponents.DotNetBar.ButtonItem();
            this.btnFilter = new DevComponents.DotNetBar.ButtonItem();
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
            this.btnAdd,
            this.btnModify,
            this.btnCancel,
            this.ItemBtnExport,
            this.ItemBtnPrint,
            this.btnFilter});
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
            // btnAdd
            // 
            this.btnAdd.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnAdd.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_002;
            this.btnAdd.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnModify.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_020;
            this.btnModify.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnModify.Name = "btnModify";
            this.btnModify.Text = "修改";
            this.btnModify.Visible = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
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
            this.ItemBtnPrint.Visible = false;
            this.ItemBtnPrint.Click += new System.EventHandler(this.ItemBtnPrint_Click);
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
            this.grid.Size = new System.Drawing.Size(892, 532);
            this.grid.TabIndex = 9;
            this.grid.Total = 0;
            this.grid.PageSelectedIndexChanged += new ChangKeTec.Wms.Common.UC.CktMasterDetailGrid.PageSelectedIndexHandler(this.grid_PageSelectedIndexChanged);
            this.grid.MasterGridCellActivated += new ChangKeTec.Wms.Common.UC.CktMasterDetailGrid.CellActivatedHandler(this.grid_GridCellActivated);
            this.grid.DataRefreshed += new ChangKeTec.Wms.Common.UC.CktMasterDetailGrid.DataRefreshHandler(this.grid_DataRefreshed);
            // 
            // FormOtherOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 561);
            this.ControlBox = false;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.bar1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormOtherOut";
            this.ShowIcon = false;
            this.Text = "备件其他出库单";
            this.Load += new System.EventHandler(this.FormWhseReceive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnFilter;
        private DevComponents.DotNetBar.ButtonItem ItemBtnExport;
        private Common.UC.CktMasterDetailGrid grid;
        private DevComponents.DotNetBar.ButtonItem ItemBtnPrint;
        private DevComponents.DotNetBar.ButtonItem btnModify;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnCancel;
    }
}