namespace ChangKeTec.Wms.WinForm.PopUp
{
    partial class PopupDateFilter
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
            this.btnOneYear = new DevComponents.DotNetBar.ButtonX();
            this.btnOneWeek = new DevComponents.DotNetBar.ButtonX();
            this.btnOneMonth = new DevComponents.DotNetBar.ButtonX();
            this.btnThisYear = new DevComponents.DotNetBar.ButtonX();
            this.btnThisWeek = new DevComponents.DotNetBar.ButtonX();
            this.btnThisMonth = new DevComponents.DotNetBar.ButtonX();
            this.cbFromBegin = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbToNow = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btnA = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.btnBB = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.intEndTime = new DevComponents.Editors.IntegerInput();
            this.intBeginTime = new DevComponents.Editors.IntegerInput();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.dtInputBegin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtInputEnd = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            ((System.ComponentModel.ISupportInitialize)(this.intEndTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intBeginTime)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInputBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInputEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOneYear
            // 
            this.btnOneYear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOneYear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOneYear.Location = new System.Drawing.Point(17, 103);
            this.btnOneYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOneYear.Name = "btnOneYear";
            this.btnOneYear.Size = new System.Drawing.Size(71, 18);
            this.btnOneYear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOneYear.TabIndex = 47;
            this.btnOneYear.Text = "一年内";
            this.btnOneYear.Click += new System.EventHandler(this.btnOneYear_Click);
            // 
            // btnOneWeek
            // 
            this.btnOneWeek.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOneWeek.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOneWeek.Location = new System.Drawing.Point(278, 103);
            this.btnOneWeek.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOneWeek.Name = "btnOneWeek";
            this.btnOneWeek.Size = new System.Drawing.Size(71, 18);
            this.btnOneWeek.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOneWeek.TabIndex = 46;
            this.btnOneWeek.Text = "一周内";
            this.btnOneWeek.Click += new System.EventHandler(this.btnOneWeek_Click);
            // 
            // btnOneMonth
            // 
            this.btnOneMonth.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOneMonth.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOneMonth.Location = new System.Drawing.Point(149, 103);
            this.btnOneMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOneMonth.Name = "btnOneMonth";
            this.btnOneMonth.Size = new System.Drawing.Size(71, 18);
            this.btnOneMonth.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOneMonth.TabIndex = 45;
            this.btnOneMonth.Text = "一月内";
            this.btnOneMonth.Click += new System.EventHandler(this.btnOneMonth_Click);
            // 
            // btnThisYear
            // 
            this.btnThisYear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThisYear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThisYear.Location = new System.Drawing.Point(17, 76);
            this.btnThisYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThisYear.Name = "btnThisYear";
            this.btnThisYear.Size = new System.Drawing.Size(71, 18);
            this.btnThisYear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThisYear.TabIndex = 44;
            this.btnThisYear.Text = "本年";
            this.btnThisYear.Click += new System.EventHandler(this.btnThisYear_Click);
            // 
            // btnThisWeek
            // 
            this.btnThisWeek.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThisWeek.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThisWeek.Location = new System.Drawing.Point(278, 76);
            this.btnThisWeek.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThisWeek.Name = "btnThisWeek";
            this.btnThisWeek.Size = new System.Drawing.Size(71, 18);
            this.btnThisWeek.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThisWeek.TabIndex = 43;
            this.btnThisWeek.Text = "本周";
            this.btnThisWeek.Click += new System.EventHandler(this.btnThisWeek_Click);
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThisMonth.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThisMonth.Location = new System.Drawing.Point(149, 76);
            this.btnThisMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(71, 18);
            this.btnThisMonth.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThisMonth.TabIndex = 42;
            this.btnThisMonth.Text = "本月";
            this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
            // 
            // cbFromBegin
            // 
            // 
            // 
            // 
            this.cbFromBegin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbFromBegin.Location = new System.Drawing.Point(284, 17);
            this.cbFromBegin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFromBegin.Name = "cbFromBegin";
            this.cbFromBegin.Size = new System.Drawing.Size(65, 18);
            this.cbFromBegin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbFromBegin.TabIndex = 41;
            this.cbFromBegin.Text = "从开始";
            this.cbFromBegin.CheckedChanged += new System.EventHandler(this.cbFromBegin_CheckedChanged);
            // 
            // cbToNow
            // 
            // 
            // 
            // 
            this.cbToNow.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbToNow.Location = new System.Drawing.Point(284, 43);
            this.cbToNow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbToNow.Name = "cbToNow";
            this.cbToNow.Size = new System.Drawing.Size(65, 18);
            this.cbToNow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbToNow.TabIndex = 40;
            this.cbToNow.Text = "到现在";
            this.cbToNow.CheckedChanged += new System.EventHandler(this.cbToNow_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_066;
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnCancel.Location = new System.Drawing.Point(17, 218);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 18);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOK.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_001;
            this.btnOK.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnOK.Location = new System.Drawing.Point(267, 217);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(71, 18);
            this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOK.TabIndex = 38;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(17, 43);
            this.labelX2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(56, 18);
            this.labelX2.TabIndex = 37;
            this.labelX2.Text = "结束日期";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(17, 17);
            this.labelX1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(56, 18);
            this.labelX1.TabIndex = 36;
            this.labelX1.Text = "开始日期";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(8, 16);
            this.labelX3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(56, 18);
            this.labelX3.TabIndex = 50;
            this.labelX3.Text = "开始时间";
            // 
            // btnA
            // 
            this.btnA.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnA.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnA.Location = new System.Drawing.Point(8, 47);
            this.btnA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(71, 18);
            this.btnA.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnA.TabIndex = 54;
            this.btnA.Text = "A班";
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(258, 47);
            this.buttonX2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(71, 18);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 53;
            this.buttonX2.Text = "C班";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // btnBB
            // 
            this.btnBB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBB.Location = new System.Drawing.Point(140, 47);
            this.btnBB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBB.Name = "btnBB";
            this.btnBB.Size = new System.Drawing.Size(71, 18);
            this.btnBB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBB.TabIndex = 52;
            this.btnBB.Text = "B班";
            this.btnBB.Click += new System.EventHandler(this.btnBB_Click);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(208, 16);
            this.labelX4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(56, 18);
            this.labelX4.TabIndex = 51;
            this.labelX4.Text = "结束时间";
            // 
            // intEndTime
            // 
            // 
            // 
            // 
            this.intEndTime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intEndTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intEndTime.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intEndTime.Location = new System.Drawing.Point(269, 14);
            this.intEndTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.intEndTime.MaxValue = 24;
            this.intEndTime.MinValue = 0;
            this.intEndTime.Name = "intEndTime";
            this.intEndTime.ShowUpDown = true;
            this.intEndTime.Size = new System.Drawing.Size(60, 21);
            this.intEndTime.TabIndex = 55;
            this.intEndTime.Value = 24;
            // 
            // intBeginTime
            // 
            // 
            // 
            // 
            this.intBeginTime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intBeginTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intBeginTime.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intBeginTime.Location = new System.Drawing.Point(69, 14);
            this.intBeginTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.intBeginTime.MaxValue = 23;
            this.intBeginTime.MinValue = 0;
            this.intBeginTime.Name = "intBeginTime";
            this.intBeginTime.ShowUpDown = true;
            this.intBeginTime.Size = new System.Drawing.Size(60, 21);
            this.intBeginTime.TabIndex = 56;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.intBeginTime);
            this.panelEx1.Controls.Add(this.labelX4);
            this.panelEx1.Controls.Add(this.intEndTime);
            this.panelEx1.Controls.Add(this.btnBB);
            this.panelEx1.Controls.Add(this.btnA);
            this.panelEx1.Controls.Add(this.buttonX2);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(9, 130);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(340, 79);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 57;
            // 
            // dtInputBegin
            // 
            // 
            // 
            // 
            this.dtInputBegin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtInputBegin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtInputBegin.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtInputBegin.ButtonDropDown.Visible = true;
            this.dtInputBegin.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtInputBegin.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtInputBegin.IsPopupCalendarOpen = false;
            this.dtInputBegin.Location = new System.Drawing.Point(77, 14);
            this.dtInputBegin.Margin = new System.Windows.Forms.Padding(2);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtInputBegin.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtInputBegin.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtInputBegin.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtInputBegin.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtInputBegin.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtInputBegin.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtInputBegin.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtInputBegin.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtInputBegin.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtInputBegin.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtInputBegin.MonthCalendar.DisplayMonth = new System.DateTime(2016, 2, 1, 0, 0, 0, 0);
            this.dtInputBegin.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtInputBegin.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtInputBegin.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtInputBegin.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtInputBegin.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtInputBegin.MonthCalendar.TodayButtonVisible = true;
            this.dtInputBegin.Name = "dtInputBegin";
            this.dtInputBegin.Size = new System.Drawing.Size(192, 21);
            this.dtInputBegin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtInputBegin.TabIndex = 61;
            this.dtInputBegin.TimeSelectorTimeFormat = DevComponents.Editors.DateTimeAdv.eTimeSelectorFormat.Time24H;
            // 
            // dtInputEnd
            // 
            // 
            // 
            // 
            this.dtInputEnd.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtInputEnd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtInputEnd.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtInputEnd.ButtonDropDown.Visible = true;
            this.dtInputEnd.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtInputEnd.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtInputEnd.IsPopupCalendarOpen = false;
            this.dtInputEnd.Location = new System.Drawing.Point(77, 39);
            this.dtInputEnd.Margin = new System.Windows.Forms.Padding(2);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtInputEnd.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtInputEnd.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtInputEnd.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtInputEnd.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtInputEnd.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtInputEnd.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtInputEnd.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtInputEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtInputEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtInputEnd.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtInputEnd.MonthCalendar.DisplayMonth = new System.DateTime(2016, 2, 1, 0, 0, 0, 0);
            this.dtInputEnd.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtInputEnd.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtInputEnd.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtInputEnd.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtInputEnd.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtInputEnd.MonthCalendar.TodayButtonVisible = true;
            this.dtInputEnd.Name = "dtInputEnd";
            this.dtInputEnd.Size = new System.Drawing.Size(192, 21);
            this.dtInputEnd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtInputEnd.TabIndex = 62;
            this.dtInputEnd.TimeSelectorTimeFormat = DevComponents.Editors.DateTimeAdv.eTimeSelectorFormat.Time24H;
            // 
            // PopupDateFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 246);
            this.Controls.Add(this.dtInputEnd);
            this.Controls.Add(this.dtInputBegin);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.btnOneYear);
            this.Controls.Add(this.btnOneWeek);
            this.Controls.Add(this.btnOneMonth);
            this.Controls.Add(this.btnThisYear);
            this.Controls.Add(this.btnThisWeek);
            this.Controls.Add(this.btnThisMonth);
            this.Controls.Add(this.cbFromBegin);
            this.Controls.Add(this.cbToNow);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PopupDateFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "日期筛选";
            this.Load += new System.EventHandler(this.frmQueryByDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.intEndTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intBeginTime)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtInputBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInputEnd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnOneYear;
        private DevComponents.DotNetBar.ButtonX btnOneWeek;
        private DevComponents.DotNetBar.ButtonX btnOneMonth;
        private DevComponents.DotNetBar.ButtonX btnThisYear;
        private DevComponents.DotNetBar.ButtonX btnThisWeek;
        private DevComponents.DotNetBar.ButtonX btnThisMonth;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbFromBegin;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbToNow;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnOK;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btnA;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX btnBB;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.IntegerInput intEndTime;
        private DevComponents.Editors.IntegerInput intBeginTime;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtInputBegin;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtInputEnd;
    }
}