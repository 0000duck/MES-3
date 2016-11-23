using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
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

    public partial class FormPortal : Office2007Form
    {
        private readonly PowerEntities _db = EntitiesFactory.CreatePowerInstance();
        public FormPortal()
        {
            InitializeComponent();
            bs.DataSource = _db.TS_PORTAL.ToList();
            grid.PrimaryGrid.DataSource = bs;
            bn.BindingSource = bs;
        }

        private  void btnSave_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            var detailList = (List<TS_PORTAL>) bs.DataSource;
            TL_BASEDATA log=null;
            
            foreach (TS_PORTAL storeWhse in _db.TS_PORTAL)
            {

                if (detailList.All(p => p.UID != storeWhse.UID))
                    _db.TS_PORTAL.Remove(storeWhse);
                
                OperateType logType;
                string oldValue, newValue;
                DbEntityEntry<TS_PORTAL> entry;

                try
                {
                    entry = _db.Entry(storeWhse);
                 
                }
                catch (Exception ex)
                {
                   
                    MessageHelper.ShowInfo(ex.ToString());
                    bs.DataSource = _db.TS_PORTAL.ToList();
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
//                        _db.TS_PORTAL.Remove(storeWhse);
                        break;
                    case EntityState.Modified:
                        logType = OperateType.Update;
                        oldValue = GetValues(entry.OriginalValues);
                        newValue = GetValues(entry.CurrentValues);
//                        _db.TS_PORTAL.Attach(storeWhse);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
               log= BaseDataLogController.Add(_db,dataType,oldValue,newValue,"",logType);
            }
            foreach (var detail in detailList.Where(detail => !_db.TS_PORTAL.Any(p => p.UID == detail.UID)))
            {
                _db.TS_PORTAL.Add(detail);
                var entry = _db.Entry(detail);
                var dataType = entry.Entity.GetType().Name;
                var logType = OperateType.Add;
                var oldValue = "";
                var newValue = GetValues(entry.CurrentValues);
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

        }

        private static string GetValues(DbPropertyValues values)
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
            prop.SelectedObject = e.NewActiveCell.GridRow.DataItem;
        }


        private void grid_DataError(object sender, GridDataErrorEventArgs e)
        {
            grid.PrimaryGrid.ActiveCell.CancelEdit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            grid.PrimaryGrid.Columns[3].EditorType = typeof(PortalTypeComboBox);
            foreach (GridColumn column in grid.PrimaryGrid.Columns)
            {
                column.MinimumWidth = 100;
            }
            grid.PrimaryGrid.ColumnAutoSizeMode = ColumnAutoSizeMode.Fill;
        }

    }
}
