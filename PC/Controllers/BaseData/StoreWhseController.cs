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


    public static class StoreWhseController
    {
        public static List<TA_STORE_WHSE> GetList(SpareEntities db)
        {
            return db.TA_STORE_WHSE.OrderBy(p => p.WhseCode).ToList();

        }

        public static void Disable(SpareEntities db, int id, TS_OPERATOR oper)
        {
            var data = db.TA_STORE_WHSE.Single(p => p.UID == id);
            data.State = (int)DataState.Disabled;
            OperLogController.AddLog(db, LogType.BaseDataDisable, oper.OperName, data.ToString());
        }

        public static void AddOrUpdate(SpareEntities db, TA_STORE_WHSE data, TS_OPERATOR oper)
        {
            var logType = db.TA_STORE_WHSE.Any(p => p.UID == data.UID) ? LogType.BaseDataModify : LogType.BaseDataCreate;
            try
            {
                db.TA_STORE_WHSE.AddOrUpdate(p => p.WhseCode, data);
                OperLogController.AddLog(db, logType, oper.OperName, data.ToString());
            }
            catch (DbEntityValidationException dbEx)
            {
                Console.WriteLine(dbEx.ToString());
                throw;
            }
        }

        public static void Delete(SpareEntities db, TA_STORE_WHSE data, TS_OPERATOR oper)
        {
            db.Entry(data).State = EntityState.Deleted;
            OperLogController.AddLog(db, LogType.BaseDataDelete, oper.OperName, data.ToString());

        }
    }
}