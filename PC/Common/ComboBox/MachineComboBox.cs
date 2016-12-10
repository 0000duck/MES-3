using System.ComponentModel;
using System.Linq;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.Common.ComboBox
{
    public class MachineComboBox : GridComboBoxExEditControl
    {

        public MachineComboBox()
        {
            var db = EntitiesFactory.CreateSpareInstance();

            DataSource = new BindingList<TA_MACHINE>(db.TA_MACHINE.ToList());
            DisplayMember = "EqptName";
            ValueMember = "EqptCode";
        }
    }
}