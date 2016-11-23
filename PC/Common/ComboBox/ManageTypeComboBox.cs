using System.ComponentModel;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.Common.ComboBox
{
    public class ManageTypeComboBox : GridComboBoxExEditControl
    {

        public ManageTypeComboBox()
        {
            DataSource = new BindingList<EnumItem>(EnumHelper.EnumToList<ManageType>());
            DisplayMember = "Desc";
            ValueMember = "Name";
        }
    }
}