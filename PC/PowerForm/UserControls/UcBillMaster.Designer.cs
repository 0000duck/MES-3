namespace WinForm.UserControls
{
    partial class UcBillMaster
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtErpBillNum = new WinForm.UserControls.UcLabelTextBox();
            this.txtRemark = new WinForm.UserControls.UcLabelTextBox();
            this.txtVender = new WinForm.UserControls.UcLabelTextBox();
            this.txtCustomer = new WinForm.UserControls.UcLabelTextBox();
            this.txtBillNum = new WinForm.UserControls.UcLabelTextBox();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtErpBillNum);
            this.groupPanel1.Controls.Add(this.txtRemark);
            this.groupPanel1.Controls.Add(this.txtVender);
            this.groupPanel1.Controls.Add(this.txtCustomer);
            this.groupPanel1.Controls.Add(this.txtBillNum);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(794, 157);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 4;
            this.groupPanel1.Text = "单据信息";
            // 
            // txtErpBillNum
            // 
            this.txtErpBillNum.BackColor = System.Drawing.Color.Transparent;
            this.txtErpBillNum.ButtonVisible = false;
            this.txtErpBillNum.LblText = " ERP编号";
            this.txtErpBillNum.LblTextAlign = System.Drawing.StringAlignment.Far;
            this.txtErpBillNum.Location = new System.Drawing.Point(17, 34);
            this.txtErpBillNum.Multiline = false;
            this.txtErpBillNum.Name = "txtErpBillNum";
            this.txtErpBillNum.ReadOnly = true;
            this.txtErpBillNum.Size = new System.Drawing.Size(250, 25);
            this.txtErpBillNum.TabIndex = 20;
            this.txtErpBillNum.UserSystemPasswordChar = false;
            this.txtErpBillNum.Value = "";
            // 
            // txtRemark
            // 
            this.txtRemark.BackColor = System.Drawing.Color.Transparent;
            this.txtRemark.ButtonVisible = false;
            this.txtRemark.LblText = "　　备注";
            this.txtRemark.LblTextAlign = System.Drawing.StringAlignment.Far;
            this.txtRemark.Location = new System.Drawing.Point(17, 65);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ReadOnly = false;
            this.txtRemark.Size = new System.Drawing.Size(762, 60);
            this.txtRemark.TabIndex = 19;
            this.txtRemark.UserSystemPasswordChar = false;
            this.txtRemark.Value = "";
            // 
            // txtVender
            // 
            this.txtVender.BackColor = System.Drawing.Color.Transparent;
            this.txtVender.ButtonVisible = false;
            this.txtVender.LblText = "　供应商";
            this.txtVender.LblTextAlign = System.Drawing.StringAlignment.Far;
            this.txtVender.Location = new System.Drawing.Point(273, 34);
            this.txtVender.Multiline = false;
            this.txtVender.Name = "txtVender";
            this.txtVender.ReadOnly = true;
            this.txtVender.Size = new System.Drawing.Size(250, 25);
            this.txtVender.TabIndex = 18;
            this.txtVender.UserSystemPasswordChar = false;
            this.txtVender.Value = "";
            // 
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.Color.Transparent;
            this.txtCustomer.ButtonVisible = false;
            this.txtCustomer.LblText = "　　客户";
            this.txtCustomer.LblTextAlign = System.Drawing.StringAlignment.Far;
            this.txtCustomer.Location = new System.Drawing.Point(529, 34);
            this.txtCustomer.Multiline = false;
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(250, 25);
            this.txtCustomer.TabIndex = 17;
            this.txtCustomer.UserSystemPasswordChar = false;
            this.txtCustomer.Value = "";
            // 
            // txtBillNum
            // 
            this.txtBillNum.BackColor = System.Drawing.Color.Transparent;
            this.txtBillNum.ButtonVisible = true;
            this.txtBillNum.LblText = "订单编号";
            this.txtBillNum.LblTextAlign = System.Drawing.StringAlignment.Far;
            this.txtBillNum.Location = new System.Drawing.Point(17, 3);
            this.txtBillNum.Multiline = false;
            this.txtBillNum.Name = "txtBillNum";
            this.txtBillNum.ReadOnly = false;
            this.txtBillNum.Size = new System.Drawing.Size(285, 25);
            this.txtBillNum.TabIndex = 16;
            this.txtBillNum.UserSystemPasswordChar = false;
            this.txtBillNum.Value = "";
            this.txtBillNum.TxtKeyPress += new WinForm.UserControls.UcLabelTextBox.TxtKeyPressHandler(this.txtBillNum_TxtKeyPress);
            this.txtBillNum.ButtonCustomClick += new WinForm.UserControls.UcLabelTextBox.ButtonCustomClickHandler(this.txtBillNum_BtnClick);
            // 
            // UcBillMaster
            // 
            this.Controls.Add(this.groupPanel1);
            this.Name = "UcBillMaster";
            this.Size = new System.Drawing.Size(794, 157);
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private UcLabelTextBox txtErpBillNum;
        private UcLabelTextBox txtRemark;
        private UcLabelTextBox txtVender;
        private UcLabelTextBox txtCustomer;
        private UcLabelTextBox txtBillNum;

    }
}
