using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using ChangKeTec.Wms.Models;

namespace ChangKeTec.PowerForm.Bll
{
    public static class DeptController
    {
        public static List<TS_DEPT> GetList(PowerEntities db)
        {
            return db.TS_DEPT.OrderBy(p=>p.DeptCode).ToList();
        }

        public static void Delete(PowerEntities db, TS_DEPT data, TS_OPERATOR oper)
        {
            db.Entry(data).State = EntityState.Deleted;
        }

        public static void AddOrUpdate(PowerEntities db, TS_DEPT selectedData, TS_OPERATOR oper)
        {
            try
            {
                db.TS_DEPT.AddOrUpdate(p => p.DeptCode, selectedData);
            }
            catch (DbEntityValidationException dbEx)
            {
                Console.WriteLine(dbEx.ToString());
                throw;
            }
        }
    }
}