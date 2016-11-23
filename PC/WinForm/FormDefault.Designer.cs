namespace ChangKeTec.Wms.WinForm
{
    partial class FormDefault
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
            this.SuspendLayout();
            // 
            // FormDefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChangKeTec.Wms.WinForm.Properties.Resources.地球背景底图;
            this.ClientSize = new System.Drawing.Size(1047, 603);
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.Name = "FormDefault";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FormDefault_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}