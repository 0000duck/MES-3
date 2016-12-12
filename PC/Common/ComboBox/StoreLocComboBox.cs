using System.ComponentModel;
using System.Linq;
using ChangKeTec.Wms.Models;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.Common.ComboBox
{
    public class StoreLocComboBox : GridComboBoxExEditControl
    {
        public StoreLocComboBox()
        {
            var db = EntitiesFactory.CreateSpareInstance();

            DataSource = new BindingList<TA_STORE_LOCATION>(db.TA_STORE_LOCATION.ToList());
            DisplayMember = "LocCode";
            ValueMember = "LocCode";
        }
    }
}