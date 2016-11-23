using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using ChangKeTec.Wms.Models;

namespace ChangKeTec.PowerForm.Bll
{
    public static class MenuAController
    {
        public static List<TA_MENU> GetList(PowerEntities db)
        {
            return db.TA_MENU.OrderBy(p=>p.MenuCode).ToList();
        }

        public static void AddOrUpdate(PowerEntities db, TA_MENU selectedData, TS_OPERATOR oper)
        {
            try
            {
                db.TA_MENU.AddOrUpdate(p => p.MenuCode, selectedData);
            }
            catch (DbEntityValidationException dbEx)
            {
                Console.WriteLine(dbEx.ToString());
                throw;
            }
        }
        public static void Delete(PowerEntities db, TA_MENU data, TS_OPERATOR oper)
        {
            db.Entry(data).State = EntityState.Deleted;
        }
    }
}