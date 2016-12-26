using System.ComponentModel;
using System.Linq;
using ChangKeTec.Wms.Models;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.Common.ComboBox
{
    public class EMPComboBox : GridComboBoxExEditControl
    {
        public EMPComboBox()
        {
            var db = EntitiesFactory.CreatePowerInstance();

            DataSource = new BindingList<TS_OPERATOR>(db.TS_OPERATOR.Where(p=>p.DeptCode == GlobalBuffer.FactoryCode).ToList());
            DisplayMember = "OperName";
            ValueMember = "OperName";
        }
    }
}