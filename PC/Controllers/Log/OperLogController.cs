using System;
using System.Collections.Generic;
using System.Linq;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;

namespace ChangKeTec.Wms.Controllers.Log
{
    public static class OperLogController
    {
        public static void AddLog(SpareEntities db, LogType logType, string operName, string msg)
        {
            var log = new TL_OPER()
            {
                OperName = operName,
                LogSite = System.Net.Dns.GetHostName(),
                LogTime = DateTime.Now,
                LogType = logType.ToString(),
                Message = msg,
            };
            db.TL_OPER.Add(log);

            LogHelper.Write(log.ToString());
        }

        public static void AddLog(SpareEntities db, LogType logType, string operName, string operCode, string msg)
        {
            var log = new TL_OPER()
            {
                OperName = operName,
                LogSite = System.Net.Dns.GetHostName(),
                LogTime = DateTime.Now,
                LogType = logType.ToString(),
                Message = msg,
                OperCode = operCode,
            };
            db.TL_OPER.Add(log);

            LogHelper.Write(log.ToString());
        }


        public static IList<TL_OPER> GetList(SpareEntities db,DateTime beginTime, DateTime endTime)
        {
            var list = db.TL_OPER.Where(p =>
            p.LogTime >= beginTime
            && p.LogTime <= endTime
            ).OrderByDescending(p => p.UID).ToList();
            return list;
        }
    }
}