using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using ChangKeTec.Wms.Models;

namespace ChangKeTec.PowerForm.Bll
{
    public static class OperController
    {
        public static TS_OPERATOR CheckUser(PowerEntities db, string code, string password)
        {
            var oper = db.TS_OPERATOR.SingleOrDefault(p => p.OperCode == code && p.OperPassword == password);
            return oper;
        }
        public static List<TS_OPERATOR> GetList(PowerEntities db)
        {
            return db.TS_OPERATOR.OrderBy(p => p.OperCode).ToList();
        }

        public static void AddOrUpdate(PowerEntities db, TS_OPERATOR selectedData, TS_OPERATOR oper)
        {
            try
            {
                db.TS_OPERATOR.AddOrUpdate(p => p.OperCode, selectedData);
            }
            catch (DbEntityValidationException dbEx)
            {
                Console.WriteLine(dbEx.ToString());
                throw;
            }
        }
        public static void Delete(PowerEntities db, TS_OPERATOR data, TS_OPERATOR oper)
        {
            db.Entry(data).State = EntityState.Deleted;
        }

    
    }
}