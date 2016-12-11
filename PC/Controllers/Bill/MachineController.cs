using System.Linq;
using ChangKeTec.Wms.Models;

namespace ChangKeTec.Wms.Controllers.Bill
{
    public static class MachineController
    {


        public static TA_MACHINE Get(SpareEntities rdb, string eqptCode)
        {
            return rdb.TA_MACHINE.SingleOrDefault(p => p.MachineCode == eqptCode);
        }
    }
}