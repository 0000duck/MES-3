using System.ComponentModel;
using System.Linq;
using ChangKeTec.Wms.Models;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.Common.ComboBox
{
    public class UnitComboBox : GridComboBoxExEditControl
    {
        public UnitComboBox()
        {
            var db = EntitiesFactory.CreateWmsInstance();

            DataSource = new BindingList<TA_UNIT>(db.TA_UNIT.ToList());
            DisplayMember = "Unit";
            ValueMember = "Unit";
        }
    }
}