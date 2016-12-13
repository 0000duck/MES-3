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
    public static class AttachController
    {
        public static List<TA_Attach> GetList(SpareEntities db)
        {
            return db.TA_Attach.OrderBy(p => p.UID).ToList();

        }

        public static void AddOrUpdate(SpareEntities db, TA_Attach selectedData, TS_OPERATOR oper)
        {
            var logType = db.TA_Attach.Any(p => p.UID == selectedData.UID) ? LogType.BaseDataModify : LogType.BaseDataCreate;
            try
            {
                db.TA_Attach.AddOrUpdate(p => p.UID, selectedData);
            }
            catch (DbEntityValidationException dbEx)
            {
                Console.WriteLine(dbEx.ToString());
                throw;
            }
        }

        public static void Delete(SpareEntities db, TA_Attach data, TS_OPERATOR oper)
        {
            db.Entry(data).State = EntityState.Deleted;
        }

        internal static TA_Attach Get(SpareEntities db, int UID)
        {
            return db.TA_Attach.SingleOrDefault(p => p.UID == UID);
        }
    }
}