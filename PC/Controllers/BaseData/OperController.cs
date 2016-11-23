using System;
using System.Data.Entity.Migrations;
using System.Linq;
using ChangKeTec.Wms.Models;

namespace ChangKeTec.Wms.Controllers.BaseData
{
    public static class OperController
    {
        public static TS_OPERATOR Login(PowerEntities db, string code, string password)
        {
            var oper = db.TS_OPERATOR.SingleOrDefault(p => p.OperCode == code && p.OperPassword == password);
            return oper;
        }
       
        public static void AddOrModify(PowerEntities db, TS_OPERATOR oper)
        {
            db.TS_OPERATOR.AddOrUpdate(p => p.OperCode, oper);
            //            var op = db.TS_OPERATOR.SingleOrDefault(p => p.UID == oper.UID);
            //            if (op == null)
            //                db.TS_OPERATOR.CreateStockMove(oper);
            //            else
            //            {
            //                op.Name = oper.OperName;
            //                op.Password = oper.Password;
            //                op.Dept = oper.Dept;
            //                op.Role = oper.Role;
            //                op.State = oper.State;
            //            }


        }

        public static void Logout(PowerEntities db, string operName)
        {
            throw new NotImplementedException();
        }
    }
}