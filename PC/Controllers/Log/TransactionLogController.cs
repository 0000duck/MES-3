using System;
using System.Collections.Generic;
using System.Linq;
using ChangKeTec.Wms.Models;

namespace ChangKeTec.Wms.Controllers.Log
{

    public static class TransactionLogController
    {
        public static void Add(SpareEntities db, TB_BILL bill, TS_STOCK_DETAIL detail)
        {
            Add(db, bill.BillNum, bill.BillType, bill.OperName, detail);
        }

        public static void Add(SpareEntities db, string billNum, int billType, string operName, TS_STOCK_DETAIL detail)
        {
            var log =  new TL_TRANSACTION()
            {
                OperName = operName,
                LogTime = DateTime.Now,
                BillNum = billNum,
                BillType = billType,
                PartCode = detail.PartCode,
                Batch = detail.Batch,
                Qty = detail.UpdateQty,
                LocCode = detail.LocCode,
                UnitPrice = detail.UnitPrice,
                Remark = detail.UpdateQty>0?"In":"Out",
            };
            db.TL_TRANSACTION.Add(log);

        }

/*

        public static void AddList(SpareEntities db,TB_BILL bill, IList<TS_STOCK_DETAIL> details)
        {
            AddList(db,bill.BillNum,bill.BillType,bill.OperName,details);
        }

        private static void AddList(SpareEntities db, string billNum,int billType, string operName, IList<TS_STOCK_DETAIL> details)
        {
            var list = details.Select(detail => new TL_TRANSACTION()
            {
                OperName = operName,
                LogTime = DateTime.Now,
                BillNum = billNum,
                BillType = ((BillType)billType).ToString(),
                PartCode = detail.PartCode,
                Batch = detail.Batch,
                Qty = detail.Qty,
                BarCode = detail.BarCode,
                LocCode = detail.LocCode,
                EqptCode = detail.EqptCode,
                Remark = "",
            }).ToList();
            db.TL_TRANSACTION.AddRange(list);

        }*/

        public static IList<TL_TRANSACTION> GetList(SpareEntities db, DateTime beginTime, DateTime endTime)
        {
            var list = db.TL_TRANSACTION.Where(p =>
                p.LogTime >= beginTime
                && p.LogTime <= endTime
                ).OrderByDescending(p => p.UID).ToList();
            return list;
        }
    }
}