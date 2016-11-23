using System;
using System.Drawing;
using System.Windows.Forms;
using ChangKeTec.Wms.Models;

namespace ChangKeTec.Wms.Common.UC
{
    public partial class UcPart : UserControl
    {
        public object DataSource
        {
            set
            {
                ddlCustPartCode.DataSource = value;
                ddlCustPartCode.DisplayMember = "CustPartCode";
                ddlCustPartCode.ValueMember = "ErpPartCode";
                ddlPartCode.DataSource = value;
                ddlPartCode.DisplayMember = "ErpPartCode";
                ddlPartCode.ValueMember = "ErpPartCode";
                //                ddlPartCode.SelectedIndex = -1;
            }
        }

        public TA_PART Part
        {
            get { return _part; }
            set
            {
                _part = value;
               SetValue(value);
            }
        }

        private TA_PART _part;

        public bool Readonly
        {
            set
            {
                ddlCustPartCode.Visible = !value;
                txtCustPartCode.Visible = value;
                ddlPartCode.Visible = !value;
                txtPartCode.Visible = value;
            }
        }

        public UcPart()
        {
            InitializeComponent();
            Readonly = false;
            ddlCustPartCode.Visible = true;
            ddlPartCode.Visible = true;
            _part = new TA_PART();
            panelColor.BackColor = Color.Transparent;

        }

        public void SetValue(TA_PART part)
        {
            _part = part;
            if (part == null||part.PartCode==null) return;
            ddlPartCode.Text = part.PartCode;
            ddlPartCode.SelectedText = part.PartCode;
            ddlPartCode.SelectedItem = part;
            txtPartCode.Text = part.PartCode;
            txtPartName.Text = part.PartDesc1;
            if (part.PartDesc1 == null) return;
            if (part.PartDesc1.Contains("黑"))
            {
                panelColor.BackColor = Color.Black;
            }
            else if (part.PartDesc1.Contains("灰"))
            {
                panelColor.BackColor = Color.LightGray;
            }
            else if (part.PartDesc1.Contains("米"))
            {
                panelColor.BackColor = Color.SeaShell;
            }
            else if (part.PartDesc1.Contains("棕"))
            {
                panelColor.BackColor = Color.SaddleBrown;
            }
            else
            {
                panelColor.BackColor = Color.Transparent;
            }
        }

        private void ddlPartCode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TA_PART part = (TA_PART)ddlCustPartCode.SelectedItem;
            if(part!=null)
                SetValue(part);  
        }

        private void ddlPartCode_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            TA_PART part = (TA_PART)ddlPartCode.SelectedItem;
            if (part != null)
                SetValue(part);
        }
    }
}
