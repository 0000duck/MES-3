using System;
using System.Linq;
using System.Windows.Forms;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar;

namespace ChangKeTec.Wms.WinForm.PopUp
{
    public partial class PopupPartWithQty : Office2007Form
    {
        public TA_PART Part { get; private set; }
        public int Qty { get; private set; }
        public PopupPartWithQty()
        {
            InitializeComponent();
            ucPart1.DataSource = GlobalBuffer.PartList.ToList();

        }

        public PopupPartWithQty(string partCode,int qty)
        {
            InitializeComponent();
            ucPart1.DataSource = GlobalBuffer.PartList.ToList();
            Part = GlobalBuffer.PartList.Single(p => p.PartCode == partCode);
            ucPart1.SetValue(Part);
            intQty.Value = qty;
            Qty = qty;
        }

        private void PopupPart_Load(object sender, EventArgs e)
        {
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Part = ucPart1.Part;
            Qty = intQty.Value;
            if (string.IsNullOrEmpty(Part?.PartCode))
            {
                MessageHelper.ShowInfo("请选择零件");
                return;
            }

            if (intQty.Value <= 0)
            {
                MessageHelper.ShowInfo("数量必须大于零");
                return;
            }
            Qty = intQty.Value;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}
