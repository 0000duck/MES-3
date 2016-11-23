using System;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.Editors;

namespace ChangKeTec.Wms.Common.UC
{
    public partial class UcLabelDateTime : UserControl
    {
        public UcLabelDateTime()
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
        public DateTime Value
        {
            get { return dtValue.Value; }
            set { dtValue.Value = value; }
        }

        public override string Text
        {
            get { return dtValue.Text; }
            set { dtValue.Text = value; }
        }


        public string FormatString
        {
            get { return dtValue.CustomFormat; }
            set { dtValue.CustomFormat = value; }
        }

        public int BoxWidth { get; set; }
//        {
//            get { return dtValue.Width; }
//            set { dtValue.Width = value; }
//        }

        public int LblWidth
        {
            get { return Caption.Width; }
            set
            {
                Caption.Width = value;
                dtValue.Width = Width - Caption.Width - 3;
            }
        }

        public bool ReadOnly
        {
            get { return dtValue.AllowDrop;}
            set
            {
                dtValue.AllowDrop = value;
            }
        }
        
        
        public override bool Focused => dtValue.Focused;
        
        public StringAlignment LblTextAlign
        {
            get { return Caption.TextAlignment; }
            set { Caption.TextAlignment = value; }
        }

        public new bool Enabled
        {
            get { return dtValue.Enabled; }
            set { dtValue.Enabled = value; }
        }
        


        private void UcLabelDropDownList_SizeChanged(object sender, EventArgs e)
        {
            dtValue.Width = Width - Caption.Width - 3;
        }
    }
}
