﻿namespace ChangKeTec.Wms.WinForm.PopUp
{
    partial class PopupAbout
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
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.lblVersion = new DevComponents.DotNetBar.LabelX();
            this.txtUpdateLog = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.linkLabelChangKeTec = new System.Windows.Forms.LinkLabel();
            this.btnSysRefresh = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.labelX3.ForeColor = System.Drawing.Color.White;
            this.labelX3.Location = new System.Drawing.Point(9, 10);
            this.labelX3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(590, 115);
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = "长春一汽富维江森自控汽车金属零部件有限公司\r\n备件管理系统\r\n";
            // 
            // lblVersion
            // 
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblVersion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblVersion.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(396, 93);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(190, 32);
            this.lblVersion.TabIndex = 8;
            this.lblVersion.Text = "labelX1";
            this.lblVersion.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtUpdateLog
            // 
            this.txtUpdateLog.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUpdateLog.Border.Class = "TextBoxBorder";
            this.txtUpdateLog.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUpdateLog.Location = new System.Drawing.Point(9, 130);
            this.txtUpdateLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUpdateLog.Multiline = true;
            this.txtUpdateLog.Name = "txtUpdateLog";
            this.txtUpdateLog.PreventEnterBeep = true;
            this.txtUpdateLog.ReadOnly = true;
            this.txtUpdateLog.Size = new System.Drawing.Size(579, 214);
            this.txtUpdateLog.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Location = new System.Drawing.Point(532, 352);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 18);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // linkLabelChangKeTec
            // 
            this.linkLabelChangKeTec.AutoSize = true;
            this.linkLabelChangKeTec.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelChangKeTec.DisabledLinkColor = System.Drawing.Color.LightGray;
            this.linkLabelChangKeTec.ForeColor = System.Drawing.Color.White;
            this.linkLabelChangKeTec.LinkColor = System.Drawing.Color.White;
            this.linkLabelChangKeTec.Location = new System.Drawing.Point(9, 358);
            this.linkLabelChangKeTec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelChangKeTec.Name = "linkLabelChangKeTec";
            this.linkLabelChangKeTec.Size = new System.Drawing.Size(269, 12);
            this.linkLabelChangKeTec.TabIndex = 12;
            this.linkLabelChangKeTec.TabStop = true;
            this.linkLabelChangKeTec.Text = "长春市畅科科技有限公司 Copyright @ 2014-2016";
            this.linkLabelChangKeTec.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelChangKeTec_LinkClicked);
            // 
            // btnSysRefresh
            // 
            this.btnSysRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSysRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSysRefresh.Location = new System.Drawing.Point(444, 352);
            this.btnSysRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnSysRefresh.Name = "btnSysRefresh";
            this.btnSysRefresh.Size = new System.Drawing.Size(56, 18);
            this.btnSysRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSysRefresh.TabIndex = 13;
            this.btnSysRefresh.Text = "更新";
            this.btnSysRefresh.Click += new System.EventHandler(this.btnSysRefresh_Click);
            // 
            // PopupAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChangKeTec.Wms.WinForm.Properties.Resources.about;
            this.ClientSize = new System.Drawing.Size(597, 380);
            this.Controls.Add(this.btnSysRefresh);
            this.Controls.Add(this.linkLabelChangKeTec);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtUpdateLog);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.labelX3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PopupAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "关于";
            this.Load += new System.EventHandler(this.PopupAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX lblVersion;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUpdateLog;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private System.Windows.Forms.LinkLabel linkLabelChangKeTec;
        private DevComponents.DotNetBar.ButtonX btnSysRefresh;
    }
}