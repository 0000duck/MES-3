using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using ChangKeTec.Wms.Models;

namespace ChangKeTec.Wms.Controllers.Bill
{
    public static class OtherInController
    {
        public static void AddList(SpareEntities db, List<TB_OTHER_IN> sortDetailList)
        {
            db.TB_OTHER_IN.AddRange(sortDetailList);
        }

        public static IEnumerable<TB_OTHER_IN> GetList(SpareEntities db, string billNum)
        {
            return db.TB_OTHER_IN.Where(p => p.BillNum == billNum);
        }

        public static void AddOrUpdate(SpareEntities db, TB_OTHER_IN otherin)
        {
            db.TB_OTHER_IN.AddOrUpdate(p => p.UID, otherin);
        }
    }

    public static class OtherOutController
    {
        public static void AddList(SpareEntities db, List<TB_OTHER_OUT> sortDetailList)
        {
            db.TB_OTHER_OUT.AddRange(sortDetailList);
        }

        public static IEnumerable<TB_OTHER_OUT> GetList(SpareEntities db, string billNum)
        {
            return db.TB_OTHER_OUT.Where(p => p.BillNum == billNum);
        }

        public static void AddOrUpdate(SpareEntities db, TB_OTHER_OUT otherin)
        {
            db.TB_OTHER_OUT.AddOrUpdate(p => p.UID, otherin);
        }
    }
}