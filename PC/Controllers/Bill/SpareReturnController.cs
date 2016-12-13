using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;

namespace ChangKeTec.Wms.Controllers.Bill
{
    public static class SpareReturnController
    {
        public static void AddList(SpareEntities db, List<TB_RETURN> details)
        {
            db.TB_RETURN.AddRange(details);
        }

        public static List<TB_RETURN> GetList(SpareEntities db, string billNum)
        {
            return db.TB_RETURN.Where(p => p.BillNum == billNum).ToList();
        }


        public static void UpdateList(SpareEntities db, List<TB_RETURN> details)
        {
            db.TB_RETURN.AddOrUpdate(p => p.UID, details.ToArray());
        }

        public static TB_RETURN OutToReturnList(TB_OUT materialOut)
        {
            var partPick = new TB_RETURN
            {
                PartCode = materialOut.PartCode,
                Batch = materialOut.Batch,
                FromLocCode = "",
                ToLocCode = materialOut.FromLocCode,
                OutQty = (decimal)materialOut.OutQty,
                InQty = materialOut.OutQty,
                UnitPrice = materialOut.UnitPrice,
                Amount = materialOut.Amount,
                DeptCode = materialOut.DeptCode,
                ProjectCode = materialOut.ProjectCode,
                WorklineCode = materialOut.WorklineCode,
                EqptCode = materialOut.EqptCode,
                AskUser = materialOut.AskUser,
                AskTime = materialOut.AskTime,
                ConfirmUser = materialOut.ConfirmUser,
                ConfirmTime = materialOut.ConfirmTime,
                TakeUser = materialOut.TakeUser,
                TakeTime = (DateTime)materialOut.TakeTime,
                ReturnUser = materialOut.TakeUser,
                ReturnTime = DateTime.Now,
            };           
            return partPick;
        }

        public static void AddOrUpdate(SpareEntities db, TB_RETURN sparereturn)
        {
            db.TB_RETURN.AddOrUpdate(p => p.UID, sparereturn);
        }

        public static void RemaveDetail(SpareEntities db, TB_RETURN detail)
        {
            db.TB_RETURN.Remove(detail);
        }
    }
}