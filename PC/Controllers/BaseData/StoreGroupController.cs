using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using ChangKeTec.Wms.Controllers.Log;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;

namespace ChangKeTec.Wms.Controllers.BaseData
{
    public static class StoreGroupController
    {
        public static List<TA_STORE_GROUP> GetList(SpareEntities db)
        {
            return db.TA_STORE_GROUP.OrderBy(p => p.GroupCode).ToList();

        }

        public static void Disable(SpareEntities db, int id, TS_OPERATOR oper)
        {
            var data = db.TA_STORE_GROUP.Single(p => p.UID == id);
            data.State = (int)DataState.Disabled;
            OperLogController.AddLog(db, LogType.BaseDataDisable, oper.OperName, data.ToString());
        }

        public static void AddOrUpdate(SpareEntities db, TA_STORE_GROUP data, TS_OPERATOR oper)
        {
            var logType = db.TA_STORE_GROUP.Any(p => p.UID == data.UID) ? LogType.BaseDataModify : LogType.BaseDataCreate;
            try
            {
                db.TA_STORE_GROUP.AddOrUpdate(p => p.GroupCode, data);
                OperLogController.AddLog(db, logType, oper.OperName, data.ToString());
            }
            catch (DbEntityValidationException dbEx)
            {
                Console.WriteLine(dbEx.ToString());
                throw;
            }
        }

        public static void Delete(SpareEntities db, TA_STORE_GROUP data, TS_OPERATOR oper)
        {
            db.Entry(data).State = EntityState.Deleted;
            OperLogController.AddLog(db, LogType.BaseDataDelete, oper.OperName, data.ToString());

        }
    }
}