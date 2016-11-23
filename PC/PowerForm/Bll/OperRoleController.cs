using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using ChangKeTec.Wms.Models;

namespace ChangKeTec.PowerForm.Bll
{
    public static class OperRoleController
    {
        public static List<TS_OPER_ROLE> GetList(PowerEntities db)
        {
            return db.TS_OPER_ROLE.OrderBy(p=>p.OperCode).ToList();
        }

        public static void AddOrUpdate(PowerEntities db, TS_OPER_ROLE selectedData, TS_OPERATOR oper)
        {
            try
            {
                db.TS_OPER_ROLE.AddOrUpdate(p => p.UID, selectedData);
            }
            catch (DbEntityValidationException dbEx)
            {
                Console.WriteLine(dbEx.ToString());
                throw;
            }
        }

        public static void Delete(PowerEntities db, TS_OPER_ROLE data, TS_OPERATOR oper)
        {
            db.Entry(data).State = EntityState.Deleted;
        }
    }
}