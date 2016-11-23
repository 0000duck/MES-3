using System.ComponentModel;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.Common.ComboBox
{
    public class LocTypeComboBox : GridComboBoxExEditControl
    {

        public LocTypeComboBox()
        {
            DataSource = new BindingList<EnumItem>(EnumHelper.EnumToList<LocType>());
            DisplayMember = "Desc";
            ValueMember = "Desc";
        }
    }
}