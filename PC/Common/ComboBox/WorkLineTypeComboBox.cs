using System.ComponentModel;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.Common.ComboBox
{
    public class WorkLineTypeComboBox : GridComboBoxExEditControl
    {

        public WorkLineTypeComboBox()
        {
            DataSource = new BindingList<EnumItem>(EnumHelper.EnumToList<WorkLineType>());
            DisplayMember = "Desc";
            ValueMember = "Name";
        }
    }
}