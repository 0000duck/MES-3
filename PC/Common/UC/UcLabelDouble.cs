using System;
using System.Windows.Forms;

namespace ChangKeTec.Wms.Common.UC
{
    public partial class UcLabelDouble : UserControl
    {
        public UcLabelDouble()
        {
            InitializeComponent();
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
        public decimal Value
        {
            get { return Convert.ToDecimal(Math.Round(inputValue.Value,4)); }
            set { inputValue.Value = (double)value; }
        }
        public decimal MaxValue
        {
            get { return Convert.ToDecimal(Math.Round(inputValue.MaxValue, 4)); }
            set { inputValue.MaxValue = (double)value; }
        }
        public decimal MinValue
        {
            get { return Convert.ToDecimal(Math.Round(inputValue.MinValue, 4)); }
            set { inputValue.MinValue = (double)value; }
        }

        public int LblWidth
        {
            get { return Caption.Width; }
            set
            {
                Caption.Width = value;
                inputValue.Width = Width - Caption.Width - 3;
            }
        }

        public int BoxWidth { get; set; }
//        {
//            get { return inputValue.Width; }
//            set { inputValue.Width = value; }
//        }

        public Boolean ReadOnly
        {
            get { return inputValue.ShowUpDown; }
            set
            {
                inputValue.ShowUpDown = value;
                inputValue.Enabled = value;
            }
        }

        public override bool Focused => inputValue.Focused;



        public delegate void ValueChangedHandler(object sender, System.EventArgs e);
        public event ValueChangedHandler ValueChanged;

        private void inputValue_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                ValueChanged?.Invoke(sender, e);
            }
            catch { }
        }

        private void UcLabelInteger_SizeChanged(object sender, EventArgs e)
        {
            inputValue.Width = Width - Caption.Width - 3;
        }
    }
}
