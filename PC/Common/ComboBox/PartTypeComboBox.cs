using System.ComponentModel;
using System.Linq;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.Common.ComboBox
{
    public class PartTypeComboBox : GridComboBoxExEditControl
    {

        public PartTypeComboBox()
        {
            var db = EntitiesFactory.CreateSpareInstance();
            DataSource = new BindingList<TT_PART_TYPE>(db.TT_PART_TYPE.ToList());
            DisplayMember = "TypeName";
            ValueMember = "PartType";
        }

      
    }

    public class MachineTypeComboBox : GridComboBoxExEditControl
    {
        public MachineTypeComboBox()
        {
            var db = EntitiesFactory.CreateSpareInstance();
            DataSource = new BindingList<TT_MACHINE_TYPE>(db.TT_MACHINE_TYPE.ToList());
            DisplayMember = "TypeName";
            ValueMember = "MachineType";
        }
    }
}