using System.ComponentModel;
using System.Linq;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.Common.ComboBox
{
    public class EqptComboBox : GridComboBoxExEditControl
    {

        public EqptComboBox()
        {
            var db = EntitiesFactory.CreateWmsInstance();

            DataSource = new BindingList<TA_EQUIPMENT>(db.TA_EQUIPMENT.ToList());
            DisplayMember = "EqptName";
            ValueMember = "EqptCode";
        }
    }
}