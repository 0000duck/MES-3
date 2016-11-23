namespace WinForm.UserControls
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.InputUsableStock = new WinForm.UserControls.UcLabelDecimalInput();
            this.InputFreezeStock = new WinForm.UserControls.UcLabelDecimalInput();
            this.InputBillQty = new WinForm.UserControls.UcLabelDecimalInput();
            this.InputClosedQty = new WinForm.UserControls.UcLabelDecimalInput();
            this.InputOpenQty = new WinForm.UserControls.UcLabelDecimalInput();
            this.InputQty = new WinForm.UserControls.UcLabelDecimalInput();
            this.InputBillStock = new WinForm.UserControls.UcLabelDecimalInput();
            this.txtLocCode = new WinForm.UserControls.UcLabelTextBox();
            this.txtBatch = new WinForm.UserControls.UcLabelTextBox();
            this.txtErpCode = new WinForm.UserControls.UcLabelTextBox();
            this.txtPartName = new WinForm.UserControls.UcLabelTextBox();
            this.txtPartCode = new WinForm.UserControls.UcLabelTextBox();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.InputUsableStock);
            this.groupPanel1.Controls.Add(this.InputFreezeStock);
            this.groupPanel1.Controls.Add(this.InputBillQty);
            this.groupPanel1.Controls.Add(this.InputClosedQty);
            this.groupPanel1.Controls.Add(this.InputOpenQty);
            this.groupPanel1.Controls.Add(this.InputQty);
            this.groupPanel1.Controls.Add(this.InputBillStock);
            this.groupPanel1.Controls.Add(this.txtLocCode);
            this.groupPanel1.Controls.Add(this.txtBatch);
            this.groupPanel1.Controls.Add(this.txtErpCode);
            this.groupPanel1.Controls.Add(this.txtPartName);
            this.groupPanel1.Controls.Add(this.txtPartCode);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(780, 190);
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
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Text = "物料信息";
            // 
            // InputUsableStock
            // 
            this.InputUsableStock.BackColor = System.Drawing.Color.Transparent;
            this.InputUsableStock.ButtonVisible = false;
            this.InputUsableStock.LblText = "可用库存";
            this.InputUsableStock.LblTextAlign = System.Drawing.StringAlignment.Far;
            this.InputUsableStock.Location = new System.Drawing.Point(259, 65);
            this.InputUsableStock.Name = "InputUsableStock";
            this.InputUsableStock.ReadOnly = true;
            this.InputUsableStock.Size = new System.Drawing.Size(250, 25);
            this.InputUsableStock.TabIndex = 20;
            this.InputUsableStock.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // InputFreezeStock
            // 
            this.InputFreezeStock.BackColor = System.Drawing.Color.Transparent;
            this.InputFreezeStock.ButtonVisible = false;
            this.InputFreezeStock.LblText = "冻结库存";
            this.InputFreezeStock.LblTextAlign = System.Drawing.StringAlignment.Far;
            this.InputFreezeStock.Location = new System.Drawing.Point(515, 65);
            this.InputFreezeStock.Name = "InputFreezeStock";
            this.InputFreezeStock.ReadOnly = true;
            this.InputFreezeStock.Size = new System.Drawing.Size(250, 25);
            this.InputFreezeStock.TabIndex = 19;
            this.InputFreezeStock.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // InputBillQty
            // 
            this.InputBillQty.BackColor = System.Drawing.Color.Transparent;
            this.InputBillQty.ButtonVisible = false;
            this.InputBillQty.LblText = "订单数量";
            this.InputBillQty.LblTextAlign = System.Drawing.StringAlignment.Far;
            this.InputBillQty.Location = new System.Drawing.Point(3, 96);
            this.InputBillQty.Name = "InputBillQty";
            this.InputBillQty.ReadOnly = true;
            this.InputBillQty.Size = new System.Drawing.Size(250, 25);
            this.InputBillQty.TabIndex = 18;
            this.InputBillQty.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // InputClosedQty
            // 
            this.InputClosedQty.BackColor = System.Drawing.Color.Transparent;
            this.InputClosedQty.ButtonVisible = false;
            this.InputClosedQty.LblText = "已收数量";
            this.InputClosedQty.LblTextAlign = System.Drawing.StringAlignment.Far;
            this.InputClosedQty.Location = new System.Drawing.Point(259, 96);
            this.InputClosedQty.Name = "InputClosedQty";
            this.InputClosedQty.ReadOnly = true;
            this.InputClosedQty.Size = new System.Drawing.Size(250, 25);
            this.InputClosedQty.TabIndex = 17;
            this.InputClosedQty.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // InputOpenQty
            // 
            this.InputOpenQty.BackColor = System.Drawing.Color.Transparent;
            this.InputOpenQty.ButtonVisible = false;
            this.InputOpenQty.LblText = "待收数量";
            this.InputOpenQty.LblTextAlign = System.Drawing.StringAlignment.Far;
            this.InputOpenQty.Location = new System.Drawing.Point(515, 96);
            this.InputOpenQty.Name = "InputOpenQty";
            this.InputOpenQty.ReadOnly = true;
            this.InputOpenQty.Size = new System.Drawing.Size(250, 25);
            this.InputOpenQty.TabIndex = 16;
            this.InputOpenQty.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // InputQty
            // 
            this.InputQty.BackColor = System.Drawing.Color.Transparent;
            this.InputQty.ButtonVisible = true;
            this.InputQty.LblText = "　　数量";
            this.InputQty.LblTextAlign = System.Drawing.StringAlignment.Far;
            this.InputQty.Location = new System.Drawing.Point(259, 127);
            this.InputQty.Name = "InputQty";
            this.InputQty.ReadOnly = false;
            this.InputQty.Size = new System.Drawing.Size(250, 25);
            this.InputQty.TabIndex = 14;
            this.InputQty.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.InputQty.ButtonCustomClick += new WinForm.UserControls.UcLabelDecimalInput.ButtonCustomClickHandler(this.InputQty_ButtonCustomClick);
            // 
            // InputBillStock
            // 
            this.InputBillStock.BackColor = System.Drawing.Color.Transparent;
            this.InputBillStock.ButtonVisible = false;
            this.InputBillStock.LblText = "系统库存";
            this.InputBillStock.LblTextAlign = System.Drawing.StringAlignment.Far;
            this.InputBillStock.Location = new System.Drawing.Point(3, 65);
            this.InputBillStock.Name = "InputBillStock";
            this.InputBillStock.ReadOnly = true;
            this.InputBillStock.Size = new System.Drawing.Size(250, 25);
            this.InputBillStock.TabIndex = 13;
            this.InputBillStock.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // txtLocCode
            // 
            this.txtLocCode.BackColor = System.Drawing.Color.Transparent;
            this.txtLocCode.ButtonVisible = true;
            this.txtLocCode.LblText = "　　库位";
            this.txtLocCode.LblTextAlign = System.Drawing.StringAlignment.Far;
            this.txtLocCode.Location = new System.Drawing.Point(515, 127);
            this.txtLocCode.Multiline = false;
            this.txtLocCode.Name = "txtLocCode";
            this.txtLocCode.ReadOnly = false;
            this.txtLocCode.Size = new System.Drawing.Size(250, 25);
            this.txtLocCode.TabIndex = 8;
            this.txtLocCode.UserSystemPasswordChar = false;
            this.txtLocCode.Value = "";
            this.txtLocCode.Click += new System.EventHandler(this.txtLocCode_BtnClick);
            // 
            // txtBatch
            // 
            this.txtBatch.BackColor = System.Drawing.Color.Transparent;
            this.txtBatch.ButtonVisible = false;
            this.txtBatch.LblText = "　　批次";
            this.txtBatch.LblTextAlign = System.Drawing.StringAlignment.Far;
            this.txtBatch.Location = new System.Drawing.Point(3, 127);
            this.txtBatch.Multiline = false;
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.ReadOnly = false;
            this.txtBatch.Size = new System.Drawing.Size(250, 25);
            this.txtBatch.TabIndex = 7;
            this.txtBatch.UserSystemPasswordChar = false;
            this.txtBatch.Value = "";
            // 
            // txtErpCode
            // 
            this.txtErpCode.BackColor = System.Drawing.Color.Transparent;
            this.txtErpCode.ButtonVisible = false;
            this.txtErpCode.LblText = " ERP编码";
            this.txtErpCode.LblTextAlign = System.Drawing.StringAlignment.Far;
            this.txtErpCode.Location = new System.Drawing.Point(3, 34);
            this.txtErpCode.Multiline = false;
            this.txtErpCode.Name = "txtErpCode";
            this.txtErpCode.ReadOnly = true;
            this.txtErpCode.Size = new System.Drawing.Size(250, 25);
            this.txtErpCode.TabIndex = 6;
            this.txtErpCode.UserSystemPasswordChar = false;
            this.txtErpCode.Value = "";
            // 
            // txtPartName
            // 
            this.txtPartName.BackColor = System.Drawing.Color.Transparent;
            this.txtPartName.ButtonVisible = false;
            this.txtPartName.LblText = "物料名称";
            this.txtPartName.LblTextAlign = System.Drawing.StringAlignment.Far;
            this.txtPartName.Location = new System.Drawing.Point(259, 34);
            this.txtPartName.Multiline = false;
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.ReadOnly = true;
            this.txtPartName.Size = new System.Drawing.Size(506, 25);
            this.txtPartName.TabIndex = 5;
            this.txtPartName.UserSystemPasswordChar = false;
            this.txtPartName.Value = "";
            // 
            // txtPartCode
            // 
            this.txtPartCode.BackColor = System.Drawing.Color.Transparent;
            this.txtPartCode.ButtonVisible = true;
            this.txtPartCode.LblText = "物料编码";
            this.txtPartCode.LblTextAlign = System.Drawing.StringAlignment.Far;
            this.txtPartCode.Location = new System.Drawing.Point(3, 3);
            this.txtPartCode.Multiline = false;
            this.txtPartCode.Name = "txtPartCode";
            this.txtPartCode.ReadOnly = false;
            this.txtPartCode.Size = new System.Drawing.Size(285, 25);
            this.txtPartCode.TabIndex = 0;
            this.txtPartCode.UserSystemPasswordChar = false;
            this.txtPartCode.Value = "";
            this.txtPartCode.TxtKeyPress += new WinForm.UserControls.UcLabelTextBox.TxtKeyPressHandler(this.txtPartCode_TxtKeyPress);
            this.txtPartCode.ButtonCustomClick += new WinForm.UserControls.UcLabelTextBox.ButtonCustomClickHandler(this.txtPartCode_BtnClick);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // UcPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupPanel1);
            this.MinimumSize = new System.Drawing.Size(775, 185);
            this.Name = "UcPart";
            this.Size = new System.Drawing.Size(780, 190);
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private UcLabelTextBox txtErpCode;
        private UcLabelTextBox txtPartName;
        private UcLabelTextBox txtPartCode;
        private UcLabelTextBox txtLocCode;
        private UcLabelTextBox txtBatch;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private UcLabelDecimalInput InputUsableStock;
        private UcLabelDecimalInput InputFreezeStock;
        private UcLabelDecimalInput InputBillQty;
        private UcLabelDecimalInput InputClosedQty;
        private UcLabelDecimalInput InputOpenQty;
        private UcLabelDecimalInput InputQty;
        private UcLabelDecimalInput InputBillStock;

    }
}
