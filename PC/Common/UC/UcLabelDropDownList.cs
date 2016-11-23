using System;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.Editors;

namespace ChangKeTec.Wms.Common.UC
{
    public partial class UcLabelDropDownList : UserControl
    {
        public UcLabelDropDownList()
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
        public string Value
        {
            get { return cbValue.SelectedText; }
            set { cbValue.SelectedText = value; }
        }

        public override string Text
        {
            get { return cbValue.Text; }
            set { cbValue.Text = value; }
        }

        public int BoxWidth { get; set; }
//        {
//            get { return cbValue.Width; }
//            set { cbValue.Width = value; }
//        }

        public int LblWidth
        {
            get { return Caption.Width; }
            set
            {
                Caption.Width = value;
                cbValue.Width = Width - Caption.Width - 3;
            }
        }

        public Boolean ReadOnly
        {
            get { return cbValue.AllowDrop;}
            set
            {
                cbValue.AllowDrop = value;
            }
        }
        
        
        public override bool Focused => cbValue.Focused;
        
        public StringAlignment LblTextAlign
        {
            get { return Caption.TextAlignment; }
            set { Caption.TextAlignment = value; }
        }

        public new bool Enabled
        {
            get { return cbValue.Enabled; }
            set { cbValue.Enabled = value; }
        }

        public object DataSource
        {
            get { return cbValue.DataSource; }
            set { cbValue.DataSource = value; }
        }

        public string DisplayMember
        {
            get { return cbValue.DisplayMember; }
            set { cbValue.DisplayMember = value; }
        }

        public string ValueMember
        {
            get { return cbValue.ValueMember; }
            set { cbValue.ValueMember = value; }
        }

        public object SelectedItem
        {
            get { return cbValue.SelectedItem;} 
            set { cbValue.SelectedItem = value; }
        }

        public object SelectedValue
        {
            get { return cbValue.SelectedValue; }

            set { cbValue.SelectedValue = value; }
        }

        public string SelectedText
        {
            get { return cbValue.SelectedText; }

            set
            {
                cbValue.SelectedText = value;
            }
        }

        public int SelectedIndex
        {
            get { return cbValue.SelectedIndex; }

            set { cbValue.SelectedIndex = value; }
        }

        public void AddItem(string text, string value)
        {
            cbValue.Items.Add(new ComboItem {Text = text, Value = value});
        }

        public delegate void SelectedIndexChangedHandler(object sender, System.EventArgs e);
        public event SelectedIndexChangedHandler SelectedIndexChanged;
        private void cbValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SelectedIndexChanged?.Invoke(sender, e);
            }
            catch { }
        }
        public delegate void SelectionChangeCommittedHandler(object sender, System.EventArgs e);
        public event SelectionChangeCommittedHandler SelectionChangeCommitted;

        private void cbValue_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                SelectionChangeCommitted?.Invoke(sender, e);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void UcLabelDropDownList_SizeChanged(object sender, EventArgs e)
        {
            cbValue.Width = Width - Caption.Width - 3;
        }
    }
}
