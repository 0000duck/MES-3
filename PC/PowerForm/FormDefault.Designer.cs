namespace ChangKeTec.PowerForm
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChangKeTec.PowerForm.Properties.Resources.role;
            this.ClientSize = new System.Drawing.Size(922, 617);
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDefault";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FormDefault_Load);
            this.SizeChanged += new System.EventHandler(this.FormDefault_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion
    }
}