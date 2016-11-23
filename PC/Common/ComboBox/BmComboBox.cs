using System.ComponentModel;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.Common.ComboBox
{
    public class BmComboBox : GridComboBoxExEditControl
    {

        public BmComboBox()
        {
            DataSource = new BindingList<EnumItem>(EnumHelper.EnumToList<PartBuyOrMake>());
            DisplayMember = "Desc";
            ValueMember = "Name";
        }
    }
}