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
    public static class StoreLocationController
    {
            public static List<TA_STORE_LOCATION> GetList(SpareEntities db)
        {
            return db.TA_STORE_LOCATION.OrderBy(p=>p.LocCode).ToList();
        }

        public static void Disable(SpareEntities db, int id, TS_OPERATOR oper)
        {
            var location = db.TA_STORE_LOCATION.Single(p => p.UID == id);
            location.State = (int)DataState.Disabled;
            OperLogController.AddLog(db, LogType.BaseDataDisable, oper.OperName, location.ToString());
        }

        public static void AddOrUpdate(SpareEntities db, TA_STORE_LOCATION selectedData, TS_OPERATOR oper)
        {
            var logType = db.TA_STORE_LOCATION.Any(p => p.UID == selectedData.UID) ? LogType.BaseDataModify : LogType.BaseDataCreate;
            try
            {
                db.TA_STORE_LOCATION.AddOrUpdate(p => p.LocCode, selectedData);
                OperLogController.AddLog(db, logType, oper.OperName, selectedData.ToString());
            }
            catch (DbEntityValidationException dbEx)
            {
                Console.WriteLine(dbEx.ToString());
                throw;
            }
        }

        public static void Delete(SpareEntities db, TA_STORE_LOCATION data, TS_OPERATOR oper)
        {
            db.Entry(data).State = EntityState.Deleted;
            OperLogController.AddLog(db, LogType.BaseDataDelete, oper.OperName, data.ToString());

        }

        public static void Lock(SpareEntities db, string locCode)
        {
            
            var loc = db.TA_STORE_LOCATION.Find(locCode);
            if (loc == null)
            {
                throw new WmsException(ResultCode.DataNotFound, locCode, "Œ¥’“µΩø‚Œª£¨À¯∂® ß∞‹");
            }
            else
            {
                loc.State = (int)DataState.Disabled;
            }
           
        }

        public static void UnLock(SpareEntities db, string locCode)
        {
           
            var loc = db.TA_STORE_LOCATION.Find(locCode);
            if (loc == null)
            {
                throw new WmsException(ResultCode.DataNotFound, locCode, "Œ¥’“µΩø‚Œª£¨Ω‚À¯ ß∞‹");
            }
            else
            {
                loc.State = (int)DataState.Enabled;
            }
          
        }
    
        public static TA_STORE_LOCATION Get(SpareEntities db, string locCode)
        {
            return db.TA_STORE_LOCATION.Find(locCode);
        }

    }
   
}