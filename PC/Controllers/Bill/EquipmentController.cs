using System.Linq;
using ChangKeTec.Wms.Models;

namespace ChangKeTec.Wms.Controllers.Bill
{
    public static class EquipmentController
    {


        public static TA_EQUIPMENT Get(SpareEntities rdb, string eqptCode)
        {
            return rdb.TA_EQUIPMENT.SingleOrDefault(p => p.EqptCode == eqptCode);
        }
    }
}