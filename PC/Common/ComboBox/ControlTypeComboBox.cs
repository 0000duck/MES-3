using System.ComponentModel;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.Common.ComboBox
{
    public class ControlTypeComboBox : GridComboBoxExEditControl
    {

        public ControlTypeComboBox()
        {
            DataSource = new BindingList<EnumItem>(EnumHelper.EnumToList<ControlType>());
            DisplayMember = "Desc";
            ValueMember = "Name";
        }
    }
}