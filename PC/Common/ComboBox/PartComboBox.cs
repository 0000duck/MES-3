using System.ComponentModel;
using System.Linq;
using ChangKeTec.Wms.Models;
using DevComponents.AdvTree;
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

    public class PartComboTree : GridComboTreeEditControl
    {
        public PartComboTree()
        {
            var db = EntitiesFactory.CreateSpareInstance();
            var _list = db.TA_PART.ToList();
            DataSource = new BindingList<TA_PART>(_list);
            Columns.Clear();
            Columns.Add(new ColumnHeader("¡„º˛∫≈"));
            Columns.Add(new ColumnHeader("¡„º˛√Ë ˆ1"));
            Columns.Add(new ColumnHeader("¡„º˛√Ë ˆ2"));          

            for (int i = 0; i < _list.Count; i++)
            {
                AdvTree.Nodes[i].Cells.Add(new Cell(_list[i].PartCode));
                AdvTree.Nodes[i].Cells.Add(new Cell(_list[i].PartDesc1));
                AdvTree.Nodes[i].Cells.Add(new Cell(_list[i].PartDesc2));
            }
            DisplayMembers = "PartCode,PartDesc1,PartDesc2";
            ValueMember = "PartCode";
            foreach (DevComponents.AdvTree.ColumnHeader chdr in AdvTree.Columns)
                chdr.Width.AutoSize = true;
            DropDownWidth = 400;
        }
    }
}