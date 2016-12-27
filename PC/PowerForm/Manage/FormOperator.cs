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

    public partial class FormOperator : Office2007Form
    {
        private readonly PowerEntities _db = EntitiesFactory.CreatePowerInstance();
        private TS_OPERATOR _selectedData;
        private List<TS_ROLE> _roleList; 
        public FormOperator()
        {
            InitializeComponent();
            _roleList = _db.TS_ROLE.ToList();
            Init();
        }

        private void Init()
        {
            bs.DataSource = _db.TS_OPERATOR.ToList();
            grid.PrimaryGrid.DataSource = bs;
            bn.BindingSource = bs;
            _selectedData = new TS_OPERATOR();
        }

        private  void btnSave_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            var detailList = (List<TS_OPERATOR>) bs.DataSource;
            TL_BASEDATA log=null;
            
            foreach (TS_OPERATOR data in _db.TS_OPERATOR)
            {

                if (detailList.All(p => p.UID != data.UID))
                    _db.TS_OPERATOR.Remove(data);
                
                OperateType logType;
                string oldValue, newValue;
                DbEntityEntry<TS_OPERATOR> entry;

                try
                {
                    entry = _db.Entry(data);
                 
                }
                catch (Exception ex)
                {
                    
                    MessageHelper.ShowInfo(ex.ToString());
                    bs.DataSource = _db.TS_OPERATOR.ToList();
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
                        oldValue = GetPropertyValues(entry.OriginalValues);
                        newValue = "";
//                        _db.TS_OPERATOR.Remove(storeWhse);
                        break;
                    case EntityState.Modified:
                        logType = OperateType.Update;
                        oldValue = GetPropertyValues(entry.OriginalValues);
                        newValue = GetPropertyValues(entry.CurrentValues);
//                        _db.TS_OPERATOR.Attach(storeWhse);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
               log= BaseDataLogController.Add(_db,dataType,oldValue,newValue,"",logType);
            }
            foreach (var detail in detailList.Where(detail => !_db.TS_OPERATOR.Any(p => p.UID == detail.UID)))
            {
                detail.OperPassword = EncryptHelper.Encrypt(GlobalVar.DefaultPassword);
                _db.TS_OPERATOR.Add(detail);
                var entry = _db.Entry(detail);
                var dataType = entry.Entity.GetType().Name;
                var logType = OperateType.Add;
                var oldValue = "";
                var newValue = GetPropertyValues(entry.CurrentValues);
               log= BaseDataLogController.Add(_db, dataType, oldValue, newValue, "", logType);
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
            Init();
        }

        private static string GetPropertyValues(DbPropertyValues values)
        {
            var sb = new StringBuilder();
            foreach (var propertyName in values.PropertyNames)
            {
                sb.Append( propertyName+":"+values[propertyName]+",");
            }
            return sb.ToString();
        }

        private void grid_MasterGridCellActivated(object sender, GridCellActivatedEventArgs e)
        {
            _selectedData = (TS_OPERATOR)e.NewActiveCell.GridRow.DataItem;
            if (_selectedData == null) return;
            prop.SelectedObject = _selectedData;

            SetDetailGridDataSource(_db, _selectedData.OperCode);

        }
        private void SetDetailGridDataSource(PowerEntities db, string operCode)
        {
            var operRoles = db.VS_OPER_ROLE.AsNoTracking().Where(p => p.OperCode == operCode).ToList();
            foreach (TS_ROLE role in _roleList)
            {
                var operRole =
                    operRoles.SingleOrDefault(p => p.RoleCode == role.RoleCode);
                if (operRole == null)
                {
                    operRole = new VS_OPER_ROLE
                    {
                        OperCode = operCode,
                        RoleCode = role.RoleCode,
                        RoleName = role.RoleName,
                        Remark = role.Remark,
                        IsBeloneTo = false,
                    };
                    operRoles.Add(operRole);
                }
            }
            operRoles = operRoles.OrderBy(p => p.RoleCode).ToList();
            gridRole.PrimaryGrid.DataSource = new BindingList<VS_OPER_ROLE>(operRoles);
         
        }


        private void grid_DataError(object sender, GridDataErrorEventArgs e)
        {
            grid.PrimaryGrid.ActiveCell.CancelEdit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            colDeptCode.EditorType = typeof(DeptComboBox);
            foreach (GridColumn column in grid.PrimaryGrid.Columns)
            {
                column.MinimumWidth = 100;
            }
            grid.PrimaryGrid.ColumnAutoSizeMode = ColumnAutoSizeMode.Fill;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (_selectedData == null || _selectedData.OperCode == null)
            {
                MessageHelper.ShowInfo("请选择用户");
                return;
            }

            _selectedData.OperPassword = EncryptHelper.Encrypt(GlobalVar.DefaultPassword);
            try
            {
                EntitiesFactory.SaveDb(_db);
                MessageHelper.ShowInfo($"重置密码成功！{_selectedData.OperCode} 新密码为 {GlobalVar.DefaultPassword} ");
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex.ToString());

            }

            Init();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            var vList = (BindingList<VS_OPER_ROLE>)gridRole.PrimaryGrid.DataSource;
            var tList = vList.Select(v => new TS_OPER_ROLE
            {
                OperCode = v.OperCode,
                RoleCode = v.RoleCode,
                IsBeloneTo = v.IsBeloneTo,
            }).ToList();

            _db.TS_OPER_ROLE.AddOrUpdate(p => new {p.OperCode, p.RoleCode}, tList.ToArray());
            try
            {
 EntitiesFactory.SaveDb(_db);
        MessageHelper.ShowInfo("用户角色保存成功:" + _selectedData.OperCode);
                gridRole.PrimaryGrid.ClearDirtyRowMarkers();        }
            catch (Exception ex)
            {
                 MessageHelper.ShowInfo(ex.ToString());
             
            }
        
        }
    }

  
}
