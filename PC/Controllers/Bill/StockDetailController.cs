using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Globalization;
using System.Linq;
using ChangKeTec.Wms.Controllers.BaseData;
using ChangKeTec.Wms.Controllers.Interface;
using ChangKeTec.Wms.Controllers.Log;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;

namespace ChangKeTec.Wms.Controllers.Bill
{
    public static class StockDetailController
    {
        private static void In(SpareEntities db, TB_BILL bill, TS_STOCK_DETAIL detailIn)
        {
            CheckStockDetailLoc(db, detailIn.LocCode);

            if (detailIn.UpdateQty <= 0)
            {
                throw new WmsException(ResultCode.StockNotEnough,GetDetailInfo(detailIn), "入库数量错误");
            }
            var stockDetail = Get(db, detailIn.LocCode,detailIn.PartCode,detailIn.Batch) ?? detailIn.Clone();
            stockDetail.Qty += detailIn.UpdateQty;
            stockDetail.UpdateQty = detailIn.UpdateQty;
            stockDetail.UpdateTime = DateTime.Now;
            db.TS_STOCK_DETAIL.AddOrUpdate(stockDetail);
            SetProduceDate(db, stockDetail);

            TransactionLogController.Add(db, bill, detailIn); //添加库存事务日志
        }

        private static string GetDetailInfo(TS_STOCK_DETAIL detailIn)
        {
            return detailIn.PartCode+"."+detailIn.Batch + "@" + detailIn.LocCode;
        }


        public static void Out(SpareEntities db, TB_BILL bill, TS_STOCK_DETAIL detailOut)
        {
            CheckStockDetailLoc(db, detailOut.LocCode);

            var loc = StoreLocationController.Get(db, detailOut.LocCode);
//            if (detailOut.UpdateQty >= 0)
//            {
//                throw new WmsException(ResultCode.StockNotEnough,
//                   GetDetailInfo(detailOut), "出库数量错误，无法移出");
//            }
            if (detailOut.Qty + detailOut.UpdateQty < 0)
            {
                throw new WmsException(ResultCode.StockNotEnough,
                     GetDetailInfo(detailOut), "出库库存明细不足，无法移出");

            }
            var stockDetail = Get(db, detailOut.LocCode,detailOut.PartCode,detailOut.Batch);
            if (stockDetail == null) //库存明细不存在，报错
            {
                throw new WmsException(ResultCode.DataNotFound,
                    GetDetailInfo(detailOut), "出库库存明细不存在");

            }
            else //库存明细存在，更新数量(出库时更新数量为负值)
            {
                stockDetail.Qty += detailOut.UpdateQty;
                stockDetail.UpdateQty = detailOut.UpdateQty;
                stockDetail.UpdateTime = DateTime.Now;
            }
            TransactionLogController.Add(db, bill, detailOut); //添加库存事务日志
        }



        public static void ListIn(SpareEntities db, TB_BILL bill, List<TS_STOCK_DETAIL> details)
        {
            

            foreach (var detail in details)
            {
                In(db, bill, detail);
//                //创建ERP接口
//                ErpInterfaceController.CreateRCT(db,detail.PartCode,detail.Qty,string.Empty, detail.LocCode,bill.BillNum,(BillType)(bill.BillType),bill.BillTime);
            }
        }

        public static void ListOut(SpareEntities db, TB_BILL bill, List<TS_STOCK_DETAIL> details)
        {
            foreach (var detail in details)
            {
                Out(db, bill, detail);
//                //创建ERP接口
//                ErpInterfaceController.CreateSH(db, detail.PartCode, detail.Qty, string.Empty, detail.LocCode, bill.BillNum, (BillType)(bill.BillType), bill.BillTime);
            }
        }

