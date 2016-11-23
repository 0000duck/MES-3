using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using ChangKeTec.PowerForm.Bll;
using ChangKeTec.Wms.Common.ComboBox;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.PowerForm.Manage
{

    public partial class FormRole : Office2007Form
    {
        private readonly PowerEntities _db = EntitiesFactory.CreatePowerInstance();
        private TS_ROLE _selectedData;
        private readonly List<TA_MENU> _menuList;
        private readonly List<EnumItem> _notifyTypeList;

        public FormRole()
        {
            InitializeComponent();
            _menuList = _db.TA_MENU.AsNoTracking().OrderBy(p => p.PortalCode).ThenBy(p => p.MenuCode).ToList();
            _notifyTypeList = EnumHelper.EnumToList<NotifyType>();
            Init();
        }

        private void Init()
        {
            bs.DataSource = _db.TS_ROLE.ToList();
            grid.PrimaryGrid.DataSource = bs;
            bn.BindingSource = bs;
            _selectedData = new TS_ROLE();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            var detailList = (List<TS_ROLE>) bs.DataSource;
            TL_BASEDATA log = null;

            foreach (TS_ROLE storeWhse in _db.TS_ROLE)
            {

                if (detailList.All(p => p.UID != storeWhse.UID))
                    _db.TS_ROLE.Remove(storeWhse);

                OperateType logType;
                string oldValue, newValue;
                DbEntityEntry<TS_ROLE> entry;

                try
                {
                    entry = _db.Entry(storeWhse);

                }
                catch (Exception ex)
                {

                    MessageHelper.ShowInfo(ex.ToString());
                    bs.DataSource = _db.TS_ROLE.ToList();
                    return;
                }
                var dataType = entry.Entity.GetType().Name;
                switch (entry.State)
                {
                    case EntityState.Detached:
                    case EntityState.Unchanged:
                    case EntityState.Added:
                        continue;
                    case EntityState.Deleted:
                        logType = OperateType.Delete;
                        oldValue = GetValues(entry.OriginalValues);
                        newValue = "";
//                        _db.TS_ROLE.Remove(storeWhse);
                        break;
                    case EntityState.Modified:
                        logType = OperateType.Update;
                        oldValue = GetValues(entry.OriginalValues);
                        newValue = GetValues(entry.CurrentValues);
//                        _db.TS_ROLE.Attach(storeWhse);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                log = BaseDataLogController.Add(_db, dataType, oldValue, newValue, "", logType);
            }
            foreach (var detail in detailList.Where(detail => !_db.TS_ROLE.Any(p => p.UID == detail.UID)))
            {
                _db.TS_ROLE.Add(detail);
                var entry = _db.Entry(detail);
                var dataType = entry.Entity.GetType().Name;
                var logType = OperateType.Add;
                var oldValue = "";
                var newValue = GetValues(entry.CurrentValues);
                log = BaseDataLogController.Add(_db, dataType, oldValue, newValue, "", logType);
            }
            try
            {
                EntitiesFactory.SaveDb(_db);
                grid.PrimaryGrid.PurgeDeletedRows();
                grid.PrimaryGrid.ClearDirtyRowMarkers();
                MessageHelper.ShowInfo("保存成功！");
            }
            catch (Exception ex)
            {
                MessageHelper.ShowInfo(ex.ToString());
                if (log != null)
                    BaseDataLogController.RemoveLocal(_db, log);
            }
        }

        private static string GetValues(DbPropertyValues values)
        {
            var sb = new StringBuilder();
            foreach (var propertyName in values.PropertyNames)
            {
                sb.Append(propertyName + ":" + values[propertyName] + ",");
            }
            return sb.ToString();
        }

        private void grid_MasterGridCellActivated(object sender, GridCellActivatedEventArgs e)
        {
            _selectedData = (TS_ROLE) e.NewActiveCell.GridRow.DataItem;
            if (string.IsNullOrEmpty(_selectedData.RoleCode)) return;
            SetDetailGridDataSource(_db, _selectedData.RoleCode);
        }

        private void SetDetailGridDataSource(PowerEntities db, string roleCode)
        {
            var powerList = db.VS_POWER_MENU.AsNoTracking().Where(p => p.RoleCode == roleCode).ToList();
            foreach (TA_MENU menu in _menuList)
            {
                var power =
                    powerList.SingleOrDefault(p => p.PortalCode == menu.PortalCode && p.MenuCode == menu.MenuCode);
                if (power == null)
                {
                    power = new VS_POWER_MENU
                    {
                        RoleCode = roleCode,
                        PortalCode = menu.PortalCode,
                        ParentCode = menu.ParentCode,
                        MenuCode = menu.MenuCode,
                        MenuText = menu.MenuText,
                        ControlType = menu.ControlType,
                        IsVisible = false,
                        IsReadOnly = false,
                    };
                    powerList.Add(power);
                }
            }
            powerList = powerList.OrderBy(p => p.PortalCode).ThenBy(p => p.MenuCode).ToList();
            gridDetail.PrimaryGrid.DataSource = new BindingList<VS_POWER_MENU>(powerList);


            var list = db.TS_ROLE_NOTIFYTYPE.AsNoTracking().Where(p => p.RoleCode == roleCode).ToList();
            foreach (var item in _notifyTypeList)
            {
                var power = list.SingleOrDefault(p => p.NotifyType == item.Value);
                if (power == null)
                {
                    power = new TS_ROLE_NOTIFYTYPE
                    {
                        RoleCode = roleCode,
                        PortalCode = "",
                        NotifyType = item.Value,
                        IsVisible = false,
                    };
                    list.Add(power);
                }
            }
            gridNotifyType.PrimaryGrid.DataSource = new BindingList<TS_ROLE_NOTIFYTYPE>(list);
        }


        private void grid_DataError(object sender, GridDataErrorEventArgs e)
        {
            grid.PrimaryGrid.ActiveCell.CancelEdit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridNotifyType.PrimaryGrid.Columns[2].EditorType = typeof (NotifyTypeComboBox);
            foreach (GridColumn column in grid.PrimaryGrid.Columns)
            {
                column.MinimumWidth = 100;
            }
            grid.PrimaryGrid.ColumnAutoSizeMode = ColumnAutoSizeMode.Fill;
        }

        private void btnSavePower_Click(object sender, EventArgs e)
        {
            var vList = (BindingList<VS_POWER_MENU>) gridDetail.PrimaryGrid.DataSource;
            var tList = vList.Select(v => new TS_ROLE_POWER
            {
                PortalCode = v.PortalCode,
                MenuCode = v.MenuCode,
                RoleCode = v.RoleCode,
                IsReadOnly = v.IsReadOnly,
                IsVisible = v.IsVisible,
            }).ToList();

            _db.TS_ROLE_POWER.AddOrUpdate(p => new {p.RoleCode, p.PortalCode, p.MenuCode}, tList.ToArray());
            try
            {
                EntitiesFactory.SaveDb(_db);
                MessageHelper.ShowInfo("角色权限保存成功:" + _selectedData.RoleName);
                gridDetail.PrimaryGrid.ClearDirtyRowMarkers();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowInfo(ex.ToString());

            }

        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            var tList = (BindingList<TS_ROLE_NOTIFYTYPE>) gridNotifyType.PrimaryGrid.DataSource;


            _db.TS_ROLE_NOTIFYTYPE.AddOrUpdate(p => new {p.RoleCode, p.PortalCode, p.NotifyType}, tList.ToArray());
            try
            {
                EntitiesFactory.SaveDb(_db);
                MessageHelper.ShowInfo("角色权限保存成功:" + _selectedData.RoleName);
                gridNotifyType.PrimaryGrid.ClearDirtyRowMarkers();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowInfo(ex.ToString());

            }

        }
    }

}
