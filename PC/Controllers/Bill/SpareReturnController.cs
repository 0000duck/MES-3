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

        public static List<TB_RETURN> OutToReturnList(TB_OUT materialOut)
        {
            List<TB_RETURN> partPickList = new List<TB_RETURN>();
            var partPick = new TB_RETURN
            {
                PartCode = materialOut.PartCode,
                Batch = materialOut.Batch,
                FromLocCode = "",
                ToLocCode = materialOut.FromLocCode,
                OutQty = materialOut.OutQty,
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
                TakeTime = materialOut.TakeTime,
                ReturnUser = materialOut.TakeUser,
                ReturnTime = DateTime.Now,
            };           
            return partPickList;
        }
    }
}