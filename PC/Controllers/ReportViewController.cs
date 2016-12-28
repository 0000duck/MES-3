using System;
using System.Collections.Generic;
using System.Linq;
using ChangKeTec.Wms.Models;

namespace ChangKeTec.Wms.Controllers
{
    public static class ReportViewController
    {
        /// <summary>
        /// ������ͼ������Ԥ������ǰ30��
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<VIEW_CalOverdue_DAYS> GetOverdueDaysList(SpareEntities db)
        {
            return db.VIEW_CalOverdue_DAYS.ToList();           
        }

        /// <summary>
        /// ������ͼ���㰲ȫ����
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<VIEW_CalSafeQty> GetSafeQtysList(SpareEntities db)
        {
            return db.VIEW_CalSafeQty.ToList();
        }

        /// <summary>
        /// ������ͼ��ѯ�̵�����
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<VIEW_INVENTORY_DETAIL> GetInventoryDetail(SpareEntities db)
        {
            return db.VIEW_INVENTORY_DETAIL.ToList();
        }

        /// <summary>
        /// ������ͼ��ѯ�����ϸ���
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<VIEW_STOCK_DETAIL> GetStockDetail(SpareEntities db)
        {
            return db.VIEW_STOCK_DETAIL.ToList();
        }

        /// <summary>
        /// ������ͼ��ѯ�����ͱ� һ��û���ƶ���
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<VIEW_CalInaction_DAYS> GetCalInaction(SpareEntities db)
        {
            return db.VIEW_CalInaction_DAYS.ToList();
        }

        /// <summary>
        /// ������ͼ��ѯ����ڿ�ʱ����
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<VIEW_STOCK_DETAIL_AGE> GetStockDetailAge(SpareEntities db)
        {
            return db.VIEW_STOCK_DETAIL_AGE.ToList();
        }

        /// <summary>
        /// ����������ܱ�
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
                    
                    //����ɸѡ�Ľ���ʱ�䵽��ǰʱ��ķ�����
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
                    IOSum.�ⷿ = store.WhseCode;
                    IOSum.����� = part.PartCode;
                    IOSum.������� = TranIn.Sum(p => p.Qty);
                    IOSum.����� = TranIn.Sum(p => p.Qty*p.UnitPrice);
                    IOSum.�������� = 0-TranOut.Sum(p => p.Qty);
                    IOSum.������ = 0-TranOut.Sum(p => p.Qty * p.UnitPrice);
                    IOSum.��ǰ��� = CalStock.Sum(p => p.Qty);
                    IOSum.��ǰ����� = CalStock.Sum(p => p.Qty*p.UnitPrice);
                    IOSum.������� = IOSum.��ǰ��� - TranNowIn.Sum(p=>p.Qty) + (0-TranNowOut.Sum(p=> p.Qty));
                    IOSum.��������� = IOSum.��ǰ����� - TranNowIn.Sum(p => p.Qty*p.UnitPrice) + (0 - TranNowOut.Sum(p => p.Qty*p.UnitPrice));
                    IOSum.��ʼ��� = IOSum.������� - IOSum.������� + IOSum.��������;
                    IOSum.��ʼ����� = IOSum.��������� - IOSum.����� + IOSum.������;
                    if (IOSum.������� == 0 && IOSum.�������� == 0 && IOSum.��ǰ��� == 0)
                        continue;

                    detailList.Add(IOSum);
                }
            }
            return detailList;
        }
    }
}