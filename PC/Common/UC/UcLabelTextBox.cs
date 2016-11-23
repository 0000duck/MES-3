using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChangKeTec.Wms.Common.UC
{
    public partial class UcLabelTextBox : UserControl
    {
        public UcLabelTextBox()
        {
            InitializeComponent();
            txtValue.Width = Width - Caption.Width - 3;
        }

        public string LblText
        {
            get { return Caption.Text; }
            set
            {
                Caption.Text = value;
//                using (var g = this.CreateGraphics())
//                {
//                    var strSize = g.MeasureString(Caption.Text, Caption.Font);
//                    Caption.Width = (int)strSize.Width + 6;
//                }
            }
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

        public int BoxWidth { get; set; }
//            get { return txtValue.Width; }
//            set { txtValue.Width = value; }
        
        public int LblWidth
        {
            get { return Caption.Width; }
            set
            {
                Caption.Width = value;
                txtValue.Width = Width - Caption.Width - 3;
            }
        }
        public Boolean ReadOnly
        {
            get { return txtValue.ReadOnly; }
            set
            {
                txtValue.ReadOnly = value;
                if (value)
                    txtValue.ButtonCustom.Visible = false;
                
            }
        }

        public Boolean UserSystemPasswordChar
        {
            get { return txtValue.UseSystemPasswordChar; }
            set { txtValue.UseSystemPasswordChar = value; }
        }

        public override bool Focused => txtValue.Focused;

        public bool Multiline
        {
            get { return txtValue.Multiline; }
            set { txtValue.Multiline = value; }
        }




        public StringAlignment LblTextAlign
        {
            get { return Caption.TextAlignment; }
            set { Caption.TextAlignment = value; }
        }

        public new bool Enabled
        {
            get { return txtValue.Enabled; }
            set { txtValue.Enabled = value; }
        }

        public bool ButtonVisible
        {
            get { return txtValue.ButtonCustom.Visible; }
            set { txtValue.ButtonCustom.Visible = value; }
        }





        public delegate void TextChangedHandler(object sender, System.EventArgs e);
        public event TextChangedHandler TxtTextChanged;
        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TxtTextChanged?.Invoke(sender, e);
            }
            catch { }
        }

        public delegate void DoubleClickHandler(object sender, System.EventArgs e);
        public event DoubleClickHandler TxtDoubleClick;
        private void txtValue_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                TxtDoubleClick?.Invoke(sender, e);
            }
            catch { }
        }


        public delegate void TxtKeyPressHandler(object sender, KeyPressEventArgs e);
        public event TxtKeyPressHandler TxtKeyPress;
        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter) return;
            try
            {
                TxtKeyPress?.Invoke(sender, e);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        public delegate void ButtonCustomClickHandler(object sender, System.EventArgs e);
        public event ButtonCustomClickHandler ButtonCustomClick;
        private void txtValue_ButtonCustomClick(object sender, EventArgs e)
        {
            try
            {
                ButtonCustomClick?.Invoke(sender, e);
            }
            catch { }
        }

        private void UcLabelTextBox_SizeChanged(object sender, EventArgs e)
        {
            txtValue.Width = Width - Caption.Width - 3;
        }
    }
}

