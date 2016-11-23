using System.Collections.Generic;
using System.Linq;
using ChangKeTec.Wms.Models;

namespace ChangKeTec.Wms.Controllers.Bill
{
    public static class SpareAskController
    {
        public static void AddList(SpareEntities db, List<TB_ASK> sortDetailList)
        {
            db.TB_ASK.AddRange(sortDetailList);
        }

        public static List<TB_ASK> GetList(SpareEntities db, string billNum)
        {
            return db.TB_ASK.Where(p => p.BillNum == billNum).ToList();
        }
    }
}