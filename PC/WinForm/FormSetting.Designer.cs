namespace ChangKeTec.Wms.WinForm
{
    partial class FormSetting
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
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.txtSqlDb = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtSqlUser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtServer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtSqlPwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.txtWebServer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtUpdateFileName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtPowerDb = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtPort = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(316, 303);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSqlDb
            // 
            this.txtSqlDb.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSqlDb.Border.Class = "TextBoxBorder";
            this.txtSqlDb.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSqlDb.DisabledBackColor = System.Drawing.Color.White;
            this.txtSqlDb.ForeColor = System.Drawing.Color.Black;
            this.txtSqlDb.Location = new System.Drawing.Point(141, 157);
            this.txtSqlDb.Name = "txtSqlDb";
            this.txtSqlDb.PreventEnterBeep = true;
            this.txtSqlDb.Size = new System.Drawing.Size(250, 25);
            this.txtSqlDb.TabIndex = 3;
            this.txtSqlDb.Text = "ChangKeWms";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(10, 159);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(125, 23);
            this.labelX8.TabIndex = 26;
            this.labelX8.Text = "WMS数据库";
            this.labelX8.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtSqlUser
            // 
            this.txtSqlUser.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSqlUser.Border.Class = "TextBoxBorder";
            this.txtSqlUser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSqlUser.DisabledBackColor = System.Drawing.Color.White;
            this.txtSqlUser.ForeColor = System.Drawing.Color.Black;
            this.txtSqlUser.Location = new System.Drawing.Point(141, 74);
            this.txtSqlUser.Name = "txtSqlUser";
            this.txtSqlUser.PreventEnterBeep = true;
            this.txtSqlUser.Size = new System.Drawing.Size(250, 25);
            this.txtSqlUser.TabIndex = 1;
            this.txtSqlUser.Text = "sa";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(10, 76);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(125, 23);
            this.labelX7.TabIndex = 24;
            this.labelX7.Text = "用户名";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtServer
            // 
            this.txtServer.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtServer.Border.Class = "TextBoxBorder";
            this.txtServer.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtServer.DisabledBackColor = System.Drawing.Color.White;
            this.txtServer.ForeColor = System.Drawing.Color.Black;
            this.txtServer.Location = new System.Drawing.Point(141, 12);
            this.txtServer.Name = "txtServer";
            this.txtServer.PreventEnterBeep = true;
            this.txtServer.Size = new System.Drawing.Size(250, 25);
            this.txtServer.TabIndex = 0;
            this.txtServer.Text = "127.0.0.1";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(10, 107);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(125, 23);
            this.labelX4.TabIndex = 22;
            this.labelX4.Text = "密码";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtSqlPwd
            // 
            this.txtSqlPwd.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSqlPwd.Border.Class = "TextBoxBorder";
            this.txtSqlPwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSqlPwd.DisabledBackColor = System.Drawing.Color.White;
            this.txtSqlPwd.ForeColor = System.Drawing.Color.Black;
            this.txtSqlPwd.Location = new System.Drawing.Point(141, 105);
            this.txtSqlPwd.Name = "txtSqlPwd";
            this.txtSqlPwd.PasswordChar = '*';
            this.txtSqlPwd.PreventEnterBeep = true;
            this.txtSqlPwd.Size = new System.Drawing.Size(250, 25);
            this.txtSqlPwd.TabIndex = 2;
            this.txtSqlPwd.Text = "microsoft";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(10, 14);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(125, 23);
            this.labelX5.TabIndex = 21;
            this.labelX5.Text = "数据库服务器";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(141, 303);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "关闭";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtWebServer
            // 
            this.txtWebServer.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtWebServer.Border.Class = "TextBoxBorder";
            this.txtWebServer.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtWebServer.DisabledBackColor = System.Drawing.Color.White;
            this.txtWebServer.ForeColor = System.Drawing.Color.Black;
            this.txtWebServer.Location = new System.Drawing.Point(141, 241);
            this.txtWebServer.Name = "txtWebServer";
            this.txtWebServer.PreventEnterBeep = true;
            this.txtWebServer.Size = new System.Drawing.Size(250, 25);
            this.txtWebServer.TabIndex = 27;
            this.txtWebServer.Text = "http://127.0.0.1:80";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(10, 243);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(125, 23);
            this.labelX1.TabIndex = 28;
            this.labelX1.Text = "应用服务器";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtUpdateFileName
            // 
            this.txtUpdateFileName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUpdateFileName.Border.Class = "TextBoxBorder";
            this.txtUpdateFileName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUpdateFileName.DisabledBackColor = System.Drawing.Color.White;
            this.txtUpdateFileName.ForeColor = System.Drawing.Color.Black;
            this.txtUpdateFileName.Location = new System.Drawing.Point(141, 272);
            this.txtUpdateFileName.Name = "txtUpdateFileName";
            this.txtUpdateFileName.PreventEnterBeep = true;
            this.txtUpdateFileName.Size = new System.Drawing.Size(250, 25);
            this.txtUpdateFileName.TabIndex = 29;
            this.txtUpdateFileName.Text = "PcUpdate.xml";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(10, 274);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(125, 23);
            this.labelX2.TabIndex = 30;
            this.labelX2.Text = "自动更新文件名";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtPowerDb
            // 
            this.txtPowerDb.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPowerDb.Border.Class = "TextBoxBorder";
            this.txtPowerDb.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPowerDb.DisabledBackColor = System.Drawing.Color.White;
            this.txtPowerDb.ForeColor = System.Drawing.Color.Black;
            this.txtPowerDb.Location = new System.Drawing.Point(141, 187);
            this.txtPowerDb.Name = "txtPowerDb";
            this.txtPowerDb.PreventEnterBeep = true;
            this.txtPowerDb.Size = new System.Drawing.Size(250, 25);
            this.txtPowerDb.TabIndex = 31;
            this.txtPowerDb.Text = "ChangKePower";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(10, 189);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(125, 23);
            this.labelX3.TabIndex = 32;
            this.labelX3.Text = "权限数据库";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPort.Border.Class = "TextBoxBorder";
            this.txtPort.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPort.DisabledBackColor = System.Drawing.Color.White;
            this.txtPort.ForeColor = System.Drawing.Color.Black;
            this.txtPort.Location = new System.Drawing.Point(141, 43);
            this.txtPort.Name = "txtPort";
            this.txtPort.PreventEnterBeep = true;
            this.txtPort.Size = new System.Drawing.Size(250, 25);
            this.txtPort.TabIndex = 33;
            this.txtPort.Text = "1433";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(10, 45);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(125, 23);
            this.labelX6.TabIndex = 34;
            this.labelX6.Text = "端口";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // FormSetting
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(421, 337);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.txtPowerDb);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtUpdateFileName);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtWebServer);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSqlDb);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.txtSqlUser);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txtSqlPwd);
            this.Controls.Add(this.labelX5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "数据库设置";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSqlDb;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSqlUser;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtServer;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSqlPwd;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUpdateFileName;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtWebServer;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPowerDb;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPort;
        private DevComponents.DotNetBar.LabelX labelX6;
    }
}