using System;
using System.Windows.Forms;

namespace ChangKeTec.Wms.Common.UC
{
    public partial class UcLabelInteger : UserControl
    {
        public UcLabelInteger()
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
        public int Value
        {
            get { return inputValue.Value; }
            set { inputValue.Value = value; }
        }
        public int MaxValue
        {
            get { return inputValue.MaxValue; }
            set { inputValue.MaxValue = value; }
        }
        public int MinValue
        {
            get { return inputValue.MinValue; }
            set { inputValue.MinValue = value; }
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
