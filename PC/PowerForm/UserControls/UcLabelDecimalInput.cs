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
    public partial class UcLabelDecimalInput : UserControl
    {
        public UcLabelDecimalInput()
        {
            InitializeComponent();
        }


        public override string Text
        {
            get { return InputValue.Text; }
            set { InputValue.Text = value; }
        }

        public decimal Value
        {
            get { return (decimal)InputValue.Value; }
            set { InputValue.Value = (double)value; }
        }


        public Boolean ReadOnly
        {
            get { return InputValue.IsInputReadOnly; }
            set
            {
                InputValue.IsInputReadOnly = value;
                if(value)
                    InputValue.ButtonCustom.Visible = false;
                InputValue.BackgroundStyle.BackColor = value ? System.Drawing.SystemColors.Control : Color.LightGoldenrodYellow;

            }
        }

        public override bool Focused
        {
            get
            {
                return InputValue.Focused;
            }
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
                InputValue.Left = lblFiled.Width + 3 + Margin.Left;
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
            get { return InputValue.Enabled; }
            set { InputValue.Enabled = value; }
        }

        public bool ButtonVisible
        {
            get { return InputValue.ButtonCustom.Visible; }
            set { InputValue.ButtonCustom.Visible=value; }
        }


        private void ResetTxtValueSize()
        {
            InputValue.Width = Width - lblFiled.Width - 6;
        }



        public delegate void ValueChangedHandler(object sender, System.EventArgs e);
        public event ValueChangedHandler InputValueChanged;
        private void InputValue_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                InputValueChanged(sender, e);
            }
            catch { }
        }

        public delegate void DoubleClickHandler(object sender, System.EventArgs e);
        public event DoubleClickHandler InputDoubleClick;
        private void InputValue_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                InputDoubleClick(sender, e);
            }
            catch { }
        }


        public delegate void InputKeyPressHandler(object sender, KeyPressEventArgs e);
        public event InputKeyPressHandler TxtKeyPress;
        private void InputValue_KeyPress(object sender, KeyPressEventArgs e)
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
        private void InputValue_ButtonCustomClick(object sender, EventArgs e)
        {
            try
            {
                ButtonCustomClick(sender, e);
            }
            catch { }
        }

        private void InputValue_SizeChanged(object sender, EventArgs e)
        {
            ResetTxtValueSize();
        }

        private void lblFiled_SizeChanged(object sender, EventArgs e)
        {
            ResetTxtValueSize();
        }

    }
}
