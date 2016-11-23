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
    public static class PartController
    {
        public static List<TA_PART> GetList(SpareEntities db)
        {
            return db.TA_PART.OrderBy(p=>p.PartCode).ToList();
        }
        public static void Disable(SpareEntities db, long id, TS_OPERATOR oper)
        {
            var part = db.TA_PART.Single(p => p.UID == id);
            part.State = (int)DataState.Disabled;
            OperLogController.AddLog(db, LogType.BaseDataDisable, oper.OperName, part.ToString());

        }
        public static void AddOrUpdate(SpareEntities db, TA_PART selectedData)
        {
            try
            {
                db.TA_PART.AddOrUpdate(p => p.PartCode, selectedData);
            }
            catch (DbEntityValidationException dbEx)
            {
                Console.WriteLine(dbEx.ToString());
                throw;
            }
        }

        public static void AddOrUpdate(SpareEntities db, List<TA_PART> dataList)
        {
            try
            {
                db.TA_PART.AddOrUpdate(p => p.PartCode, dataList.ToArray());
            }
            catch (DbEntityValidationException dbEx)
            {
                Console.WriteLine(dbEx.ToString());
                throw;
            }
        }

        public static void AddOrUpdate(SpareEntities db, TA_PART selectedData, TS_OPERATOR oper)
        {
            var logType = db.TA_PART.Any(p => p.UID == selectedData.UID) ? LogType.BaseDataModify : LogType.BaseDataCreate;
            try
            {
                db.TA_PART.AddOrUpdate(p => p.PartCode, selectedData);
                OperLogController.AddLog(db, logType, oper.OperName, selectedData.ToString());
            }
            catch (DbEntityValidationException dbEx)
            {
                Console.WriteLine(dbEx.ToString());
                throw;
            }
        }

        public static void Delete(SpareEntities db, TA_PART data, TS_OPERATOR oper)
        {
            db.Entry(data).State = EntityState.Deleted;
            OperLogController.AddLog(db, LogType.BaseDataDelete, oper.OperName, data.ToString());

        }

        public static TA_PART GetPartByPartCode(SpareEntities db, string partCode)
        {
            return db.TA_PART.SingleOrDefault(p => p.PartCode == partCode);
        }

        public static TA_PART GetPartByErpCode(SpareEntities db, string partCode)
        {
            return db.TA_PART.SingleOrDefault(p => p.ErpPartCode == partCode);
        }
    }
}