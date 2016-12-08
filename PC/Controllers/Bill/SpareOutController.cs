using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;

namespace ChangKeTec.Wms.Controllers.Bill
{
    public static class SpareOutController
    {
        public static void AddList(SpareEntities db, List<TB_OUT> details)
        {
            db.TB_OUT.AddRange(details);
        }

        public static List<TB_OUT> GetList(SpareEntities db, string billNum)
        {
            return db.TB_OUT.Where(p => p.BillNum == billNum).ToList();
        }


        public static void UpdateList(SpareEntities db, List<TB_OUT> details)
        {
            db.TB_OUT.AddOrUpdate(p => p.UID, details.ToArray());
        }

        public static List<TB_OUT> GetList(TB_ASK materialAsk, List<TS_STOCK_DETAIL> stockDetailList)
        {
            List<TB_OUT> partPickList = new List<TB_OUT>();
            if (stockDetailList.Count == 0)
                return partPickList;
            var stockDetail = stockDetailList.OrderBy(p => p.Batch).First();//FIFO
            var partPick = new TB_OUT
            {
                PartCode = materialAsk.PartCode,
                Batch = stockDetail.Batch,
                BillQty = materialAsk.Qty,
                FromLocCode = stockDetail.LocCode,
                UnitPrice = stockDetail.UnitPrice,
                DeptCode = materialAsk.DeptCode,
                ProjectCode = materialAsk.ProjectCode,
                WorklineCode = materialAsk.WorklineCode,
                EqptCode = materialAsk.EqptCode,
                AskUser = materialAsk.AskUser,
                AskTime = materialAsk.AskTime,
                ConfirmUser = materialAsk.ConfirmUser,
                ConfirmTime = materialAsk.ConfirmTime,
            };
            if (stockDetail.Qty >= materialAsk.Qty)
            {
                partPick.OutQty = materialAsk.Qty;         
                partPick.Amount = partPick.UnitPrice* partPick.OutQty;
                partPickList.Add(partPick);
            }
            else
            {
                partPick.OutQty = stockDetail.Qty;
                partPick.Amount = partPick.UnitPrice * partPick.OutQty;
                partPickList.Add(partPick);
                stockDetailList.Remove(stockDetail);
                partPick.OutQty -= stockDetail.Qty;
                var pList = GetList(materialAsk, stockDetailList);
                partPickList.AddRange(pList);
            }
            return partPickList;
        }

        internal static List<TB_OUT> GetList(SpareEntities db, TB_ASK materialAsk)
        {
            List<TB_OUT> partPickList = new List<TB_OUT>();

            var stockDetailList = StockDetailController.GetListByPartCode(db, materialAsk.PartCode).Where(p => p.Qty > 0).ToList();
            if (stockDetailList.Count == 0) return partPickList;

            partPickList = SpareOutController.GetList(materialAsk, stockDetailList);
            return partPickList;
        }
    }
}