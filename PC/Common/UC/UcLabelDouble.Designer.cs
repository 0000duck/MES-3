namespace ChangKeTec.Wms.Common.UC
{
    partial class UcLabelDouble
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
            this.inputValue = new DevComponents.Editors.DoubleInput();
            ((System.ComponentModel.ISupportInitialize)(this.inputValue)).BeginInit();
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
            this.Caption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Caption.Name = "Caption";
            this.Caption.Size = new System.Drawing.Size(75, 25);
            this.Caption.TabIndex = 2;
            this.Caption.Text = "数量";
            this.Caption.TextAlignment = System.Drawing.StringAlignment.Far;
            this.Caption.TextLineAlignment = System.Drawing.StringAlignment.Near;
            // 
            // inputValue
            // 
            // 
            // 
            // 
            this.inputValue.BackgroundStyle.Class = "DateTimeInputBackground";
            this.inputValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.inputValue.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.inputValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputValue.Increment = 1D;
            this.inputValue.Location = new System.Drawing.Point(75, 0);
            this.inputValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputValue.MaxValue = 10000000000D;
            this.inputValue.MinValue = -10000000000D;
            this.inputValue.Name = "inputValue";
            this.inputValue.ShowUpDown = true;
            this.inputValue.Size = new System.Drawing.Size(153, 21);
            this.inputValue.TabIndex = 3;
            this.inputValue.Value = 10000000000D;
            this.inputValue.ValueChanged += new System.EventHandler(this.inputValue_ValueChanged);
            // 
            // UcLabelDouble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inputValue);
            this.Controls.Add(this.Caption);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UcLabelDouble";
            this.Size = new System.Drawing.Size(228, 25);
            this.SizeChanged += new System.EventHandler(this.UcLabelInteger_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.inputValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX Caption;
        private DevComponents.Editors.DoubleInput inputValue;
    }
}
