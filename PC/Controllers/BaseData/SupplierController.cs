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
    public static class SupplierController
    {
        public static List<TA_SUPERLIER> GetList(SpareEntities db)
        {
            return db.TA_SUPERLIER.OrderBy(p => p.SplyId).ToList();

        }

        public static TA_SUPERLIER Get(SpareEntities db, string splyId)
        {
            return db.TA_SUPERLIER.SingleOrDefault(p => p.SplyId == splyId);
        }
        public static void AddOrUpdate(SpareEntities db, TA_SUPERLIER selectedData, TS_OPERATOR oper)
        {
            var logType = db.TA_SUPERLIER.Any(p => p.UID == selectedData.UID) ? LogType.BaseDataModify : LogType.BaseDataCreate;
            try
            {
                db.TA_SUPERLIER.AddOrUpdate(p => p.SplyId, selectedData);
                OperLogController.AddLog(db, logType, oper.OperName, selectedData.ToString());
            }
            catch (DbEntityValidationException dbEx)
            {
                Console.WriteLine(dbEx.ToString());
                throw;
            }
        }

        public static void Delete(SpareEntities db, TA_SUPERLIER data, TS_OPERATOR oper)
        {
            db.Entry(data).State = EntityState.Deleted;
            OperLogController.AddLog(db, LogType.BaseDataDelete, oper.OperName, data.ToString());

        }
    }
}