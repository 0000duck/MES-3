using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChangKeTec.Wms.Controllers.Bill;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using ChangKeTec.Wms.WinForm.BaseData;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.WinForm.Manage
{
    // 状态  枚举值 的下拉列表 跟   取值 出处
    //  单据的 编码规则不能为空  最后时间值 必须在某个范围。时间为空值 处理
    public partial class FormNotify : Office2007Form
    {
        private SpareEntities _db = EntitiesFactory.CreateWmsInstance();
        private List<TL_NOTIFY> _dataList;
        private TL_NOTIFY _selectedData;
        public FormNotify()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            _selectedData = new TL_NOTIFY();
            _dataList = NotifyController.GetNewList(_db, GlobalVar.NotifytypeList);
            bs.DataSource = _dataList;
            grid.PrimaryGrid.DataSource = bs;
            bn.BindingSource = bs;
            grid.PrimaryGrid.ReadOnly = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            grid.PrimaryGrid.Columns[1].EditorType = typeof(BillStateComboBox);
            grid.PrimaryGrid.Columns[3].EditorType = typeof(NotifyTypeComboBox);
            foreach (GridColumn column in grid.PrimaryGrid.Columns)
            {
                column.MinimumWidth = 100;
            }
        }
        private  void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageHelper.ShowQuestion("确定要关闭所有提示吗?") != DialogResult.Yes) return;

            NotifyController.CloseNotifyList(_db, GlobalVar.Oper.OperName, _dataList);
            EntitiesFactory.SaveDb(_db);
            Init();
        }


        private void grid_MasterGridCellActivated(object sender, DevComponents.DotNetBar.SuperGrid.GridCellActivatedEventArgs e)
        {
            if (e.NewActiveCell.ColumnIndex < 0 || e.NewActiveCell.RowIndex < 0) return;
            _selectedData = (TL_NOTIFY)e.NewActiveCell.GridRow.DataItem;
            prop.SelectedObject = _selectedData;
        }


        private void grid_DataError(object sender, DevComponents.DotNetBar.SuperGrid.GridDataErrorEventArgs e)
        {
            grid.PrimaryGrid.ActiveCell.CancelEdit();
        }

        private void grid_CellDoubleClick(object sender, DevComponents.DotNetBar.SuperGrid.GridCellDoubleClickEventArgs e)
        {
            if (e.GridCell.ColumnIndex < 0 || e.GridCell.RowIndex < 0) return;
            _selectedData = (TL_NOTIFY) e.GridCell.GridRow.DataItem;
            CloseNotify();
        }

        private void CloseNotify()
        {
            if (_selectedData==null||_selectedData.UID == 0) return;
            NotifyController.CloseNotify(_db, GlobalVar.Oper.OperName, _selectedData);
            EntitiesFactory.SaveDb(_db);
            Init();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseNotify();
        }

    }
    class NotifyTypeComboBox : GridComboBoxExEditControl
    {

        public NotifyTypeComboBox()
        {
            DataSource = new BindingList<EnumItem>(EnumHelper.EnumToList<NotifyType>());
            DisplayMember = "Desc";
            ValueMember = "Value";
        }
    }
    class BillStateComboBox : GridComboBoxExEditControl
    {

        public BillStateComboBox()
        {
            DataSource = new BindingList<EnumItem>(EnumHelper.EnumToList<BillState>());
            DisplayMember = "Desc";
            ValueMember = "Value";
        }
    }
}
