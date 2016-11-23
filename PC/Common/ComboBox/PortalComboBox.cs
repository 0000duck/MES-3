using System.ComponentModel;
using System.Linq;
using ChangKeTec.Wms.Models;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.Common.ComboBox
{
    public class PortalComboBox : GridComboBoxExEditControl
    {
        public PortalComboBox()
        {
            var db = EntitiesFactory.CreatePowerInstance();

            DataSource = new BindingList<TS_PORTAL>(db.TS_PORTAL.ToList());
            DisplayMember = "PortalCode";
            ValueMember = "PortalCode";
        }
    }
}