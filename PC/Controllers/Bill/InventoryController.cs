using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using ChangKeTec.Wms.Controllers.BaseData;
using ChangKeTec.Wms.Controllers.Interface;
using ChangKeTec.Wms.Controllers.Log;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;

namespace ChangKeTec.Wms.Controllers.Bill
{
    public static class InventoryController
    {
        public static void AddOrUpdate(SpareEntities db, TB_BILL bill)
        {
            db.TB_BILL.AddOrUpdate(p => p.BillNum, bill);
            BillLogController.Add(db, bill, bill.OperName, OperateType.Add); //创建【单据日志】
        }

        public static void Start(SpareEntities db, TB_BILL bill)
        {
            bill.State = (int) BillState.Handling; //更新单据状态为正在执行
            BillLogController.Add(db, bill, bill.OperName, OperateType.Update); //创建【单据日志】
        }

        public static void Finish(SpareEntities db, TB_BILL bill)
        {
            bill.State = (int) BillState.Finished; //更新单据状态为结束
            BillLogController.Add(db, bill, bill.OperName, OperateType.Finish); //创建【单据日志】
        }


        public static void Cancel(SpareEntities db, TB_BILL bill)
        {
            bill.State = (int) BillState.Cancelled; //更新单据状态为取消
            BillLogController.Add(db, bill, bill.OperName, OperateType.Cancel); //创建【单据日志】
        }

        public static void AddLocList(SpareEntities db, List<TB_INVENTORY_LOC> details)
        {
            db.TB_INVENTORY_LOC.AddRange(details);
        }

        public static void AddDetailList(SpareEntities db, List<TB_INVENTORY_DETAIL> details)
        {
            db.TB_INVENTORY_DETAIL.AddRange(details);
        }

        public static void AdjustStockByInventory(SpareEntities db, TB_BILL bill,List<TB_INVENTORY_DETAIL> details)
        {
            var stockMoveList = new List<TB_STOCK_MOVE>();
//            var stockInList = new List<TS_STOCK_DETAIL>();
//            var stockOutList = new List<TS_STOCK_DETAIL>();
            foreach (TB_INVENTORY_DETAIL detail in details)
            {
               StoreLocationController.UnLock(db, detail.CheckLocCode);//解锁库位

                var diffqty = detail.BookQty - detail.CheckQty;
                if (diffqty == 0) continue;
                //                if (!string.IsNullOrEmpty(detail.BookLocCode))
                //                {
                //                    detail.BookLocCode =
                //                    var stockOut = detail.ToStockOut();
                //                    stockOutList.Add(stockOut);
                //                }
                //                if (!string.IsNullOrEmpty(detail.CheckLocCode))
                //                {
                //                    var stockIn = detail.ToStockIn();
                //                    stockInList.Add(stockIn);
                //                }
                var stockMove = detail.ToStockMove();
                if (diffqty < 0)
                {
                    stockMove.FromLocCode = stockMove.ToLocCode;
                    stockMove.ToLocCode = "OTHER";
                    stockMove.Qty = -diffqty;
                }
                stockMoveList.Add(stockMove);
            }
            StockDetailController.ListMove(db,bill,stockMoveList);//盘点差异执行移库

           
        }

        public static void LocCancel(SpareEntities db, TB_INVENTORY_LOC locBill)
        {
          
            var bill = db.TB_INVENTORY_LOC.Find(locBill.BillNum, locBill.LocCode);
            if (bill != null)
                bill.State = (int) BillState.Cancelled; //更新单据状态为取消
            StoreLocationController.UnLock(db, locBill.LocCode); //解锁库位
            //TODO 如果已调整或库存，需要调整回来
          
        }

