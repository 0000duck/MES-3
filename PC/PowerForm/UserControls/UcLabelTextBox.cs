using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForm.UserControls
{
    public partial class UcLabelTextBox : UserControl
    {
        public UcLabelTextBox()
        {
            InitializeComponent();
        }

        public string Value
        {
            get { return txtValue.Text; }
            set { txtValue.Text = value; }
        }

        public override string Text
        {
            get { return txtValue.Text; }
            set { txtValue.Text = value; }
        }

        public Boolean ReadOnly
        {
            get { return txtValue.ReadOnly; }
            set
            {
                txtValue.ReadOnly = value;
                if(value)
                    txtValue.ButtonCustom.Visible = false;
            }
        }

        public Boolean UserSystemPasswordChar
        {
            get { return txtValue.UseSystemPasswordChar; }
            set { txtValue.UseSystemPasswordChar = value; }
        }

        public override bool Focused
        {
            get
            {
                return txtValue.Focused;
            }
        }

        public bool Multiline
        {
            get { return txtValue.Multiline; }
            set { txtValue.Multiline = value; }
        }

        public string LblText
        {
            get { return lblFiled.Text; }
            set
            {
                lblFiled.Text = value;
                using (var g = this.CreateGraphics())
                {
                    var strSize = g.MeasureString(lblFiled.Text, lblFiled.Font);
                    lblFiled.Width = (int)strSize.Width+6;
                }
                txtValue.Left = lblFiled.Width + 3 + Margin.Left;
                ResetTxtValueSize();
            }
        }



        public StringAlignment LblTextAlign
        {
            get { return lblFiled.TextAlignment; }
            set { lblFiled.TextAlignment = value; }
        }

        public new bool Enabled
        {
            get { return txtValue.Enabled; }
            set { txtValue.Enabled = value; }
        }

        public bool ButtonVisible
        {
            get { return txtValue.ButtonCustom.Visible; }
            set { txtValue.ButtonCustom.Visible=value; }
        }


        private void UcLableTextBox_SizeChanged(object sender, EventArgs e)
        {
            ResetTxtValueSize();
        }

        private void ResetTxtValueSize()
        {
            txtValue.Width = Width - lblFiled.Width - 6;
            txtValue.Height = Height;
        }

        private void UcLableTextBox_Resize(object sender, EventArgs e)
        {
            ResetTxtValueSize();
        }


        public delegate void TextChangedHandler(object sender, System.EventArgs e);
        public event TextChangedHandler TxtTextChanged;
        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TxtTextChanged(sender, e);
            }
            catch { }
        }

        public delegate void DoubleClickHandler(object sender, System.EventArgs e);
        public event DoubleClickHandler TxtDoubleClick;
        private void txtValue_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                TxtDoubleClick(sender, e);
            }
            catch { }
        }


        public delegate void TxtKeyPressHandler(object sender, KeyPressEventArgs e);
        public event TxtKeyPressHandler TxtKeyPress;
        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar!=(char)Keys.Enter)return;
            try
            {
                TxtKeyPress(sender, e);
            }
            catch { }
        }

        
        public delegate void ButtonCustomClickHandler(object sender, System.EventArgs e);
        public event ButtonCustomClickHandler ButtonCustomClick;
        private void txtValue_ButtonCustomClick(object sender, EventArgs e)
        {
            try
            {
                ButtonCustomClick(sender, e);
            }
            catch { }
        }
    }
}

