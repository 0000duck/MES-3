using System;
using System.Collections.Generic;
using System.Linq;
using ChangKeTec.Wms.Models;

namespace ChangKeTec.Wms.Controllers
{
    public static class ReportViewController
    {
        /// <summary>
        /// 根据视图计算库存预警表，提前30天
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<VIEW_CalOverdue_DAYS> GetOverdueDaysList(SpareEntities db)
        {
            return db.VIEW_CalOverdue_DAYS.ToList();           
        }

        /// <summary>
        /// 根据视图计算安全库存表
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<VIEW_CalSafeQty> GetSafeQtysList(SpareEntities db)
        {
            return db.VIEW_CalSafeQty.ToList();
        }

        /// <summary>
        /// 根据视图查询盘点差异表
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<VIEW_INVENTORY_DETAIL> GetInventoryDetail(SpareEntities db)
        {
            return db.VIEW_INVENTORY_DETAIL.ToList();
        }

        /// <summary>
        /// 根据视图查询库存明细异表
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<VIEW_STOCK_DETAIL> GetStockDetail(SpareEntities db)
        {
            return db.VIEW_STOCK_DETAIL.ToList();
        }

        /// <summary>
        /// 根据视图查询库存呆滞表 一年没有移动的
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<VIEW_CalInaction_DAYS> GetCalInaction(SpareEntities db)
        {
            return db.VIEW_CalInaction_DAYS.ToList();
        }

        /// <summary>
        /// 根据视图查询库存在库时长表
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<VIEW_STOCK_DETAIL_AGE> GetStockDetailAge(SpareEntities db)
        {
            return db.VIEW_STOCK_DETAIL_AGE.ToList();
        }

        /// <summary>
        /// 计算出入库汇总表
        /// </summary>
        /// <param name="db"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public static List<VIEW_IO_SUMMARY_ByStock> GetIoSummarysByStockDetailList(SpareEntities db, DateTime beginTime, DateTime endTime)
        {
            var NowTime = db.Database.SqlQuery<DateTime>("select getdate()").FirstOrDefault();
            var detailList = new List<VIEW_IO_SUMMARY_ByStock>();
            var PartList = db.TA_PART.ToList();
            var TranList = db.TL_TRANSACTION.ToList();
            var StoreList = db.TA_STORE_WHSE.ToList();
            var StockList = db.TS_STOCK_DETAIL.ToList();
            var BillCalc = db.TA_BILLTYPE.Where(p => (bool)p.IsCalc).Select(x => x.BillType).ToList();
            foreach (var part in PartList)
            {
                foreach (var store in StoreList)
                {
                    var LocList =
                        db.TA_STORE_LOCATION.Where(p => p.WhseCode == store.WhseCode).Select(x => x.LocCode).ToList();
                    var TranIn =
                        TranList.Where(
                            p =>
                                p.LogTime >= beginTime && p.LogTime <= endTime
                                && BillCalc.Contains(p.BillType)
                                && LocList.Contains(p.LocCode)
                                && p.PartCode == part.PartCode && p.Remark == "In");
                    var TranOut =
                        TranList.Where(
                            p =>
                                p.LogTime >= beginTime && p.LogTime <= endTime
                                && BillCalc.Contains(p.BillType)
                                && LocList.Contains(p.LocCode) && p.Remark == "Out");
                    
                    //计算筛选的结束时间到当前时间的发生额
                    var TranNowIn =
                        TranList.Where(
                            p =>
                                p.LogTime >= endTime && p.LogTime <= NowTime
                                && BillCalc.Contains(p.BillType)
                                && LocList.Contains(p.LocCode)
                                && p.PartCode == part.PartCode && p.Remark == "In");
                    var TranNowOut =
                        TranList.Where(
                            p =>
                                p.LogTime >= endTime && p.LogTime <= NowTime
                                && BillCalc.Contains(p.BillType)
                                && LocList.Contains(p.LocCode) && p.Remark == "Out");

                    var CalStock = StockList.Where(p => p.PartCode == part.PartCode);
                    var IOSum = new VIEW_IO_SUMMARY_ByStock();
                    IOSum.库房 = store.WhseCode;
                    IOSum.零件号 = part.PartCode;
                    IOSum.入库数量 = TranIn.Sum(p => p.Qty);
                    IOSum.入库金额 = TranIn.Sum(p => p.Qty*p.UnitPrice);
                    IOSum.出库数量 = 0-TranOut.Sum(p => p.Qty);
                    IOSum.出库金额 = 0-TranOut.Sum(p => p.Qty * p.UnitPrice);
                    IOSum.当前库存 = CalStock.Sum(p => p.Qty);
                    IOSum.当前库存金额 = CalStock.Sum(p => p.Qty*p.UnitPrice);
                    IOSum.结束库存 = IOSum.当前库存 - TranNowIn.Sum(p=>p.Qty) + (0-TranNowOut.Sum(p=> p.Qty));
                    IOSum.结束库存金额 = IOSum.当前库存金额 - TranNowIn.Sum(p => p.Qty*p.UnitPrice) + (0 - TranNowOut.Sum(p => p.Qty*p.UnitPrice));
                    IOSum.开始库存 = IOSum.结束库存 - IOSum.入库数量 + IOSum.出库数量;
                    IOSum.开始库存金额 = IOSum.结束库存金额 - IOSum.入库金额 + IOSum.出库金额;
                    if (IOSum.入库数量 == 0 && IOSum.出库数量 == 0 && IOSum.当前库存 == 0)
                        continue;

                    detailList.Add(IOSum);
                }
            }
            return detailList;
        }
    }
}