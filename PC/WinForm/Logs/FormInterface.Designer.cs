namespace ChangKeTec.Wms.WinForm.Logs
{
    partial class FormInterface
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
            this.ItemBtnExport = new DevComponents.DotNetBar.ButtonItem();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.gridInterface = new ChangKeTec.Wms.Common.UC.CktMasterDetailGrid();
            this.bnMaster = new System.Windows.Forms.BindingNavigator(this.components);
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.gridInterface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
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
            // ItemBtnExport
            // 
            this.ItemBtnExport.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ItemBtnExport.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_180;
            this.ItemBtnExport.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.ItemBtnExport.Name = "ItemBtnExport";
            this.ItemBtnExport.Text = "导出";
            this.ItemBtnExport.Click += new System.EventHandler(this.ItemBtnExport_Click);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.superTabControl1);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 30);
            this.panelEx2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(1189, 671);
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
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControl1.Location = new System.Drawing.Point(0, 0);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 0;
            this.superTabControl1.Size = new System.Drawing.Size(1189, 671);
            this.superTabControl1.TabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.superTabControl1.TabIndex = 5;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1});
            this.superTabControl1.Text = "superTabControl1";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.gridInterface);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 31);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(1189, 640);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // gridInterface
            // 
            this.gridInterface.Controls.Add(this.bnMaster);
            this.gridInterface.Detail1DataSource = null;
            this.gridInterface.DetailPanelDock = System.Windows.Forms.DockStyle.Right;
            this.gridInterface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridInterface.IsNavigatorVisible = false;
            this.gridInterface.IsPropertyExpand = false;
            this.gridInterface.IsPropertyVisible = true;
            this.gridInterface.Location = new System.Drawing.Point(0, 0);
            this.gridInterface.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridInterface.MasterDataSource = null;
            this.gridInterface.Name = "gridInterface";
            this.gridInterface.PageIndex = 1;
            this.gridInterface.PageSize = 100;
            this.gridInterface.PropertyPanelDock = System.Windows.Forms.DockStyle.Right;
            this.gridInterface.Size = new System.Drawing.Size(1189, 640);
            this.gridInterface.TabIndex = 1;
            this.gridInterface.Total = 0;
            // 
            // bnMaster
            // 
            this.bnMaster.AddNewItem = null;
            this.bnMaster.CountItem = null;
            this.bnMaster.DeleteItem = null;
            this.bnMaster.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bnMaster.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bnMaster.Location = new System.Drawing.Point(0, 634);
            this.bnMaster.MoveFirstItem = null;
            this.bnMaster.MoveLastItem = null;
            this.bnMaster.MoveNextItem = null;
            this.bnMaster.MovePreviousItem = null;
            this.bnMaster.Name = "bnMaster";
            this.bnMaster.PositionItem = null;
            this.bnMaster.Size = new System.Drawing.Size(1180, 28);
            this.bnMaster.TabIndex = 1;
            this.bnMaster.Text = "bindingNavigator1";
            this.bnMaster.Visible = false;
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "待生成接口数据";
            // 
            // FormInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 701);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.bar1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormInterface";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FormLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.gridInterface.ResumeLayout(false);
            this.gridInterface.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.ButtonItem ItemBtnExport;
        private Common.UC.CktMasterDetailGrid gridInterface;
        private System.Windows.Forms.BindingNavigator bnMaster;
        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
    }
}