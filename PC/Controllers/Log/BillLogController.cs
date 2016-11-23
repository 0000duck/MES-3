using System;
using System.Collections.Generic;
using System.Linq;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;

namespace ChangKeTec.Wms.Controllers.Log
{
    public static class BillLogController
    {
        public static void Add(SpareEntities db,TB_BILL bill,string operName,OperateType operateType)
        {
            var log = new TL_BILL()
            {
                OperName = operName,
                LogTime = DateTime.Now,
                BillNum = bill.BillNum,
                BillType =bill.BillType,
                LogType = operateType.ToString(),

            };
            db.TL_BILL.Add(log);
        }

        public static IList<TL_BILL> GetList(SpareEntities db, DateTime beginTime, DateTime endTime)
        {
            var list = db.TL_BILL.Where(p =>
                p.LogTime >= beginTime
                && p.LogTime <= endTime
                ).OrderByDescending(p => p.UID).ToList();
            return list;
        }

        internal static void Add(SpareEntities db, TB_INVENTORY_LOC bill, string operName, OperateType operateType)
        {
            var log = new TL_BILL()
            {
                OperName = operName,
                LogTime = DateTime.Now,
                BillNum = bill.BillNum,
                BillType = (int)BillType.InventoryPlan,
                LogType = operateType.ToString(),

            };
            db.TL_BILL.Add(log);
        }
        
    }

    
}