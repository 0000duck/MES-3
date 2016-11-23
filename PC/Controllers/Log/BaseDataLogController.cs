using System;
using System.Collections.Generic;
using System.Linq;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;

namespace ChangKeTec.Wms.Controllers.Log
{
    public static class BaseDataLogController
    {
        public static TL_BASEDATA Add(SpareEntities db,string dataType,string oldValue,string newValue, string operName, OperateType operateType)
        {
            var log = new TL_BASEDATA
            {
                OperName = operName,
                LogTime = DateTime.Now,
                LogType = operateType.ToString(),
                DataType = dataType,
                OldValue = oldValue,
                NewValue = newValue,

            };
            db.TL_BASEDATA.Add(log);
            return log;
        }

        public static IList<TL_BASEDATA> GetList(SpareEntities db, DateTime beginTime, DateTime endTime)
        {
            var list = db.TL_BASEDATA.Where(p =>
                p.LogTime >= beginTime
                && p.LogTime <= endTime
                ).OrderByDescending(p => p.UID).ToList();
            return list;
        }

        public static void RemoveLocal(SpareEntities db, TL_BASEDATA log)
        {
            db.TL_BASEDATA.Local.Remove(log);
        }
    }
}