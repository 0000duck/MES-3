namespace ChangKeTec.EncryptProgram
{
    partial class FormMain
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.txtEn = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDe = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btnEn = new DevComponents.DotNetBar.ButtonX();
            this.btnDe = new DevComponents.DotNetBar.ButtonX();
            this.btnClearEn = new DevComponents.DotNetBar.ButtonX();
            this.btnClearDe = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // txtEn
            // 
            // 
            // 
            // 
            this.txtEn.Border.Class = "TextBoxBorder";
            this.txtEn.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEn.Location = new System.Drawing.Point(19, 48);
            this.txtEn.Multiline = true;
            this.txtEn.Name = "txtEn";
            this.txtEn.PreventEnterBeep = true;
            this.txtEn.Size = new System.Drawing.Size(648, 122);
            this.txtEn.TabIndex = 0;
            // 
            // txtDe
            // 
            // 
            // 
            // 
            this.txtDe.Border.Class = "TextBoxBorder";
            this.txtDe.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDe.Location = new System.Drawing.Point(18, 205);
            this.txtDe.Multiline = true;
            this.txtDe.Name = "txtDe";
            this.txtDe.PreventEnterBeep = true;
            this.txtDe.Size = new System.Drawing.Size(648, 122);
            this.txtDe.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(19, 19);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(100, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "原始字符串";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(18, 176);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(100, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "加密字符串";
            // 
            // btnEn
            // 
            this.btnEn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEn.Location = new System.Drawing.Point(125, 19);
            this.btnEn.Name = "btnEn";
            this.btnEn.Size = new System.Drawing.Size(75, 23);
            this.btnEn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEn.TabIndex = 4;
            this.btnEn.Text = "加密";
            this.btnEn.Click += new System.EventHandler(this.btnEn_Click);
            // 
            // btnDe
            // 
            this.btnDe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDe.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDe.Location = new System.Drawing.Point(125, 176);
            this.btnDe.Name = "btnDe";
            this.btnDe.Size = new System.Drawing.Size(75, 23);
            this.btnDe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDe.TabIndex = 5;
            this.btnDe.Text = "解密";
            this.btnDe.Click += new System.EventHandler(this.btnDe_Click);
            // 
            // btnClearEn
            // 
            this.btnClearEn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClearEn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClearEn.Location = new System.Drawing.Point(511, 19);
            this.btnClearEn.Name = "btnClearEn";
            this.btnClearEn.Size = new System.Drawing.Size(155, 23);
            this.btnClearEn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClearEn.TabIndex = 6;
            this.btnClearEn.Text = "清除原始字符串";
            this.btnClearEn.Click += new System.EventHandler(this.btnClearEn_Click);
            // 
            // btnClearDe
            // 
            this.btnClearDe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClearDe.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClearDe.Location = new System.Drawing.Point(511, 176);
            this.btnClearDe.Name = "btnClearDe";
            this.btnClearDe.Size = new System.Drawing.Size(155, 23);
            this.btnClearDe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClearDe.TabIndex = 7;
            this.btnClearDe.Text = "清除解密字符串";
            this.btnClearDe.Click += new System.EventHandler(this.btnClearDe_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 353);
            this.Controls.Add(this.btnClearDe);
            this.Controls.Add(this.btnClearEn);
            this.Controls.Add(this.btnDe);
            this.Controls.Add(this.btnEn);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtDe);
            this.Controls.Add(this.txtEn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "字符串加密解密工具";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtEn;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDe;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btnEn;
        private DevComponents.DotNetBar.ButtonX btnDe;
        private DevComponents.DotNetBar.ButtonX btnClearEn;
        private DevComponents.DotNetBar.ButtonX btnClearDe;
    }
}

