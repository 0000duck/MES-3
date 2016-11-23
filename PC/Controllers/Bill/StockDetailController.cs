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
                throw new WmsException(ResultCode.StockNotEnough,detailIn.BarCode + "." + detailIn.LocCode, "�����������");
            }
            var stockDetail = Get(db, detailIn.BarCode, detailIn.LocCode) ?? detailIn.Clone();
            stockDetail.Qty += detailIn.UpdateQty;
            stockDetail.UpdateQty = detailIn.UpdateQty;
            stockDetail.UpdateTime = DateTime.Now;
            var part = GlobalBuffer.PartList.Single(p => p.PartCode == stockDetail.PartCode);
            switch (part.InspectType)
            {
                case 0:
                    stockDetail.State = (int) StockDetailState.Inspect;
                    break;
                case 1:
                    stockDetail.State = (int) StockDetailState.Valid;
                    break;

            }
            db.TS_STOCK_DETAIL.AddOrUpdate(p => new {p.BarCode, p.LocCode}, stockDetail);
            SetProduceDate(db, stockDetail);
            StockController.In(db, detailIn); //���¡�����������

            TransactionLogController.Add(db, bill, detailIn); //��ӿ��������־
        }


        private static void Out(SpareEntities db, TB_BILL bill, TS_STOCK_DETAIL detailOut)
        {
            CheckStockDetailLoc(db, detailOut.LocCode);

            var loc = StoreLocationController.Get(db, detailOut.LocCode);
            if (detailOut.UpdateQty >= 0)
            {
                throw new WmsException(ResultCode.StockNotEnough,
                    detailOut.BarCode + "." + detailOut.LocCode, "�������������޷��Ƴ�");
            }
            if (!loc.IsEnableNegativeStock && detailOut.Qty + detailOut.UpdateQty < 0)
            {
                throw new WmsException(ResultCode.StockNotEnough,
                    detailOut.BarCode + "." + detailOut.LocCode, "��������ϸ���㣬�޷��Ƴ�");

            }
            var stockDetail = Get(db, detailOut.BarCode, detailOut.LocCode);
            if (stockDetail == null) //�����ϸ�����ڣ�����
            {
                throw new WmsException(ResultCode.DataNotFound,
                    detailOut.BarCode + "." + detailOut.LocCode, "��������ϸ������");

            }
            else //�����ϸ���ڣ���������(����ʱ��������Ϊ��ֵ)
            {
                stockDetail.Qty += detailOut.UpdateQty;
                stockDetail.UpdateQty = detailOut.UpdateQty;
                stockDetail.UpdateTime = DateTime.Now;
            }
            if (loc.AutoRemoveZeroStockDetail && stockDetail.Qty == 0) //�Ƿ��Զ�����������ϸ
                db.TS_STOCK_DETAIL.Remove(stockDetail);
            StockController.Out(db, detailOut); //���¡������������

            TransactionLogController.Add(db, bill, detailOut); //��ӿ��������־
        }



        public static void ListIn(SpareEntities db, TB_BILL bill, List<TS_STOCK_DETAIL> details)
        {
            

            foreach (var detail in details)
            {
                In(db, bill, detail);
//                //����ERP�ӿ�
//                ErpInterfaceController.CreateRCT(db,detail.PartCode,detail.Qty,string.Empty, detail.LocCode,bill.BillNum,(BillType)(bill.BillType),bill.BillTime);
            }
        }

        public static void ListOut(SpareEntities db, TB_BILL bill, List<TS_STOCK_DETAIL> details)
        {
            foreach (var detail in details)
            {
                Out(db, bill, detail);
//                //����ERP�ӿ�
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
//                //����ERP�ӿ�
//                ErpInterfaceController.CreateTR(db, detail.PartCode, detail.Qty, detail.FromLocCode, detail.ToLocCode,detail.Batch,detail.Batch, bill.BillNum, (BillType)(bill.BillType), bill.BillTime);
            }
        }

        public static void ListMove(SpareEntities db, TB_BILL bill, List<TB_PACK_UNPACK> details)
        {
            foreach (var detail in details)
            {
                var detailOut = detail.ToStockDetailOut();
                Out(db, bill, detailOut);
                

                var detailIn = detail.ToStockDetailIn(db);
                In(db, bill, detailIn);
                
            }
        }


        public static void ListSell(SpareEntities db, string soNum, string sellDate,TB_BILL bill, List<TS_STOCK_DETAIL> stockDetailList,  string operName)
        {
            var loc = StoreLocationController.Get(db, SysConfig.LocCodeVinSale);
            var fromLocCode = loc == null ? String.Empty : loc.LocCode;
            foreach (var stockDetail in stockDetailList)
            {
                if (stockDetail.ProjectId == GlobalBuffer.GetProjectId(stockDetail.PartCode))
                {
                    var vinPartList = VinPartController.GetList(db, stockDetail.Batch, stockDetail.ProjectId);
                    ErpInterfaceController.CreateByVinPartList(db,  vinPartList, soNum, BillType.VinSell, fromLocCode,"");
                }
                else
                {
                    ErpInterfaceController.CreateSH(db, stockDetail.PartCode, stockDetail.Qty, soNum, fromLocCode, "", BillType.VinSell, DateTime.Now);

                }
                var detailout = stockDetail.Clone();
                detailout.UpdateQty = -stockDetail.Qty;
                detailout.UpdateTime = DateTime.Now;
                StockDetailController.Out(db, bill, detailout);
                //StockDetailController.Out(db, bill, stockDetail); TODO ��Ʒ����Ӧ���߱�׼����
                //                var tDetail = db.TS_STOCK_DETAIL.Single(p => p.UID == stockDetail.UID);
                //                tDetail.Qty = 0;
                //                tDetail.State = (int)VinState.Sold;
            }
            //TODO ��¼��־

        }

        public static List<VS_STOCK_DETAIL> GetVList(SpareEntities db, DateTime beginTime, DateTime endTime, int beginHour,int endHour, BillType billType)
        {
            string locCode = string.Empty;
            switch (billType)
            {
                case BillType.VinReceive:
                    locCode = SysConfig.LocCodeVinFg;
                    break;
                case BillType.VinDeliver:
                    locCode = SysConfig.LocCodeVinSale;
                    break;
            }
            var billList = db.VS_STOCK_DETAIL.Where(p =>
                p.UpdateTime >= beginTime
                && p.UpdateTime <= endTime
                && p.UpdateTime.Hour >= beginHour
                && p.UpdateTime.Hour < endHour
                && p.LocCode ==locCode
                ).OrderByDescending(p => p.UpdateTime).ToList();
            return billList;
        }

        public static List<VS_STOCK_DETAIL> GetVList(SpareEntities db, string areaCode = null)
        {
            var list = areaCode == null
                ? db.VS_STOCK_DETAIL.ToList()
                : db.VS_STOCK_DETAIL.Where(p => p.AreaCode == areaCode).ToList();
            return list;
        }

        public static List<TS_STOCK_DETAIL> GetTListByLocCode(SpareEntities db, string locCode)
        {
            return db.TS_STOCK_DETAIL.Where(p => p.LocCode == locCode).ToList();
        }

        public static TS_STOCK_DETAIL Get(SpareEntities db, string barCode, string locCode)
        {
            return db.TS_STOCK_DETAIL.Find(barCode, locCode);
//            return db.TS_STOCK_DETAIL.SingleOrDefault(p => p.BarCode == barCode && p.LocCode == locCode);
        }

        public static TS_STOCK_DETAIL Get(SpareEntities db, int uid)
        {
            return db.TS_STOCK_DETAIL.SingleOrDefault(p=>p.UID==uid);
            //            return db.TS_STOCK_DETAIL.SingleOrDefault(p => p.BarCode == barCode && p.LocCode == locCode);
        }


        public static TS_STOCK_DETAIL GetFirst(SpareEntities db, string vinCode, string projetId)
        {
            return db.TS_STOCK_DETAIL.FirstOrDefault(p => p.BarCode.Contains(vinCode) && p.ProjectId == projetId);
        }

        public static List<TS_STOCK_DETAIL> GetTListByBarCode(SpareEntities db, string barCode)
        {
            return db.TS_STOCK_DETAIL.Where(p => p.BarCode == barCode).ToList();

        }

        public static TS_STOCK_DETAIL GetFirst(SpareEntities db, string barCode)
        {
            return db.TS_STOCK_DETAIL.FirstOrDefault(p => p.BarCode == barCode);
        }

        private static void CheckStockDetailLoc(SpareEntities db, string locCode)
        {
            var loc = db.TA_STORE_LOCATION.Find(locCode);
            if (loc == null)
            {
                throw  new WmsException(ResultCode.DataNotFound, locCode, "��λ������");

            }
            if (loc.State == (int) DataState.Disabled)
            {
                throw new WmsException(ResultCode.DataStateError, locCode, "��λ������");
            }
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
            switch (part.ManageType)
            {
                case (int) ManageType.Batch:
                    detail.ProduceDate = pDate;
                    break;
                case (int) ManageType.SinglePack:
                    detail.ProduceDate = detail.ProduceDate;
                    break;
            }
            if (detail.ProduceDate != null)
                detail.OverdueDate = detail.ProduceDate.AddDays(part.ValidityDays);
        }

        public static List<TS_STOCK_DETAIL> GetTListByEqptCode(SpareEntities db, string eqptCode)
        {
            return db.TS_STOCK_DETAIL.Where(p => p.EqptCode == eqptCode).ToList();

        }

        public static List<TS_STOCK_DETAIL> GetTListByPartCode(SpareEntities db, string partCode)
        {
            return db.TS_STOCK_DETAIL.Where(p => p.PartCode == partCode).ToList();
        }

        public static decimal GetValidStockQty(SpareEntities db, string partCode, string batch, string locCode)
        {
            var allStockQty =
                db.TS_STOCK_DETAIL.Where(p => p.PartCode == partCode
                                              && p.Batch == batch
                                              && p.LocCode == locCode
                                              && p.State == (int)StockDetailState.Valid).Sum(s => s.Qty);
            var freezeQty = db.TS_STOCK_FREEZE.Where(p => p.PartCode == partCode
                                                          && p.Batch == batch).Sum(s => s.Qty);
            return allStockQty - freezeQty;
        }

        public static List<TS_STOCK_DETAIL> GetListByPartCode(SpareEntities db, string partCode)
        {
            return db.TS_STOCK_DETAIL.Where(p => p.PartCode == partCode).ToList();
        }

        public static List<TS_STOCK_DETAIL> GetList(SpareEntities db, string locCode)
        {
            return db.TS_STOCK_DETAIL.Where(p => p.LocCode == locCode).ToList();
        }
    }
}