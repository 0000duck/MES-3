using System.Collections.Generic;
using System.Linq;
using ChangKeTec.Wms.Models;

namespace ChangKeTec.Wms.Controllers.BaseData
{
    public static class ConfigController
    {
        public static List<TA_CONFIG> GetList(SpareEntities db)
        {
            return db.TA_CONFIG.OrderByDescending(p=>p.UID).ToList();
        }
    }
}