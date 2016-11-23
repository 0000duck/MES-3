using System.ComponentModel;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.Common.ComboBox
{
    public class GroupTypeComboBox : GridComboBoxExEditControl
    {

        public GroupTypeComboBox()
        {
            DataSource = new BindingList<EnumItem>(EnumHelper.EnumToList<GroupType>());
            DisplayMember = "Desc";
            ValueMember = "Name";
        }
    }
}