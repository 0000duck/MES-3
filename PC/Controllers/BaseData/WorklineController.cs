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
    public static class WorklineController
    {
        public static List<TA_WORKLINE> GetList(SpareEntities db)
        {
            return db.TA_WORKLINE.OrderBy(p => p.WorklineCode).ToList();

        }

        public static void AddOrUpdate(SpareEntities db, TA_WORKLINE selectedData, TS_OPERATOR oper)
        {
            var logType = db.TA_WORKLINE.Any(p => p.UID == selectedData.UID) ? LogType.BaseDataModify : LogType.BaseDataCreate;
            try
            {
                db.TA_WORKLINE.AddOrUpdate(p => p.WorklineCode, selectedData);
                OperLogController.AddLog(db, logType, oper.OperName, selectedData.ToString());
            }
            catch (DbEntityValidationException dbEx)
            {
                Console.WriteLine(dbEx.ToString());
                throw;
            }
        }

        public static void Delete(SpareEntities db, TA_WORKLINE data, TS_OPERATOR oper)
        {
            db.Entry(data).State = EntityState.Deleted;
            OperLogController.AddLog(db, LogType.BaseDataDelete, oper.OperName, data.ToString());

        }

        internal static TA_WORKLINE Get(SpareEntities db, string lineId)
        {
            return db.TA_WORKLINE.SingleOrDefault(p => p.WorklineCode == lineId);
        }
    }
}