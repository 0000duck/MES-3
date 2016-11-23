using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using ChangKeTec.Wms.Models;

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

    }
}