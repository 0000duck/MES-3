using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Threading.Tasks;
using ChangKeTec.Wms.Controllers.BaseData;
using ChangKeTec.Wms.Controllers.Log;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;
using System.Linq;

namespace ChangKeTec.Wms.Controllers.Bill
{
    public static class BillController
    {
        public static List<TB_BILL> GetList(SpareEntities db,DateTime beginTime, DateTime endTime, BillType billType)
        {
            var billList = db.TB_BILL.Where(p => 
            p.BillTime >= beginTime 
            && p.BillTime <= endTime
            && p.BillType == (int)billType
            ).OrderByDescending(p=>p.BillTime).AsNoTracking().ToList();
            return billList;
        }

        public static List<TB_BILL> GetList(SpareEntities db, DateTime beginTime, DateTime endTime, int beginHour, int endHour, BillType billType)
        {
            var billList = db.TB_BILL.Where(p =>
            p.BillTime >= beginTime
            && p.BillTime <= endTime
            && p.BillTime.Hour>=beginHour
            && p.BillTime.Hour <endHour
            && p.BillType == (int)billType
            ).OrderByDescending(p => p.UID).AsNoTracking().ToList();
            return billList;
        }

        public static async Task <List<TB_BILL>> GetListAsync(SpareEntities db, DateTime beginTime, DateTime endTime, int beginHour, int endHour, BillType billType)
        {
           var billList =await db.TB_BILL.Where(p =>
            p.BillTime >= beginTime
            && p.BillTime <= endTime
            && p.BillTime.Hour >= beginHour
            && p.BillTime.Hour < endHour
            && p.BillType == (int)billType
            ).OrderByDescending(p => p.BillTime).AsNoTracking().ToListAsync();
            return billList;
        }


        public static List<TB_BILL> GetList(SpareEntities db, BillType billType)
        {
            var billList =
                db.TB_BILL.Where(p =>
                p.BillType == (int)billType 
                && p.State == (int)BillState.New)
                    .OrderByDescending(p => p.BillTime)
                    .AsNoTracking()
                    .ToList();
            return billList;
        }

        public static TB_BILL GetBill(SpareEntities db, int uid)
        {
            return db.TB_BILL.SingleOrDefault(p => p.UID == uid);
        }

        public static List<TB_BILL> GetListByFunc(SpareEntities db,Func<TB_BILL, bool> preFunc)
        {
            var billList = db.TB_BILL.Where(preFunc).ToList();
            return billList;
        }

        public static void AddOrUpdate(SpareEntities db, TB_BILL bill)
        {
            db.TB_BILL.AddOrUpdate(p => p.BillNum, bill);
            BillLogController.Add(db, bill, bill.OperName, OperateType.Add); //创建【单据日志】
        }

        public static void AddList(SpareEntities db,IList<TB_BILL> billList)
        {
            db.TB_BILL.AddRange(billList);
            var logType = LogType.BillCreate;
            try
            {
                foreach (TB_BILL bill in billList)
                {
                    OperLogController.AddLog(db,logType, bill.OperName, billList.ToString());
                }
            }
            catch (DbEntityValidationException dbEx)
            {
                Console.WriteLine(dbEx.ToString());
                throw;
            }
        }

        public static TB_BILL GetBill(SpareEntities db,string billNum)
        {
            var bill = db.TB_BILL.Find(billNum);
            return bill;
        }

        public static void UpdateState(SpareEntities db, TB_BILL bill, BillState state)
        {
            bill.State = (int)state;//更新【单据】状态为：完成
            OperateType operType;
            switch (state)
            {
                case BillState.New:
                case BillState.Handling:
                    bill.StartTime = DateTime.Now.ToString(SysConfig.LongTimeString);
                    operType = OperateType.Update;
                    break;
                case BillState.Finished:
                    bill.FinishTime = DateTime.Now.ToString(SysConfig.LongTimeString);
                    operType = OperateType.Finish;
                    break;
                case BillState.Cancelled:
                    bill.FinishTime = DateTime.Now.ToString(SysConfig.LongTimeString);
                    operType = OperateType.Cancel;
                    break;
                default:
                    bill.StartTime = DateTime.Now.ToString(SysConfig.LongTimeString);
                    operType = OperateType.Update;
                    break;
            }
            BillLogController.Add(db, bill, bill.OperName, operType); //创建【单据日志】
        }
/*

        public static void Finish(SpareEntities db, TB_BILL bill)
        {
            bill.State = (int) BillState.Finished; //更新【单据】状态为：完成
            BillLogController.Add(db, bill, bill.OperName, OperateType.Finish); //创建【单据日志】
        }


        public static void Cancel(SpareEntities db, TB_BILL bill)
        {
            bill.State = (int) BillState.Cancelled; //更新【单据】状态为：取消
            BillLogController.Add(db, bill, bill.OperName, OperateType.Cancel); //创建【单据日志】
        }

        public static void Handled(SpareEntities db, TB_BILL bill)
        {
            bill.State = (int) BillState.Handling; //更新【单据】状态为：执行中
            BillLogController.Add(db, bill, bill.OperName, OperateType.Update); //创建【单据日志】
        }
*/

        public static TB_BILL GetBillByVinCode(SpareEntities db,BillType billType,string vinCode)
        {
            return db.TB_BILL.SingleOrDefault(p => p.BillType == (int) billType && p.SourceBillNum == vinCode);
        }
    }
}
