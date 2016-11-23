namespace WinForm.UserControls
{
    partial class UcLabelTextBox
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
            this.txtValue = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            this.lblFiled.TabIndex = 0;
            this.lblFiled.Text = "标签";
            this.lblFiled.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtValue
            // 
            // 
            // 
            // 
            this.txtValue.Border.Class = "TextBoxBorder";
            this.txtValue.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtValue.ButtonCustom.Text = "...";
            this.txtValue.ButtonCustom.Tooltip = "";
            this.txtValue.ButtonCustom2.Tooltip = "";
            this.txtValue.DisabledBackColor = System.Drawing.Color.White;
            this.txtValue.Location = new System.Drawing.Point(59, 0);
            this.txtValue.Name = "txtValue";
            this.txtValue.PreventEnterBeep = true;
            this.txtValue.Size = new System.Drawing.Size(191, 25);
            this.txtValue.TabIndex = 1;
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            this.txtValue.ButtonCustomClick += new System.EventHandler(this.txtValue_ButtonCustomClick);
            // 
            // UcLabelTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblFiled);
            this.Name = "UcLabelTextBox";
            this.Size = new System.Drawing.Size(250, 25);
            this.Resize += new System.EventHandler(this.UcLableTextBox_Resize);
            this.SizeChanged += new System.EventHandler(this.UcLableTextBox_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblFiled;
        private DevComponents.DotNetBar.Controls.TextBoxX txtValue;
    }
}
