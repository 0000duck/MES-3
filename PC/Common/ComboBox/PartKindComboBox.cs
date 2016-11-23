using System.ComponentModel;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.Common.ComboBox
{
    public class PartKindComboBox : GridComboBoxExEditControl
    {

        public PartKindComboBox()
        {
            DataSource = new BindingList<EnumItem>(EnumHelper.EnumToList<PartKind>());
            DisplayMember = "Desc";
            ValueMember = "Name";
        }
    }
}