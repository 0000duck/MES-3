using System.ComponentModel;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.Common.ComboBox
{
    public class PortalTypeComboBox : GridComboBoxExEditControl
    {

        public PortalTypeComboBox()
        {
            DataSource = new BindingList<EnumItem>(EnumHelper.EnumToList<PortalType>());
            DisplayMember = "Desc";
            ValueMember = "Name";
        }
    }
}