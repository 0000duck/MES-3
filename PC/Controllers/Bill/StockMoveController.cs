using System.Collections.Generic;
using System.Linq;
using ChangKeTec.Wms.Models;

namespace ChangKeTec.Wms.Controllers.Bill
{
    public static class StockMoveController
    {
        public static void AddList(SpareEntities db, List<TB_STOCK_MOVE> sortDetailList)
        {
            db.TB_STOCK_MOVE.AddRange(sortDetailList);
        }

        public static IEnumerable<TB_STOCK_MOVE> GetList(SpareEntities db, string billNum)
        {
            return db.TB_STOCK_MOVE.Where(p => p.BillNum == billNum);
        }

        public static TB_STOCK_MOVE Get(SpareEntities db, string billNum, string barcode, string toLocCode)
        {
            return db.TB_STOCK_MOVE.SingleOrDefault(p => p.BillNum == billNum&&p.BarCode==barcode&&p.ToLocCode==toLocCode);
        }
    }
}