        public static void ListMove(SpareEntities db, TB_BILL bill, List<TB_STOCK_MOVE> details)
        {
            foreach (var detail in details)
            {
                if (detail.FromLocCode != detail.ToLocCode)
                {
                    var detailOut = detail.ToStockDetailOut();
                    Out(db, bill, detailOut);
                }
                var detailIn = detail.ToStockDetailIn(db);
                In(db, bill, detailIn);
//                //创建ERP接口
//                ErpInterfaceController.CreateTR(db, detail.PartCode, detail.Qty, detail.FromLocCode, detail.ToLocCode,detail.Batch,detail.Batch, bill.BillNum, (BillType)(bill.BillType), bill.BillTime);
            }
        }
        

        public static List<TS_STOCK_DETAIL> GetTListByLocCode(SpareEntities db, string locCode)
        {
            return db.TS_STOCK_DETAIL.Where(p => p.LocCode == locCode).ToList();
        }

        public static TS_STOCK_DETAIL Get(SpareEntities db, string locCode,string partCode,string batch)
        {
            return db.TS_STOCK_DETAIL.Find(locCode,partCode, batch);
//            return db.TS_STOCK_DETAIL.SingleOrDefault(p => p.BarCode == partCode && p.LocCode == locCode);
        }

        public static TS_STOCK_DETAIL Get(SpareEntities db, int uid)
        {
            return db.TS_STOCK_DETAIL.SingleOrDefault(p=>p.UID==uid);
            //            return db.TS_STOCK_DETAIL.SingleOrDefault(p => p.BarCode == partCode && p.LocCode == locCode);
        }
        

        public static List<TS_STOCK_DETAIL> GetTListByBarCode(SpareEntities db, string partCode)
        {
            return db.TS_STOCK_DETAIL.Where(p => p.PartCode == partCode).ToList();

        }

        public static TS_STOCK_DETAIL GetFirst(SpareEntities db, string partCode)
        {
            return db.TS_STOCK_DETAIL.FirstOrDefault(p => p.PartCode == partCode);
        }

        private static void CheckStockDetailLoc(SpareEntities db, string locCode)
        {
            var loc = db.TA_STORE_LOCATION.Find(locCode);
            if (loc == null)
            {
                throw  new WmsException(ResultCode.DataNotFound, locCode, "库位不存在");

            }
//            if (loc.State == (int) DataState.Disabled)
//            {
//                throw new WmsException(ResultCode.DataStateError, locCode, "库位已锁定");
//            }
        }

        private static void SetProduceDate(SpareEntities db, TS_STOCK_DETAIL detail)
        {
            IFormatProvider ifp = new CultureInfo("zh-CN", true);
            DateTime pDate = DateTime.Now;
            try
            {
                pDate = DateTime.ParseExact(detail.Batch.Substring(0, 6), "yyMMdd", ifp);
            }
            catch (Exception ex)
            {
//                throw ex;
            }
            var part = db.TA_PART.SingleOrDefault(p => p.PartCode == detail.PartCode);

            if (part == null)
            {
                detail.ProduceDate = pDate;
                return;
            }
            detail.ProduceDate = pDate;
            if (detail.ProduceDate != null)
                detail.OverdueDate = detail.ProduceDate.AddDays(part.ValidityDays);
        }


        public static decimal GetValidStockQty(SpareEntities db, string partCode, string batch, string locCode)
        {
            var allStockQty =
                db.TS_STOCK_DETAIL.Where(p => p.PartCode == partCode
                                              && p.Batch == batch
                                              && p.LocCode == locCode
                                              && p.State == (int)StockDetailState.Valid).Sum(s => s.Qty);
            return allStockQty;
        }

        public static List<TS_STOCK_DETAIL> GetListByPartCode(SpareEntities db, string partCode)
        {
            return db.TS_STOCK_DETAIL.Where(p => p.PartCode == partCode).ToList();
        }

        public static List<TS_STOCK_DETAIL> GetListByLocCode(SpareEntities db, string locCode)
        {
            return db.TS_STOCK_DETAIL.Where(p => p.LocCode == locCode).ToList();
        }
    }
}