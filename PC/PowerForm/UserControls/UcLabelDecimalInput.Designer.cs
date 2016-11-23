namespace WinForm.UserControls
{
    partial class UcLabelDecimalInput
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
            this.InputValue = new DevComponents.Editors.DoubleInput();
            ((System.ComponentModel.ISupportInitialize)(this.InputValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiled
            // 
            // 
            // 
            // 
            this.lblFiled.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFiled.Location = new System.Drawing.Point(3, 0);
            this.lblFiled.Name = "lblFiled";
            this.lblFiled.Size = new System.Drawing.Size(50, 25);
            this.lblFiled.TabIndex = 1;
            this.lblFiled.Text = "标签";
            this.lblFiled.TextAlignment = System.Drawing.StringAlignment.Far;
            this.lblFiled.SizeChanged += new System.EventHandler(this.lblFiled_SizeChanged);
            // 
            // InputValue
            // 
            // 
            // 
            // 
            this.InputValue.BackgroundStyle.Class = "DateTimeInputBackground";
            this.InputValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.InputValue.ButtonCalculator.Tooltip = "";
            this.InputValue.ButtonClear.Tooltip = "";
            this.InputValue.ButtonCustom.Text = "...";
            this.InputValue.ButtonCustom.Tooltip = "";
            this.InputValue.ButtonCustom2.Tooltip = "";
            this.InputValue.ButtonDropDown.Tooltip = "";
            this.InputValue.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.InputValue.ButtonFreeText.Tooltip = "";
            this.InputValue.Increment = 1;
            this.InputValue.Location = new System.Drawing.Point(56, 0);
            this.InputValue.Name = "InputValue";
            this.InputValue.Size = new System.Drawing.Size(194, 25);
            this.InputValue.TabIndex = 2;
            this.InputValue.SizeChanged += new System.EventHandler(this.InputValue_SizeChanged);
            this.InputValue.DoubleClick += new System.EventHandler(this.InputValue_DoubleClick);
            this.InputValue.ValueChanged += new System.EventHandler(this.InputValue_ValueChanged);
            this.InputValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputValue_KeyPress);
            this.InputValue.ButtonCustomClick += new System.EventHandler(this.InputValue_ButtonCustomClick);
            // 
            // UcLabelDecimalInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.InputValue);
            this.Controls.Add(this.lblFiled);
            this.Name = "UcLabelDecimalInput";
            this.Size = new System.Drawing.Size(250, 25);
            ((System.ComponentModel.ISupportInitialize)(this.InputValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblFiled;
        private DevComponents.Editors.DoubleInput InputValue;
    }
}
