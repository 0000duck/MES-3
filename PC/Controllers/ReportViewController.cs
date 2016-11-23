using System;
using System.Collections.Generic;
using ChangKeTec.Wms.Models;

namespace ChangKeTec.Wms.Controllers
{
    public static class ReportViewController
    {
        /// <summary>
        /// ����������ܱ�
        /// </summary>
        /// <param name="db"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public static List<VIEW_IO_SUMMARY> GetIoSummarysDetailList(SpareEntities db, DateTime beginTime, DateTime endTime)
        {
            var detailList = new List<VIEW_IO_SUMMARY>();            
            var PartList = db.TA_PART.ToList();
            var TranList = db.TL_TRANSACTION.ToList();
            var StockList = db.TS_STOCK.ToList();
            var BillCalc = db.TA_BILLTYPE.Where(p => !p.IsCalc).Select(x => x.BillType).ToList();
            foreach (var part in PartList)
            {                
                var TranIn =
                    TranList.Where(
                        p =>
                            p.LogTime >= beginTime && p.LogTime <= endTime && BillCalc.Contains(p.BillType) &&
                            p.PartCode == part.PartCode && p.Remark == "In");
                var TranOut =
                    TranList.Where(
                        p =>
                            p.LogTime >= beginTime && p.LogTime <= endTime && BillCalc.Contains(p.BillType) && 
                            p.PartCode == part.PartCode && p.Remark == "Out");
                var CalStock = StockList.Where(p => p.PartCode == part.PartCode);
                var IOSum = new VIEW_IO_SUMMARY();
                IOSum.����� = part.PartCode;
                IOSum.������� = TranIn.Sum(p => p.Qty);
                IOSum.�������� = TranOut.Sum(p => p.Qty);
                IOSum.������� = CalStock.Sum(p => p.Qty);
                if(IOSum.�������==0&& IOSum.��������==0&& IOSum.�������==0)
                    continue;
                detailList.Add(IOSum);
            }
            return detailList;
        }

        /// <summary>
        /// ����������ܱ�
        /// </summary>
        /// <param name="db"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public static List<VIEW_IO_SUMMARY_ByArea> GetIoSummarysByAreaDetailList(SpareEntities db, DateTime beginTime, DateTime endTime)
        {
            var detailList = new List<VIEW_IO_SUMMARY_ByArea>();
            var PartList = db.TA_PART.ToList();
            var TranList = db.TL_TRANSACTION.ToList();
            var StockList = db.TS_STOCK.ToList();
            var StoreAreaList = db.TA_STORE_AREA.ToList();
            var BillCalc = db.TA_BILLTYPE.Where(p => !p.IsCalc).Select(x => x.BillType).ToList();
            foreach (var part in PartList)
            {
                foreach (var area in StoreAreaList)
                {
                    var LocList =
                        db.TA_STORE_LOCATION.Where(p => p.AreaCode == area.AreaCode).Select(x => x.LocCode).ToList();
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
                    var CalStock = StockList.Where(p => p.PartCode == part.PartCode);
                    var IOSum = new VIEW_IO_SUMMARY_ByArea();
                    IOSum.����� = part.PartCode;
                    IOSum.������� = TranIn.Sum(p => p.Qty);
                    IOSum.�������� = TranOut.Sum(p => p.Qty);
                    IOSum.������� = CalStock.Sum(p => p.Qty);
                    IOSum.���� = area.AreaCode;
                    if (IOSum.������� == 0 && IOSum.�������� == 0 && IOSum.������� == 0)
                        continue;
                    detailList.Add(IOSum);
                }

            }
            return detailList;
        }

        /// <summary>
        /// ������ͼ�����ڿ�����
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<VIEW_STOCKDETAIL_DAYS> GetStockDaysList(SpareEntities db)
        {
            return db.VIEW_STOCKDETAIL_DAYS.ToList();
        }
        /// <summary>
        /// ������ͼ�����ڷ�Χ��ѯ�������ˮ��
        /// </summary>
        /// <param name="db"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public static List<VIEW_TRANSACTION> GetTransaticonList(SpareEntities db, DateTime beginTime, DateTime endTime)
        {
            var detailList = new List<VIEW_TRANSACTION>();
            detailList = db.VIEW_TRANSACTION.Where(p => p.��־ʱ�� >= beginTime && p.��־ʱ�� <= endTime).OrderByDescending(p=>p.��־ʱ��).ToList();
            return detailList;
        }

        /// <summary>
        /// ������ͼ������Ԥ������ǰ30��
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<VIEW_CalOverdue_DAYS> GetOverdueDaysList(SpareEntities db)
        {
            return db.VIEW_CalOverdue_DAYS.ToList();
        }

        public static List<VIEW_CalSafeQty> GetSafeQtyList(SpareEntities db)
        {
            return db.VIEW_CalSafeQty.ToList();
        } 
    }
}