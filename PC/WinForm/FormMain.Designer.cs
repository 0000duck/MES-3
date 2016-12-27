namespace ChangKeTec.Wms.WinForm
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
            this.t1g2 = new DevComponents.DotNetBar.RibbonBar();
            this.t1g2b1 = new DevComponents.DotNetBar.ButtonItem();
            this.t1g2b2 = new DevComponents.DotNetBar.ButtonItem();
            this.t1g2b3 = new DevComponents.DotNetBar.ButtonItem();
            this.btnAbout = new DevComponents.DotNetBar.ButtonItem();
            this.t1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.关闭CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部关闭AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭其它OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AppCommandTheme = new DevComponents.DotNetBar.Command(this.components);
            this.TabControlPanelMain = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabControlMain = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanelMain = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.lblNotify = new DevComponents.DotNetBar.LabelItem();
            this.lblOperName = new DevComponents.DotNetBar.LabelItem();
            this.lblVer = new DevComponents.DotNetBar.LabelItem();
            this.lblNow = new DevComponents.DotNetBar.LabelItem();
            this.timerNotify = new System.Windows.Forms.Timer(this.components);
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
            this.t1});
            this.RibbonMain.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.RibbonMain.Location = new System.Drawing.Point(5, 1);
            this.RibbonMain.Name = "RibbonMain";
            this.RibbonMain.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.RibbonMain.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.qatCustomizeItem1});
            this.RibbonMain.Size = new System.Drawing.Size(1282, 170);
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
            this.ribbonPanel1.Controls.Add(this.t1g2);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(1282, 114);
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
            // t1g2
            // 
            this.t1g2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.t1g2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.t1g2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.t1g2.ContainerControlProcessDialogKey = true;
            this.t1g2.Dock = System.Windows.Forms.DockStyle.Left;
            this.t1g2.DragDropSupport = true;
            this.t1g2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.t1g2b1,
            this.t1g2b2,
            this.t1g2b3,
            this.btnAbout});
            this.t1g2.Location = new System.Drawing.Point(3, 0);
            this.t1g2.Name = "t1g2";
            this.t1g2.Size = new System.Drawing.Size(310, 111);
            this.t1g2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.t1g2.TabIndex = 2;
            this.t1g2.Text = "当前用户";
            // 
            // 
            // 
            this.t1g2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.t1g2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // t1g2b1
            // 
            this.t1g2b1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.t1g2b1.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_283;
            this.t1g2b1.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.t1g2b1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.t1g2b1.Name = "t1g2b1";
            this.t1g2b1.SubItemsExpandWidth = 14;
            this.t1g2b1.Text = "切换用户";
            this.t1g2b1.Click += new System.EventHandler(this.btnChangeUser_Click);
            // 
            // t1g2b2
            // 
            this.t1g2b2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.t1g2b2.Enabled = false;
            this.t1g2b2.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_020;
            this.t1g2b2.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.t1g2b2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.t1g2b2.Name = "t1g2b2";
            this.t1g2b2.SubItemsExpandWidth = 14;
            this.t1g2b2.Text = "修改密码";
            this.t1g2b2.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // t1g2b3
            // 
            this.t1g2b3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.t1g2b3.Enabled = false;
            this.t1g2b3.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_231;
            this.t1g2b3.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.t1g2b3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.t1g2b3.Name = "t1g2b3";
            this.t1g2b3.SubItemsExpandWidth = 14;
            this.t1g2b3.Text = "参数刷新";
            this.t1g2b3.Click += new System.EventHandler(this.btnRefreshConfig_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnAbout.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_137;
            this.btnAbout.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnAbout.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.SubItemsExpandWidth = 14;
            this.btnAbout.Text = "关于系统";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // t1
            // 
            this.t1.Checked = true;
            this.t1.Name = "t1";
            this.t1.Panel = this.ribbonPanel1;
            this.t1.Text = "用户";
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
            this.关闭CToolStripMenuItem,
            this.全部关闭AToolStripMenuItem,
            this.关闭其它OToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 70);
            // 
            // 关闭CToolStripMenuItem
            // 
            this.关闭CToolStripMenuItem.Name = "关闭CToolStripMenuItem";
            this.关闭CToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.关闭CToolStripMenuItem.Text = "关闭(&C)";
            this.关闭CToolStripMenuItem.Click += new System.EventHandler(this.关闭CToolStripMenuItem_Click);
            // 
            // 全部关闭AToolStripMenuItem
            // 
            this.全部关闭AToolStripMenuItem.Name = "全部关闭AToolStripMenuItem";
            this.全部关闭AToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.全部关闭AToolStripMenuItem.Text = "全部关闭(&A)";
            this.全部关闭AToolStripMenuItem.Click += new System.EventHandler(this.全部关闭AToolStripMenuItem_Click);
            // 
            // 关闭其它OToolStripMenuItem
            // 
            this.关闭其它OToolStripMenuItem.Name = "关闭其它OToolStripMenuItem";
            this.关闭其它OToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.关闭其它OToolStripMenuItem.Text = "关闭其它(&O)";
            this.关闭其它OToolStripMenuItem.Click += new System.EventHandler(this.关闭其他OToolStripMenuItem_Click);
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
            this.superTabControlMain.Location = new System.Drawing.Point(5, 171);
            this.superTabControlMain.Name = "superTabControlMain";
            this.superTabControlMain.ReorderTabsEnabled = true;
            this.superTabControlMain.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.superTabControlMain.SelectedTabIndex = 0;
            this.superTabControlMain.Size = new System.Drawing.Size(1282, 444);
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
            this.superTabControlPanelMain.Size = new System.Drawing.Size(1282, 414);
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
            // metroStatusBar1
            // 
            // 
            // 
            // 
            this.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar1.ContainerControlProcessDialogKey = true;
            this.metroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroStatusBar1.DragDropSupport = true;
            this.metroStatusBar1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroStatusBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lblNotify,
            this.lblOperName,
            this.lblVer,
            this.lblNow});
            this.metroStatusBar1.Location = new System.Drawing.Point(5, 615);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(1282, 27);
            this.metroStatusBar1.TabIndex = 2;
            this.metroStatusBar1.Text = "metroStatusBar1";
            // 
            // lblNotify
            // 
            this.lblNotify.ForeColor = System.Drawing.Color.Yellow;
            this.lblNotify.Name = "lblNotify";
            this.lblNotify.Text = "新提示：0";
            this.lblNotify.Visible = false;
            // 
            // lblOperName
            // 
            this.lblOperName.ForeColor = System.Drawing.Color.White;
            this.lblOperName.Name = "lblOperName";
            this.lblOperName.Text = "登录用户：admin";
            // 
            // lblVer
            // 
            this.lblVer.ForeColor = System.Drawing.Color.White;
            this.lblVer.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.lblVer.Name = "lblVer";
            this.lblVer.Text = "Ver 1.0";
            this.lblVer.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblNow
            // 
            this.lblNow.ForeColor = System.Drawing.Color.White;
            this.lblNow.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.lblNow.Name = "lblNow";
            this.lblNow.Text = "当前时间：2016-03-22 15:08";
            this.lblNow.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // timerNotify
            // 
            this.timerNotify.Interval = 59999;
            this.timerNotify.Tick += new System.EventHandler(this.timerNow_Tick);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(1292, 644);
            this.Controls.Add(this.superTabControlMain);
            this.Controls.Add(this.RibbonMain);
            this.Controls.Add(this.metroStatusBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "长春一汽富维安道拓备件管理系统";
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
        private DevComponents.DotNetBar.RibbonTabItem t1;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 关闭CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部关闭AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭其它OToolStripMenuItem;
        private DevComponents.DotNetBar.RibbonBar t1g2;
        private DevComponents.DotNetBar.ButtonItem t1g2b1;
        private DevComponents.DotNetBar.ButtonItem t1g2b2;
        private DevComponents.DotNetBar.Command AppCommandTheme;
        private DevComponents.DotNetBar.SuperTabControlPanel TabControlPanelMain;
        private DevComponents.DotNetBar.SuperTabControl superTabControlMain;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanelMain;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.ButtonItem t1g2b3;
        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        private DevComponents.DotNetBar.LabelItem lblNotify;
        private DevComponents.DotNetBar.LabelItem lblNow;
        private System.Windows.Forms.Timer timerNotify;
        private DevComponents.DotNetBar.LabelItem lblOperName;
        private DevComponents.DotNetBar.LabelItem lblVer;
        private DevComponents.DotNetBar.ButtonItem btnAbout;
    }
}