using System.ComponentModel;
using System.Linq;
using ChangKeTec.Wms.Models;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.Common.ComboBox
{
    public class StoreGroupComboBox : GridComboBoxExEditControl
    {
        public StoreGroupComboBox()
        {
            var db = EntitiesFactory.CreateWmsInstance();

            DataSource = new BindingList<TA_STORE_GROUP>(db.TA_STORE_GROUP.ToList());
            DisplayMember = "GroupName";
            ValueMember = "GroupCode";
        }
    }
}