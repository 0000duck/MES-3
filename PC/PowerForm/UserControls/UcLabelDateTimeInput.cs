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
    public partial class UcLabelDateTimeInput : UserControl
    {
        public UcLabelDateTimeInput()
        {
            InitializeComponent();
        }
        public DateTime Value
        {
            get { return dtInputValue.Value; }
            set { dtInputValue.Value = value; }
        }

        public override string Text
        {
            get { return dtInputValue.Text; }
            set { dtInputValue.Text = value; }
        }

        public Boolean ReadOnly
        {
            get { return dtInputValue.IsInputReadOnly; }
            set
            {
                dtInputValue.IsInputReadOnly = value;
            }
        }


        /// <summary>
        /// 重写控件获取焦点属性
        /// </summary>
        public override bool Focused
        {
            get
            {
                return dtInputValue.Focused;
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
                    lblFiled.Width = (int)strSize.Width + 6;
                }
                dtInputValue.Left = lblFiled.Width + 3 + Margin.Left;
                ResetTxtValueSize();
            }
        }



        public StringAlignment LblTextAlign
        {
            get { return lblFiled.TextAlignment; }
            //set { lblFiled.TextAlignment = value; }
        }

        public new bool Enabled
        {
            get { return dtInputValue.Enabled; }
            set { dtInputValue.Enabled = value; }
        }

        private void ResetTxtValueSize()
        {
            dtInputValue.Width = Width - lblFiled.Width - 6;
            dtInputValue.Height = Height;
        }
        public delegate void ValueChangedHandler(object sender, System.EventArgs e);
        public event ValueChangedHandler ValueChange;

        private void dtInputValue_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                ValueChange(sender, e);
            }
            catch { }
        }

        private void UcLabelDateTimeInput_SizeChanged(object sender, EventArgs e)
        {
            ResetTxtValueSize();
        }
    }
}
