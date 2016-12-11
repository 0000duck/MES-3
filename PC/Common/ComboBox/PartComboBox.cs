using System.ComponentModel;
using System.Linq;
using ChangKeTec.Wms.Models;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.Common.ComboBox
{
    public class PartComboBox : GridComboBoxExEditControl
    {
        public PartComboBox()
        {
            var db = EntitiesFactory.CreateSpareInstance();
            DataSource = new BindingList<TA_PART>(db.TA_PART.ToList());
            DisplayMember = "PartDesc2";
            ValueMember = "PartCode";
        }
    }
}