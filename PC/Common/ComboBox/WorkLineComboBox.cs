using System.ComponentModel;
using System.Linq;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.Common.ComboBox
{
    public class WorkLineComboBox : GridComboBoxExEditControl
    {

        public WorkLineComboBox()
        {
            var db = EntitiesFactory.CreateWmsInstance();

            DataSource = new BindingList<TA_WORKLINE>(db.TA_WORKLINE.ToList());
            DisplayMember = "WorkLineName";
            ValueMember = "WorkLineCode";
        }
    }
}