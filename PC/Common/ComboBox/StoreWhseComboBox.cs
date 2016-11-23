using System.ComponentModel;
using System.Linq;
using ChangKeTec.Wms.Models;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.Common.ComboBox
{
    public class StoreWhseComboBox : GridComboBoxExEditControl
    {
        public StoreWhseComboBox()
        {
            var db = EntitiesFactory.CreateWmsInstance();

            DataSource = new BindingList<TA_STORE_WHSE>(db.TA_STORE_WHSE.ToList());
            DisplayMember = "WhseName";
            ValueMember = "WhseCode";
        }
    }
}