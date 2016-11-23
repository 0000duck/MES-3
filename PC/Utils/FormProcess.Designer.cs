
namespace ChangKeTec.Wms.Utils
{
    partial class FormProcess
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
            this.labelInfor = new System.Windows.Forms.Label();
            this.SysPBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // labelInfor
            // 
            this.labelInfor.AutoSize = true;
            this.labelInfor.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelInfor.Location = new System.Drawing.Point(35, 19);
            this.labelInfor.Name = "labelInfor";
            this.labelInfor.Size = new System.Drawing.Size(170, 21);
            this.labelInfor.TabIndex = 0;
            this.labelInfor.Text = "读取数据中,请稍候.......";
            // 
            // SysPBar
            // 
            this.SysPBar.Location = new System.Drawing.Point(33, 40);
            this.SysPBar.MarqueeAnimationSpeed = 15;
            this.SysPBar.Name = "SysPBar";
            this.SysPBar.Size = new System.Drawing.Size(537, 30);
            this.SysPBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.SysPBar.TabIndex = 4;
            // 
            // FormProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(602, 103);
            this.Controls.Add(this.SysPBar);
            this.Controls.Add(this.labelInfor);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "进度";
            this.Load += new System.EventHandler(this.FormProcess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfor;
        private System.Windows.Forms.ProgressBar SysPBar;
    }
}
