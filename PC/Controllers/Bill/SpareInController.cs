using System.Collections.Generic;
using System.Linq;
using ChangKeTec.Wms.Models;

namespace ChangKeTec.Wms.Controllers.Bill
{
    public static class SpareInController
    {
        public static void AddList(SpareEntities db, List<TB_IN> sortDetailList)
        {
            db.TB_IN.AddRange(sortDetailList);
        }

        public static IEnumerable<TB_IN> GetList(SpareEntities db, string billNum)
        {
            return db.TB_IN.Where(p => p.BillNum == billNum);
        }
    }
}