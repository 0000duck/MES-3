namespace WinForm.UserControls
{
    partial class UcLabelDateTimeInput
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFiled = new DevComponents.DotNetBar.LabelX();
            this.dtInputValue = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            ((System.ComponentModel.ISupportInitialize)(this.dtInputValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiled
            // 
            // 
            // 
            // 
            this.lblFiled.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFiled.Location = new System.Drawing.Point(0, 0);
            this.lblFiled.Name = "lblFiled";
            this.lblFiled.Size = new System.Drawing.Size(48, 25);
            this.lblFiled.TabIndex = 3;
            this.lblFiled.Text = "Label";
            this.lblFiled.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dtInputValue
            // 
            this.dtInputValue.AllowEmptyState = false;
            // 
            // 
            // 
            this.dtInputValue.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtInputValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtInputValue.ButtonClear.Tooltip = "";
            this.dtInputValue.ButtonCustom.Tooltip = "";
            this.dtInputValue.ButtonCustom2.Tooltip = "";
            this.dtInputValue.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtInputValue.ButtonDropDown.Tooltip = "";
            this.dtInputValue.ButtonDropDown.Visible = true;
            this.dtInputValue.ButtonFreeText.Tooltip = "";
            this.dtInputValue.Format = DevComponents.Editors.eDateTimePickerFormat.Long;
            this.dtInputValue.IsPopupCalendarOpen = false;
            this.dtInputValue.Location = new System.Drawing.Point(54, 0);
            // 
            // 
            // 
            this.dtInputValue.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtInputValue.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtInputValue.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtInputValue.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtInputValue.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtInputValue.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtInputValue.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtInputValue.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtInputValue.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtInputValue.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtInputValue.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtInputValue.MonthCalendar.DisplayMonth = new System.DateTime(2015, 12, 1, 0, 0, 0, 0);
            this.dtInputValue.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtInputValue.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtInputValue.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtInputValue.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtInputValue.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtInputValue.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtInputValue.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtInputValue.MonthCalendar.TodayButtonVisible = true;
            this.dtInputValue.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtInputValue.Name = "dtInputValue";
            this.dtInputValue.Size = new System.Drawing.Size(193, 25);
            this.dtInputValue.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtInputValue.TabIndex = 5;
            this.dtInputValue.TimeSelectorTimeFormat = DevComponents.Editors.DateTimeAdv.eTimeSelectorFormat.Time24H;
            this.dtInputValue.ValueChanged += new System.EventHandler(this.dtInputValue_ValueChanged);
            // 
            // UcLabelDateTimeInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dtInputValue);
            this.Controls.Add(this.lblFiled);
            this.MaximumSize = new System.Drawing.Size(2000, 25);
            this.MinimumSize = new System.Drawing.Size(100, 25);
            this.Name = "UcLabelDateTimeInput";
            this.Size = new System.Drawing.Size(250, 25);
            this.SizeChanged += new System.EventHandler(this.UcLabelDateTimeInput_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dtInputValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblFiled;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtInputValue;
    }
}
