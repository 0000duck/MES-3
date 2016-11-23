using System.ComponentModel;
using System.Linq;
using ChangKeTec.Wms.Models;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.Common.ComboBox
{
    public class MenuComboBox : GridComboBoxExEditControl
    {
        public MenuComboBox()
        {
            var db = EntitiesFactory.CreatePowerInstance();

            DataSource = new BindingList<TA_MENU>(db.TA_MENU.ToList());
            DisplayMember = "MenuText";
            ValueMember = "MenuCode";
        }
    }
}