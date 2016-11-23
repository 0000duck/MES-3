namespace ChangKeTec.PowerForm
{
    partial class FormModifyPassword
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
            this.btnModify = new DevComponents.DotNetBar.ButtonX();
            this.txtOldPwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNewPwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNewPwd2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // btnModify
            // 
            this.btnModify.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnModify.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnModify.Location = new System.Drawing.Point(85, 105);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnModify.TabIndex = 0;
            this.btnModify.Text = "修改";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // txtOldPwd
            // 
            // 
            // 
            // 
            this.txtOldPwd.Border.Class = "TextBoxBorder";
            this.txtOldPwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOldPwd.Location = new System.Drawing.Point(85, 12);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.PasswordChar = '*';
            this.txtOldPwd.PreventEnterBeep = true;
            this.txtOldPwd.Size = new System.Drawing.Size(200, 25);
            this.txtOldPwd.TabIndex = 1;
            // 
            // txtNewPwd
            // 
            // 
            // 
            // 
            this.txtNewPwd.Border.Class = "TextBoxBorder";
            this.txtNewPwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNewPwd.Location = new System.Drawing.Point(85, 43);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.PreventEnterBeep = true;
            this.txtNewPwd.Size = new System.Drawing.Size(200, 25);
            this.txtNewPwd.TabIndex = 2;
            // 
            // txtNewPwd2
            // 
            // 
            // 
            // 
            this.txtNewPwd2.Border.Class = "TextBoxBorder";
            this.txtNewPwd2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNewPwd2.Location = new System.Drawing.Point(85, 74);
            this.txtNewPwd2.Name = "txtNewPwd2";
            this.txtNewPwd2.PasswordChar = '*';
            this.txtNewPwd2.PreventEnterBeep = true;
            this.txtNewPwd2.Size = new System.Drawing.Size(200, 25);
            this.txtNewPwd2.TabIndex = 3;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(4, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "原密码";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX1.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(4, 45);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "新密码";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(210, 105);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormModifyPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 139);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtNewPwd2);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.txtOldPwd);
            this.Controls.Add(this.btnModify);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormModifyPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.FormModifyPassword_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtOldPwd;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNewPwd;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNewPwd2;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnModify;
    }
}