using System.ComponentModel;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.Common.ComboBox
{
    public class WhseTypeComboBox : GridComboBoxExEditControl
    {

        public WhseTypeComboBox()
        {
            DataSource = new BindingList<EnumItem>(EnumHelper.EnumToList<WhseType>());
            DisplayMember = "Desc";
            ValueMember = "Desc";
        }
    }
}