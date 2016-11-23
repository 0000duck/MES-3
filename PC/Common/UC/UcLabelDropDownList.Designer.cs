namespace ChangKeTec.Wms.Common.UC
{
    partial class UcLabelDropDownList
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
            this.Caption = new DevComponents.DotNetBar.LabelX();
            this.cbValue = new DevComponents.DotNetBar.Controls.ComboBoxEx();
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
            this.Caption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Caption.Name = "Caption";
            this.Caption.Size = new System.Drawing.Size(75, 25);
            this.Caption.TabIndex = 1;
            this.Caption.Text = "标签";
            this.Caption.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cbValue
            // 
            this.cbValue.DisplayMember = "Text";
            this.cbValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValue.FormattingEnabled = true;
            this.cbValue.ItemHeight = 19;
            this.cbValue.Location = new System.Drawing.Point(75, 0);
            this.cbValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbValue.Name = "cbValue";
            this.cbValue.Size = new System.Drawing.Size(152, 25);
            this.cbValue.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbValue.TabIndex = 32;
            this.cbValue.SelectedIndexChanged += new System.EventHandler(this.cbValue_SelectedIndexChanged);
            this.cbValue.SelectionChangeCommitted += new System.EventHandler(this.cbValue_SelectionChangeCommitted);
            // 
            // UcLabelDropDownList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbValue);
            this.Controls.Add(this.Caption);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcLabelDropDownList";
            this.Size = new System.Drawing.Size(227, 25);
            this.SizeChanged += new System.EventHandler(this.UcLabelDropDownList_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.LabelX Caption;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbValue;
    }
}
