using System;
using System.Collections.Generic;
using System.Linq;
using ChangKeTec.Wms.Controllers.BaseData;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;

namespace ChangKeTec.Wms.Controllers.Bill
{
    public static class StockController
    {
        public static VS_STOCK GetV(SpareEntities db, string partCode, string locCode)
        {
            return GetV(db,partCode,"",locCode);
        }


        public static VS_STOCK GetV(SpareEntities db, string partCode, string batch, string locCode)
        {
            var stock = db.VS_STOCK.SingleOrDefault(p => p.PartCode == partCode
                                                         && p.Batch == batch
                                                         && p.LocCode == locCode);
            return stock;
        }

        public static TS_STOCK Get(SpareEntities db, string locCode,string partCode, string batch)
        {
            var stock = db.TS_STOCK.Find(locCode, partCode, batch);
            return stock;
        }

        internal static void In(SpareEntities db, TS_STOCK_DETAIL detailIn)
        {
            In(db, detailIn.PartCode, detailIn.Batch, detailIn.LocCode, detailIn.UpdateQty);
        }

        public static List<VS_STOCK> GetVListByPart(SpareEntities db, string partCode)
        {
            var stockList = db.VS_STOCK.Where(p => p.PartCode == partCode).ToList();
            return stockList;
        }

      /*  public static voidIn(SpareEntities db, List<TS_STOCK_DETAIL> details)
        {
            ReturnResult result = new ReturnResult();
            var group =
                details.GroupBy(p => new {p.PartCode, p.Batch, p.LocCode})
                    .Select(g => new {g.Key.PartCode, g.Key.Batch, g.Key.LocCode, SumUpdateQty = g.Sum(s => s.UpdateQty),})
                    .ToList();
            foreach (var g in group)
            {
                result = In(db, g.PartCode, g.Batch, g.LocCode, g.SumUpdateQty);
                if (result.ResultCode != ResultCode.Success) return result;
            }
            return result;
        }*/

        public static void In(SpareEntities db, string partCode, string batch, string locCode, decimal qty)
        {
            var stock = Get(db,locCode,partCode,batch) ?? new TS_STOCK
            {
                PartCode = partCode,
                Batch = batch,
                LocCode = locCode,
                State = 1,
            };
//            var stock = db.TS_STOCK.SingleOrDefault(p => p.PartCode == partCode && p.Batch == batch && p.LocCode == locCode); ;
            stock.Qty += qty;
            stock.UpdateQty += qty;
            stock.UpdateTime = DateTime.Now;
            db.TS_STOCK.AddOrUpdate(p => new{p.LocCode,p.PartCode,p.Batch}, stock);
        }

        internal static void Out(SpareEntities db, TS_STOCK_DETAIL detailOut)
        {
            Out(db, detailOut.PartCode, detailOut.Batch, detailOut.LocCode, detailOut.UpdateQty);
        }

        //        public static TS_STOCK StockOut(SpareEntities db, string partCode,string locCode)
        //        {
        //            var stock =
        //                         wms.TS_STOCK.OrderByDescending(p=>p.Batch).FirstOrDefault(
        //                             p => p.ErpPartCode == partCode && p.LocCode == locCode);
        //            
        //            if (stock != null)
        //            {
        //                var qty = stock.Qty;
        //                StockOut(wms, stock, qty);
        //            }
        //            return stock;
        //        }

     /*   public static voidOut(SpareEntities db, List<TS_STOCK_DETAIL> details)
        {
            ReturnResult result = new ReturnResult();
            var group =
              details.GroupBy(p => new { p.PartCode, p.Batch, p.LocCode })
                  .Select(g => new { g.Key.PartCode, g.Key.Batch, g.Key.LocCode, SumUpdateQty = g.Sum(s => s.UpdateQty), })
                  .ToList();
            foreach (var g in group)
            {
                result =Out(db, g.PartCode, g.Batch, g.LocCode, g.SumUpdateQty);
                if (result.ResultCode != ResultCode.Success) return result;
            }
            return result;
        }
     */

        public static void Out(SpareEntities db, string partCode, string batch, string locCode, decimal qty)
        {
            var stock = Get(db, locCode, partCode, batch);
//            var stock = db.TS_STOCK.SingleOrDefault(p => p.PartCode == partCode && p.Batch == batch && p.LocCode == locCode );
            if (stock == null)
            {
                throw new WmsException(ResultCode.StockNotEnough, partCode + "." + batch + "." + locCode, "库存不存在");
            }
            //TODO 用local优化
            var freezeStocks = db.TS_STOCK_FREEZE.Where(p => p.PartCode == stock.PartCode && p.Batch == stock.Batch).ToList();
            var freezeQty = !freezeStocks.Any() ? 0 : freezeStocks.Sum(p => p.Qty);
            //TODO
            var loc = StoreLocationController.Get(db, locCode);
            if (!loc.IsEnableNegativeStock && stock.Qty - freezeQty < 0) //不允许负库存的情况下，移出库位可用库存小于移库库存
            {
                throw new WmsException(ResultCode.StockNotEnough, partCode + "." + batch + "." + locCode, "有效库存不足");
            }
            stock.Qty += qty;       //出库时更新数量为负
            stock.UpdateQty += qty;
            stock.UpdateTime = DateTime.Now;
            if (loc.AutoRemoveZeroStock && stock.Qty == 0)
            {
                db.TS_STOCK.Remove(stock);  //自动清理零库存
            }

        }

