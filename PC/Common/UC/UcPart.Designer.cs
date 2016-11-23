namespace ChangKeTec.Wms.Common.UC
{
    partial class UcPart
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
            this.panelColor = new System.Windows.Forms.Panel();
            this.txtPartName = new global::ChangKeTec.Wms.Common.UC.UcLabelTextBox();
            this.txtPartCode = new global::ChangKeTec.Wms.Common.UC.UcLabelTextBox();
            this.ddlCustPartCode = new global::ChangKeTec.Wms.Common.UC.UcLabelDropDownList();
            this.txtCustPartCode = new global::ChangKeTec.Wms.Common.UC.UcLabelTextBox();
            this.ddlPartCode = new global::ChangKeTec.Wms.Common.UC.UcLabelDropDownList();
            this.SuspendLayout();
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.Black;
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor.Location = new System.Drawing.Point(103, 130);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(296, 50);
            this.panelColor.TabIndex = 60;
            // 
            // txtPartName
            // 
            this.txtPartName.BackColor = System.Drawing.Color.Transparent;
            this.txtPartName.BoxWidth = 250;
            this.txtPartName.ButtonVisible = false;
            this.txtPartName.LblText = "零件名称";
            this.txtPartName.LblTextAlign = System.Drawing.StringAlignment.Far;
            this.txtPartName.LblWidth = 100;
            this.txtPartName.Location = new System.Drawing.Point(3, 72);
            this.txtPartName.Multiline = true;
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.ReadOnly = true;
            this.txtPartName.Size = new System.Drawing.Size(396, 52);
            this.txtPartName.TabIndex = 59;
            this.txtPartName.UserSystemPasswordChar = false;
            this.txtPartName.Value = "";
            // 
            // txtPartCode
            // 
            this.txtPartCode.BackColor = System.Drawing.Color.Transparent;
            this.txtPartCode.BoxWidth = 250;
            this.txtPartCode.ButtonVisible = false;
            this.txtPartCode.LblText = "零件号";
            this.txtPartCode.LblTextAlign = System.Drawing.StringAlignment.Far;
            this.txtPartCode.LblWidth = 100;
            this.txtPartCode.Location = new System.Drawing.Point(3, 39);
            this.txtPartCode.Multiline = false;
            this.txtPartCode.Name = "txtPartCode";
            this.txtPartCode.ReadOnly = true;
            this.txtPartCode.Size = new System.Drawing.Size(396, 27);
            this.txtPartCode.TabIndex = 58;
            this.txtPartCode.UserSystemPasswordChar = false;
            this.txtPartCode.Value = "";
            // 
            // ddlCustPartCode
            // 
            this.ddlCustPartCode.BoxWidth = 250;
            this.ddlCustPartCode.DataSource = null;
            this.ddlCustPartCode.DisplayMember = "Text";
            this.ddlCustPartCode.LblText = "客户零件号";
            this.ddlCustPartCode.LblTextAlign = System.Drawing.StringAlignment.Far;
            this.ddlCustPartCode.LblWidth = 100;
            this.ddlCustPartCode.Location = new System.Drawing.Point(3, 3);
            this.ddlCustPartCode.Name = "ddlCustPartCode";
            this.ddlCustPartCode.ReadOnly = false;
            this.ddlCustPartCode.SelectedIndex = -1;
            this.ddlCustPartCode.SelectedItem = null;
            this.ddlCustPartCode.SelectedText = "";
            this.ddlCustPartCode.SelectedValue = null;
            this.ddlCustPartCode.Size = new System.Drawing.Size(396, 30);
            this.ddlCustPartCode.TabIndex = 57;
            this.ddlCustPartCode.Value = "";
            this.ddlCustPartCode.ValueMember = "";
            this.ddlCustPartCode.SelectionChangeCommitted += new global::ChangKeTec.Wms.Common.UC.UcLabelDropDownList.SelectionChangeCommittedHandler(this.ddlPartCode_SelectionChangeCommitted);
            // 
            // txtCustPartCode
            // 
            this.txtCustPartCode.BackColor = System.Drawing.Color.Transparent;
            this.txtCustPartCode.BoxWidth = 250;
            this.txtCustPartCode.ButtonVisible = false;
            this.txtCustPartCode.LblText = "客户零件号";
            this.txtCustPartCode.LblTextAlign = System.Drawing.StringAlignment.Far;
            this.txtCustPartCode.LblWidth = 100;
            this.txtCustPartCode.Location = new System.Drawing.Point(3, 3);
            this.txtCustPartCode.Multiline = false;
            this.txtCustPartCode.Name = "txtCustPartCode";
            this.txtCustPartCode.ReadOnly = true;
            this.txtCustPartCode.Size = new System.Drawing.Size(396, 27);
            this.txtCustPartCode.TabIndex = 61;
            this.txtCustPartCode.UserSystemPasswordChar = false;
            this.txtCustPartCode.Value = "";
            // 
            // ddlPartCode
            // 
            this.ddlPartCode.BoxWidth = 250;
            this.ddlPartCode.DataSource = null;
            this.ddlPartCode.DisplayMember = "Text";
            this.ddlPartCode.LblText = "零件号";
            this.ddlPartCode.LblTextAlign = System.Drawing.StringAlignment.Far;
            this.ddlPartCode.LblWidth = 100;
            this.ddlPartCode.Location = new System.Drawing.Point(3, 36);
            this.ddlPartCode.Name = "ddlPartCode";
            this.ddlPartCode.ReadOnly = false;
            this.ddlPartCode.SelectedIndex = -1;
            this.ddlPartCode.SelectedItem = null;
            this.ddlPartCode.SelectedText = "";
            this.ddlPartCode.SelectedValue = null;
            this.ddlPartCode.Size = new System.Drawing.Size(396, 30);
            this.ddlPartCode.TabIndex = 62;
            this.ddlPartCode.Value = "";
            this.ddlPartCode.ValueMember = "";
            this.ddlPartCode.SelectionChangeCommitted += new global::ChangKeTec.Wms.Common.UC.UcLabelDropDownList.SelectionChangeCommittedHandler(this.ddlPartCode_SelectionChangeCommitted_1);
            // 
            // UcPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ddlPartCode);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.txtPartName);
            this.Controls.Add(this.txtPartCode);
            this.Controls.Add(this.ddlCustPartCode);
            this.Controls.Add(this.txtCustPartCode);
            this.Name = "UcPart";
            this.Size = new System.Drawing.Size(409, 186);
            this.ResumeLayout(false);

        }

        #endregion

        private UcLabelTextBox txtCustPartCode;
        private System.Windows.Forms.Panel panelColor;
        private UcLabelTextBox txtPartName;
        private UcLabelTextBox txtPartCode;
        private UcLabelDropDownList ddlCustPartCode;
        private UcLabelDropDownList ddlPartCode;
    }
}
