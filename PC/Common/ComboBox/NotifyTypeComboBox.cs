using System.ComponentModel;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.Common.ComboBox
{
    public class NotifyTypeComboBox : GridComboBoxExEditControl
    {

        public NotifyTypeComboBox()
        {
            DataSource = new BindingList<EnumItem>(EnumHelper.EnumToList<NotifyType>());
            DisplayMember = "Desc";
            ValueMember = "Value";
        }
    }
}