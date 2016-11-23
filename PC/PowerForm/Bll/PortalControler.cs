using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using ChangKeTec.Wms.Models;

namespace ChangKeTec.PowerForm.Bll
{
    public static class PortalControler
    {
        public static List<TS_PORTAL> GetList(PowerEntities db)
        {
            return db.TS_PORTAL.OrderBy(p=>p.PortalCode).ToList();
        }

        public static void AddOrUpdate(PowerEntities db, TS_PORTAL selectedData, TS_OPERATOR oper)
        {
            try
            {
                db.TS_PORTAL.AddOrUpdate(p => p.PortalCode, selectedData);
            }
            catch (DbEntityValidationException dbEx)
            {
                Console.WriteLine(dbEx.ToString());
                throw;
            }
        }
        public static void Delete(PowerEntities db, TS_PORTAL data, TS_OPERATOR oper)
        {
            db.Entry(data).State = EntityState.Deleted;
        }
    }
}