        public static void LocStart(SpareEntities db, TB_INVENTORY_LOC locBill)
        {
          
            var bill =db.TB_INVENTORY_LOC.SingleOrDefault(p=>p.BillNum==locBill.BillNum&&p.LocCode==locBill.LocCode);
            if (bill != null)
            {
                bill.CheckBeginTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
//
//                locBill.CheckBeginTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
//
//                db.TB_INVENTORY_LOC.Attach(locBill);
//                db.Entry(locBill).State = EntityState.Modified;
            }
            else
            {
                locBill.CheckBeginTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                db.TB_INVENTORY_LOC.Remove(locBill);
                db.TB_INVENTORY_LOC.Attach(locBill);
                db.Entry(locBill).State = EntityState.Modified;
            }
            //                bill.State = (int)BillState.Handling; //更新单据状态为正在执行
            StoreLocationController.Lock(db, locBill.LocCode);//锁定库位

            BillLogController.Add(db, locBill, locBill.OperName, OperateType.Update); //创建【单据日志】


        }

        public static void LocFinish(SpareEntities db, TB_INVENTORY_LOC locBill, List<TB_INVENTORY_DETAIL> details)
        {
//            locBill.State = (int)BillState.Finished; //更新单据状态为已完成
            var bill = BillController.GetBill(db, locBill.BillNum);
            locBill.CheckEndTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            db.TB_INVENTORY_LOC.Remove(locBill);
            db.TB_INVENTORY_LOC.Attach(locBill);
            db.Entry(locBill).State = EntityState.Modified;
            db.TB_INVENTORY_DETAIL.AddOrUpdate(p=>p.UID,details.ToArray());
            AdjustStockByInventory(db, bill, details);    //根据盘点结果调整库存

            BillLogController.Add(db, locBill, locBill.OperName, OperateType.Finish); //创建【单据日志】
        }

        public static TB_INVENTORY_LOC GetLoc(SpareEntities db, string billNum,string locCode)
        {
            return db.TB_INVENTORY_LOC.SingleOrDefault(p => p.BillNum == billNum && p.LocCode == locCode);
        }

        public static List<TB_INVENTORY_LOC> GetLocList(SpareEntities db, string billNum)
        {
            return db.TB_INVENTORY_LOC.Where(p => p.BillNum == billNum).ToList();
        }

        public static List<TB_INVENTORY_DETAIL> GetDetail(SpareEntities db, string billNum)
        {
            return db.TB_INVENTORY_DETAIL.Where(p => p.BillNum == billNum).ToList();
        }

        public static List<TB_INVENTORY_DETAIL> GetDetailList(SpareEntities db, string billNum)
        {
            var detailList = db.TB_INVENTORY_DETAIL.Where(p => p.BillNum == billNum).ToList();
            return detailList;
        }


        public static void AddList(SpareEntities db, IEnumerable<TB_INVENTORY_DETAIL> detailList)
        {
            var list = detailList.Select(vdetail => new TB_INVENTORY_DETAIL
            {
                UID = vdetail.UID,
                BillNum = vdetail.BillNum ?? "",
                PartCode = vdetail.PartCode,
                Batch = vdetail.Batch,
                BookQty = vdetail.BookQty,
                CheckQty = vdetail.CheckQty,
                CheckLocCode = vdetail.CheckLocCode,
            }).ToList();
            db.TB_INVENTORY_DETAIL.AddRange(list);
        }

        public static void UpdateList(SpareEntities db, IEnumerable<TB_INVENTORY_DETAIL> detailList)
        {
            var list = detailList.Select(vdetail => new TB_INVENTORY_DETAIL
            {
                UID = vdetail.UID,
                BillNum = vdetail.BillNum ?? "",
                PartCode = vdetail.PartCode,
                Batch = vdetail.Batch,
                BookQty = vdetail.BookQty,
                CheckQty = vdetail.CheckQty,
                CheckLocCode = vdetail.CheckLocCode,
            }).ToList();
            db.TB_INVENTORY_DETAIL.AddOrUpdate(p => p.UID, list.ToArray());
        }
    }
}