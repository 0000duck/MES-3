using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;

namespace ChangKeTec.Wms.Controllers.Bill
{
    public static class NotifyController
    {
        public static List<TL_NOTIFY> GetNewList(SpareEntities db)
        {
            List<TL_NOTIFY> list =new List<TL_NOTIFY>();
            DateTime lastdate = DateTime.Now.AddDays(-1);
            try
            {

          
            list= db.TL_NOTIFY.Where(p => 
                p.State == (int)BillState.New
                || (p.CreateTime>=lastdate)
                ).OrderByDescending(p=>p.UID).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return list;
        }

        public static List<TL_NOTIFY> GetNewList(SpareEntities db,List<TS_ROLE_NOTIFYTYPE> notifytypeList)
        {
            List<TL_NOTIFY> list = new List<TL_NOTIFY>();
            try
            {
                var typeList = notifytypeList.Select(n => n.NotifyType);
                var l = db.TL_NOTIFY.Where(p => typeList.Contains(p.NotifyType));
                var t = DateTime.Now.AddDays(-1);
                list =l.Where(p=>p.State == (int)BillState.New||p.CloseTime>=t).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return list;
        }

        private static void AddOrUpdateNotify(SpareEntities db, TL_NOTIFY notify)
        {
            db.TL_NOTIFY.AddOrUpdate(p=>p.UID,notify);
        }

        public static void CloseNotify(SpareEntities db,string operName, TL_NOTIFY notify)
        {
            notify.CloseOperName = operName;
            notify.CloseTime = DateTime.Now;
            notify.State = (int) BillState.Finished;
            AddOrUpdateNotify(db, notify);
        }

        public static void CloseNotifyList(SpareEntities db,string operName, List<TL_NOTIFY> list)
        {
            foreach (TL_NOTIFY notify in list)
            {
               CloseNotify(db,operName,notify);
            }
        }

        public static void AddNotify(SpareEntities db, string operName, NotifyType notifyType, string billNum,string message)
        {
            var notify = new TL_NOTIFY
            {
                NotifyType = (int)notifyType,
                BillNum = billNum,
                NotifyMessage =  message,
                CreateOperName = operName,
                CreateTime = DateTime.Now,
                State = (int)BillState.New,
                CloseOperName = "",
                CloseTime = new DateTime(1970,1,1),

            };
            db.TL_NOTIFY.Add(notify);
        }

        public static void AddStockNotify(SpareEntities db, string OperName)
        {
            var InactionList = db.VIEW_CalInaction_DAYS.ToList();
            var OverdueList = db.VIEW_CalOverdue_DAYS.ToList();
            if (InactionList.Count > 0)
            {
                if (
                    db.TL_NOTIFY.FirstOrDefault(p => p.CreateTime.Date == DateTime.Now.Date && p.NotifyType == (int)NotifyType.StockInaction) == null)
                {
                    AddNotify(db,OperName, NotifyType.StockInaction,"","");
                }
            }
            if (InactionList.Count > 0)
            {
                if (
                    db.TL_NOTIFY.FirstOrDefault(p => p.CreateTime.Date == DateTime.Now.Date && p.NotifyType == (int)NotifyType.StockOverdue) == null)
                {
                    AddNotify(db, OperName, NotifyType.StockOverdue, "", "");
                }
            }
        }
    }
}