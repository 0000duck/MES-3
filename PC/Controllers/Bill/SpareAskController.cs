using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

        public static void AddOrUpdate(SpareEntities db, TB_ASK ask)
        {
            db.TB_ASK.AddOrUpdate(p=>p.UID,ask);
        }
    }
}