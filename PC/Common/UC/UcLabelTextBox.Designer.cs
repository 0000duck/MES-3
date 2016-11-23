namespace ChangKeTec.Wms.Common.UC
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
            this.Caption = new DevComponents.DotNetBar.LabelX();
            this.txtValue = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            this.Caption.Size = new System.Drawing.Size(80, 25);
            this.Caption.TabIndex = 0;
            this.Caption.Text = "标签";
            this.Caption.TextAlignment = System.Drawing.StringAlignment.Far;
            this.Caption.TextLineAlignment = System.Drawing.StringAlignment.Near;
            // 
            // txtValue
            // 
            // 
            // 
            // 
            this.txtValue.Border.Class = "TextBoxBorder";
            this.txtValue.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtValue.ButtonCustom.Text = "...";
            this.txtValue.DisabledBackColor = System.Drawing.Color.White;
            this.txtValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtValue.Location = new System.Drawing.Point(80, 0);
            this.txtValue.Margin = new System.Windows.Forms.Padding(2);
            this.txtValue.Name = "txtValue";
            this.txtValue.PreventEnterBeep = true;
            this.txtValue.Size = new System.Drawing.Size(176, 21);
            this.txtValue.TabIndex = 1;
            this.txtValue.ButtonCustomClick += new System.EventHandler(this.txtValue_ButtonCustomClick);
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // UcLabelTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.Caption);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UcLabelTextBox";
            this.Size = new System.Drawing.Size(256, 25);
            this.SizeChanged += new System.EventHandler(this.UcLabelTextBox_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX Caption;
        private DevComponents.DotNetBar.Controls.TextBoxX txtValue;
    }
}
