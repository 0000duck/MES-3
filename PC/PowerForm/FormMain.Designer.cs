namespace ChangKeTec.PowerForm
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.RibbonMain = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.barSysInfo = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCloseOther = new System.Windows.Forms.ToolStripMenuItem();
            this.AppCommandTheme = new DevComponents.DotNetBar.Command(this.components);
            this.TabControlPanelMain = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabControlMain = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanelMain = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.timerNotify = new System.Windows.Forms.Timer(this.components);
            this.btnMobilePass = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.btnOper = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem21 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.RibbonMain.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControlMain)).BeginInit();
            this.superTabControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // RibbonMain
            // 
            // 
            // 
            // 
            this.RibbonMain.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RibbonMain.CaptionVisible = true;
            this.RibbonMain.Controls.Add(this.ribbonPanel1);
            this.RibbonMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.RibbonMain.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem1});
            this.RibbonMain.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.RibbonMain.Location = new System.Drawing.Point(5, 1);
            this.RibbonMain.Name = "RibbonMain";
            this.RibbonMain.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.RibbonMain.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.qatCustomizeItem1});
            this.RibbonMain.Size = new System.Drawing.Size(1318, 143);
            this.RibbonMain.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RibbonMain.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.RibbonMain.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.RibbonMain.SystemText.QatAddItemText = "&AddOrUpdate to Quick Access Toolbar";
            this.RibbonMain.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.RibbonMain.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.RibbonMain.SystemText.QatDialogAddButton = "&AddOrUpdate >>";
            this.RibbonMain.SystemText.QatDialogCancelButton = "Cancel";
            this.RibbonMain.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.RibbonMain.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.RibbonMain.SystemText.QatDialogOkButton = "OK";
            this.RibbonMain.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.RibbonMain.SystemText.QatDialogRemoveButton = "&Remove";
            this.RibbonMain.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.RibbonMain.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.RibbonMain.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.RibbonMain.TabGroupHeight = 14;
            this.RibbonMain.TabIndex = 0;
            this.RibbonMain.Text = "ribbonControl1";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Controls.Add(this.barSysInfo);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(1318, 87);
            // 
            // 
            // 
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 1;
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.DragDropSupport = true;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMobilePass});
            this.ribbonBar1.Location = new System.Drawing.Point(336, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(106, 84);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 2;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // barSysInfo
            // 
            this.barSysInfo.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.barSysInfo.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.barSysInfo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.barSysInfo.ContainerControlProcessDialogKey = true;
            this.barSysInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.barSysInfo.DragDropSupport = true;
            this.barSysInfo.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem4,
            this.buttonItem1,
            this.btnOper,
            this.buttonItem21,
            this.buttonItem2});
            this.barSysInfo.Location = new System.Drawing.Point(3, 0);
            this.barSysInfo.Name = "barSysInfo";
            this.barSysInfo.Size = new System.Drawing.Size(333, 84);
            this.barSysInfo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.barSysInfo.TabIndex = 1;
            // 
            // 
            // 
            this.barSysInfo.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.barSysInfo.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "系统管理";
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemClose,
            this.ToolStripMenuItemCloseAll,
            this.ToolStripMenuItemCloseOther});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 70);
            // 
            // ToolStripMenuItemClose
            // 
            this.ToolStripMenuItemClose.Name = "ToolStripMenuItemClose";
            this.ToolStripMenuItemClose.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItemClose.Text = "关闭(&C)";
            this.ToolStripMenuItemClose.Click += new System.EventHandler(this.关闭CToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemCloseAll
            // 
            this.ToolStripMenuItemCloseAll.Name = "ToolStripMenuItemCloseAll";
            this.ToolStripMenuItemCloseAll.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItemCloseAll.Text = "全部关闭(&A)";
            this.ToolStripMenuItemCloseAll.Click += new System.EventHandler(this.全部关闭AToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemCloseOther
            // 
            this.ToolStripMenuItemCloseOther.Name = "ToolStripMenuItemCloseOther";
            this.ToolStripMenuItemCloseOther.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItemCloseOther.Text = "关闭其它(&O)";
            this.ToolStripMenuItemCloseOther.Click += new System.EventHandler(this.关闭其他OToolStripMenuItem_Click);
            // 
            // AppCommandTheme
            // 
            this.AppCommandTheme.Name = "AppCommandTheme";
            // 
            // TabControlPanelMain
            // 
            this.TabControlPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlPanelMain.Location = new System.Drawing.Point(0, 0);
            this.TabControlPanelMain.Name = "TabControlPanelMain";
            this.TabControlPanelMain.Size = new System.Drawing.Size(968, 30);
            this.TabControlPanelMain.TabIndex = 1;
            // 
            // superTabControlMain
            // 
            this.superTabControlMain.CloseButtonOnTabsVisible = true;
            this.superTabControlMain.ContextMenuStrip = this.contextMenuStrip1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControlMain.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControlMain.ControlBox.MenuBox.Name = "";
            this.superTabControlMain.ControlBox.Name = "";
            this.superTabControlMain.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControlMain.ControlBox.MenuBox,
            this.superTabControlMain.ControlBox.CloseBox});
            this.superTabControlMain.Controls.Add(this.superTabControlPanelMain);
            this.superTabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlMain.Location = new System.Drawing.Point(5, 144);
            this.superTabControlMain.Name = "superTabControlMain";
            this.superTabControlMain.ReorderTabsEnabled = true;
            this.superTabControlMain.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.superTabControlMain.SelectedTabIndex = 0;
            this.superTabControlMain.Size = new System.Drawing.Size(1318, 517);
            this.superTabControlMain.TabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.superTabControlMain.TabIndex = 1;
            this.superTabControlMain.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1});
            this.superTabControlMain.Text = "superTabControl1";
            // 
            // superTabControlPanelMain
            // 
            this.superTabControlPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanelMain.Location = new System.Drawing.Point(0, 30);
            this.superTabControlPanelMain.Name = "superTabControlPanelMain";
            this.superTabControlPanelMain.Size = new System.Drawing.Size(1318, 487);
            this.superTabControlPanelMain.TabIndex = 1;
            this.superTabControlPanelMain.TabItem = this.superTabItem1;
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanelMain;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "superTabItem1";
            // 
            // timerNotify
            // 
            this.timerNotify.Interval = 1000;
            // 
            // btnMobilePass
            // 
            this.btnMobilePass.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnMobilePass.Image = global::ChangKeTec.PowerForm.Properties.Resources.classy_icons_020;
            this.btnMobilePass.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnMobilePass.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnMobilePass.Name = "btnMobilePass";
            this.btnMobilePass.SubItemsExpandWidth = 14;
            this.btnMobilePass.Text = "修改管理员密码";
            this.btnMobilePass.Click += new System.EventHandler(this.btnMobilePass_Click);
            // 
            // buttonItem4
            // 
            this.buttonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem4.Image = global::ChangKeTec.PowerForm.Properties.Resources.classy_icons_099;
            this.buttonItem4.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.buttonItem4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.SubItemsExpandWidth = 14;
            this.buttonItem4.Text = "系统管理";
            this.buttonItem4.Click += new System.EventHandler(this.btnPortal_Click);
            // 
            // buttonItem1
            // 
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.Image = global::ChangKeTec.PowerForm.Properties.Resources.classy_icons_082;
            this.buttonItem1.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.buttonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItemsExpandWidth = 14;
            this.buttonItem1.Text = "菜单管理";
            this.buttonItem1.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnOper
            // 
            this.btnOper.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnOper.Image = global::ChangKeTec.PowerForm.Properties.Resources.classy_icons_115;
            this.btnOper.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnOper.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnOper.Name = "btnOper";
            this.btnOper.SubItemsExpandWidth = 14;
            this.btnOper.Text = "组织架构";
            this.btnOper.Click += new System.EventHandler(this.btnDept_Click);
            // 
            // buttonItem21
            // 
            this.buttonItem21.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem21.Image = global::ChangKeTec.PowerForm.Properties.Resources.classy_icons_284;
            this.buttonItem21.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.buttonItem21.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem21.Name = "buttonItem21";
            this.buttonItem21.SubItemsExpandWidth = 14;
            this.buttonItem21.Text = "角色管理";
            this.buttonItem21.Click += new System.EventHandler(this.btnRole_Click);
            // 
            // buttonItem2
            // 
            this.buttonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem2.Image = global::ChangKeTec.PowerForm.Properties.Resources.classy_icons_275;
            this.buttonItem2.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.buttonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.SubItemsExpandWidth = 14;
            this.buttonItem2.Text = "操作员管理";
            this.buttonItem2.Click += new System.EventHandler(this.btnOper_Click);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(1328, 663);
            this.Controls.Add(this.superTabControlMain);
            this.Controls.Add(this.RibbonMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "常熟安通林WMS权限管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.RibbonMain.ResumeLayout(false);
            this.RibbonMain.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControlMain)).EndInit();
            this.superTabControlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl RibbonMain;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemClose;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCloseAll;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCloseOther;
        private DevComponents.DotNetBar.RibbonBar barSysInfo;
        private DevComponents.DotNetBar.ButtonItem btnOper;
        private DevComponents.DotNetBar.Command AppCommandTheme;
        private DevComponents.DotNetBar.SuperTabControlPanel TabControlPanelMain;
        private DevComponents.DotNetBar.SuperTabControl superTabControlMain;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanelMain;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private System.Windows.Forms.Timer timerNotify;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private DevComponents.DotNetBar.ButtonItem buttonItem21;
        private DevComponents.DotNetBar.ButtonItem btnMobilePass;
    }
}