namespace ChangKeTec.Wms.Common.UC
{
    partial class UcLabelDateTime
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
            this.Caption = new DevComponents.DotNetBar.LabelX();
            this.dtValue = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            ((System.ComponentModel.ISupportInitialize)(this.dtValue)).BeginInit();
            this.SuspendLayout();
            // 
            // Caption
            // 
            // 
            // 
            // 
            this.Caption.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Caption.Dock = System.Windows.Forms.DockStyle.Left;
            this.Caption.Location = new System.Drawing.Point(0, 0);
            this.Caption.Margin = new System.Windows.Forms.Padding(2);
            this.Caption.Name = "Caption";
            this.Caption.Size = new System.Drawing.Size(75, 25);
            this.Caption.TabIndex = 1;
            this.Caption.Text = "标签";
            this.Caption.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dtValue
            // 
            // 
            // 
            // 
            this.dtValue.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtValue.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtValue.ButtonDropDown.Visible = true;
            this.dtValue.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtValue.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtValue.IsPopupCalendarOpen = false;
            this.dtValue.Location = new System.Drawing.Point(75, 0);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtValue.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtValue.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtValue.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtValue.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtValue.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtValue.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtValue.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtValue.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtValue.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtValue.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtValue.MonthCalendar.DisplayMonth = new System.DateTime(2016, 8, 1, 0, 0, 0, 0);
            this.dtValue.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtValue.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtValue.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtValue.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtValue.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtValue.MonthCalendar.TodayButtonVisible = true;
            this.dtValue.Name = "dtValue";
            this.dtValue.Size = new System.Drawing.Size(152, 21);
            this.dtValue.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtValue.TabIndex = 33;
            this.dtValue.Value = new System.DateTime(2016, 8, 15, 0, 32, 37, 0);
            // 
            // UcLabelDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtValue);
            this.Controls.Add(this.Caption);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcLabelDateTime";
            this.Size = new System.Drawing.Size(227, 25);
            this.SizeChanged += new System.EventHandler(this.UcLabelDropDownList_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dtValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.LabelX Caption;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtValue;
    }
}
