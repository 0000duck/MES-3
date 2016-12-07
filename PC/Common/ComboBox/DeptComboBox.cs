using System.ComponentModel;
using System.Linq;
using ChangKeTec.Wms.Models;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.Common.ComboBox
{
    public class DeptComboBox : GridComboBoxExEditControl
    {
        public DeptComboBox()
        {
            var db = EntitiesFactory.CreatePowerInstance();

            DataSource = new BindingList<TS_DEPT>(db.TS_DEPT.Where(p=>p.IsLeafNode).ToList());
            DisplayMember = "DeptName";
            ValueMember = "DeptCode";
        }
    }
}