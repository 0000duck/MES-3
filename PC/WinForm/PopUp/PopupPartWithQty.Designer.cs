using ChangKeTec.Wms.Common.UC;

namespace ChangKeTec.Wms.WinForm.PopUp
{
    partial class PopupPartWithQty
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
            global::ChangKeTec.Wms.Models.TA_PART tA_PART1 = new global::ChangKeTec.Wms.Models.TA_PART();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnOk = new DevComponents.DotNetBar.ButtonX();
            this.intQty = new UcLabelInteger();
            this.ucPart1 = new UcPart();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_066;
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnCancel.Location = new System.Drawing.Point(262, 248);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 55;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOk.Image = global::ChangKeTec.Wms.WinForm.Properties.Resources.classy_icons_001;
            this.btnOk.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnOk.Location = new System.Drawing.Point(117, 248);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOk.TabIndex = 54;
            this.btnOk.Text = "确定";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // intQty
            // 
            this.intQty.BoxWidth = 250;
            this.intQty.LblText = "数量";
            this.intQty.LblWidth = 100;
            this.intQty.Location = new System.Drawing.Point(12, 202);
            this.intQty.MaxValue = 2147483647;
            this.intQty.MinValue = -2147483648;
            this.intQty.Name = "intQty";
            this.intQty.ReadOnly = true;
            this.intQty.Size = new System.Drawing.Size(408, 27);
            this.intQty.TabIndex = 53;
            this.intQty.Value = 6;
            // 
            // ucPart1
            // 
            this.ucPart1.Location = new System.Drawing.Point(12, 9);
            this.ucPart1.Name = "ucPart1";
            tA_PART1.MaxQty = 0;
            tA_PART1.MinQty = 0;
            tA_PART1.ErpPartCode = null;
            tA_PART1.PartDesc1 = null;
            tA_PART1.PartDesc2 = null;
            tA_PART1.BM = null;
            tA_PART1.Remark = null;
            tA_PART1.SafeQty = 0;
            tA_PART1.State = 1;
            tA_PART1.UID = 0;
            tA_PART1.Unit = null;
            this.ucPart1.Part = tA_PART1;
            this.ucPart1.Size = new System.Drawing.Size(408, 187);
            this.ucPart1.TabIndex = 58;
            // 
            // PopupPartWithQty
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(432, 281);
            this.Controls.Add(this.ucPart1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.intQty);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PopupPartWithQty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择零件";
            this.Load += new System.EventHandler(this.PopupPart_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private UcLabelInteger intQty;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnOk;
        private UcPart ucPart1;
    }
}