using System.ComponentModel;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.Common.ComboBox
{
    public class ProjectComboBox : GridComboBoxExEditControl
    {

        public ProjectComboBox()
        {
            DataSource = new BindingList<EnumItem>(EnumHelper.EnumToList<Project>());
            DisplayMember = "Desc";
            ValueMember = "Name";
        }
    }
}