        public static List<VS_STOCK> GetVList(SpareEntities db, string storeArea=null)
        {
            var list = storeArea == null ? db.VS_STOCK.ToList() : db.VS_STOCK.Where(p => p.AreaCode == storeArea).ToList();
            return list;
        }

        public static List<VS_STOCK> GetVList(SpareEntities db, string storeArea, string locCode)
        {
            var list = db.VS_STOCK.Where(p => p.AreaCode == storeArea && p.LocCode==locCode).ToList();
            return list;
        }

        /// <summary>
        /// 冻结【库存冻结表】
        /// </summary>
        /// <param name="db"></param>
        /// <param name="details"></param>
        /// <returns></returns>
        public static void ListFreeze(SpareEntities db, List<TB_PICK_PLAN> details)
        {
            foreach (var detail in details)
            {
                var batch = detail.Batch;
                var qty = detail.Qty;
              
                var stocksQty =db.TS_STOCK.Where(p => p.PartCode == detail.PartCode && p.Batch == batch).Sum(p => p.Qty);
                var freezes = db.TS_STOCK_FREEZE.Where(p => p.PartCode == detail.PartCode && p.Batch == batch);
                decimal freezedQty=0;
                if(freezes.Any())
                    freezedQty = freezes.Sum(p => p.Qty);
                if (stocksQty- freezedQty < qty)
                {
                    throw new WmsException(ResultCode.StockNotEnough, detail.PartCode + "." + detail.Batch, "库存不足，无法冻结");
                }
                var freezeStock =
                    db.TS_STOCK_FREEZE.SingleOrDefault(
                        p =>p.BillNum == detail.BillNum 
                            && p.PartCode == detail.PartCode 
                            && p.Batch == batch) 
                    ??
                    new TS_STOCK_FREEZE
                    {
                        BillNum = detail.BillNum,
                        PartCode = detail.PartCode,
                        Batch = batch,
                        Qty = 0
                    };
                freezeStock.Qty += qty;

                db.TS_STOCK_FREEZE.AddOrUpdate(p => p.UID, freezeStock);
            }
        }

        /// <summary>
        /// 冻结【库存冻结表】
        /// </summary>
        /// <param name="db"></param>
        /// <param name="details"></param>
        /// <param name="isBill">按计划/按实际</param>
        /// <returns></returns>
        public static void ListFreeze(SpareEntities db, List<TB_OUT> details)
        {
            foreach (var detail in details)
            {
                var batch = detail.Batch;
                var qty = detail.Qty;
                var stocksQty = db.TS_STOCK.Where(p => p.PartCode == detail.PartCode && p.Batch == batch).Sum(p => p.Qty);

                if (stocksQty < qty)
                {
                    throw new WmsException(ResultCode.StockNotEnough, detail.PartCode + "." + detail.Batch, "库存不足，无法冻结");
                }
                var freezeStock =
                    db.TS_STOCK_FREEZE.SingleOrDefault(
                        p => p.BillNum == detail.BillNum
                            && p.PartCode == detail.PartCode
                            && p.Batch == batch)
                    ??
                    new TS_STOCK_FREEZE
                    {
                        BillNum = detail.BillNum,
                        PartCode = detail.PartCode,
                        Batch = batch,
                        Qty = 0
                    };
                freezeStock.Qty += qty;

                db.TS_STOCK_FREEZE.AddOrUpdate(p => p.UID, freezeStock);
            }
        }


        /// <summary>
        /// 解冻【库存冻结表】
        /// </summary>
        /// <param name="db"></param>
        /// <param name="bill"></param>
        public static void ListThaw(SpareEntities db, string billnum)
        {
            var freezStocks = db.TS_STOCK_FREEZE.Where(p => p.BillNum == billnum);
            db.TS_STOCK_FREEZE.RemoveRange(freezStocks);
        }

        public static List<TS_STOCK> GetListByPart(SpareEntities db, string partCode)
        {
            return db.TS_STOCK.Where(p => p.PartCode == partCode).ToList();
        }

        public static List<TS_STOCK> GetList(SpareEntities db)
        {
            return db.TS_STOCK.ToList();
        }
    }
}