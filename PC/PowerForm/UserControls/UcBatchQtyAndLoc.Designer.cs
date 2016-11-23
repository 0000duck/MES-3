namespace WinForm.UserControls
{
    partial class UcBatchQtyAndLoc
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
            this.txtQty = new WinForm.UserControls.UcLabelTextBox();
            this.txtLocCode = new WinForm.UserControls.UcLabelTextBox();
            this.txtBatch = new WinForm.UserControls.UcLabelTextBox();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtQty);
            this.groupPanel1.Controls.Add(this.txtLocCode);
            this.groupPanel1.Controls.Add(this.txtBatch);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(780, 61);
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
            this.groupPanel1.TabIndex = 3;
            this.groupPanel1.Text = "批次、数量、库位信息";
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.Color.Transparent;
            this.txtQty.LblText = "数量";
            this.txtQty.Location = new System.Drawing.Point(253, 3);
            this.txtQty.Multiline = false;
            this.txtQty.Name = "txtQty";
            this.txtQty.ReadOnly = false;
            this.txtQty.Size = new System.Drawing.Size(250, 25);
            this.txtQty.TabIndex = 2;
            this.txtQty.UserSystemPasswordChar = false;
            this.txtQty.Value = "";
            // 
            // txtLocCode
            // 
            this.txtLocCode.BackColor = System.Drawing.Color.Transparent;
            this.txtLocCode.LblText = "库位";
            this.txtLocCode.Location = new System.Drawing.Point(509, 3);
            this.txtLocCode.Multiline = false;
            this.txtLocCode.Name = "txtLocCode";
            this.txtLocCode.ReadOnly = false;
            this.txtLocCode.Size = new System.Drawing.Size(250, 25);
            this.txtLocCode.TabIndex = 1;
            this.txtLocCode.UserSystemPasswordChar = false;
            this.txtLocCode.Value = "";
            this.txtLocCode.ButtonCustomClick += new WinForm.UserControls.UcLabelTextBox.ButtonCustomClickHandler(this.txtLocCode_BtnClick);
            // 
            // txtBatch
            // 
            this.txtBatch.BackColor = System.Drawing.Color.Transparent;
            this.txtBatch.LblText = "批次";
            this.txtBatch.Location = new System.Drawing.Point(-3, 3);
            this.txtBatch.Multiline = false;
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.ReadOnly = false;
            this.txtBatch.Size = new System.Drawing.Size(250, 25);
            this.txtBatch.TabIndex = 0;
            this.txtBatch.UserSystemPasswordChar = false;
            this.txtBatch.Value = "";
            // 
            // UcBatchQtyAndLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupPanel1);
            this.Name = "UcBatchQtyAndLoc";
            this.Size = new System.Drawing.Size(780, 61);
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private UcLabelTextBox txtBatch;
        private UcLabelTextBox txtQty;
        private UcLabelTextBox txtLocCode;
    }
}
