using System.ComponentModel;
using ChangKeTec.Wms.Models;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.Common.ComboBox
{
    public class PartComboBox : GridComboBoxExEditControl
    {
        public PartComboBox()
        {
            DataSource = new BindingList<TA_PART>(GlobalBuffer.PartList);
            DisplayMember = "PartCode";
            ValueMember = "PartCode";
        }
    }
}