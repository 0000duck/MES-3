using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using ChangKeTec.Wms.Models;

namespace ChangKeTec.PowerForm.Bll
{
    public static class RoleController
    {
        public static List<TS_ROLE> GetList(PowerEntities db)
        {
            return db.TS_ROLE.OrderBy(p=>p.RoleCode).ToList();
        }

        public static void Delete(PowerEntities db, TS_ROLE data, TS_OPERATOR oper)
        {
            db.Entry(data).State = EntityState.Deleted;
        }

        public static void AddOrUpdate(PowerEntities db, TS_ROLE selectedData, TS_OPERATOR oper)
        {
            try
            {
                db.TS_ROLE.AddOrUpdate(p => p.RoleCode, selectedData);
            }
            catch (DbEntityValidationException dbEx)
            {
                Console.WriteLine(dbEx.ToString());
                throw;
            }
        }
    }
}