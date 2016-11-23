using System.Collections.Generic;
using System.Linq;
using ChangKeTec.Wms.Controllers.Log;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;

namespace ChangKeTec.Wms.Controllers.Bill
{
    public static class PoController
    {

        public static List<TB_PO> GetDetailList(SpareEntities db, string billNum)
        {
            var list = db.TB_PO.Where(p => p.BillNum == billNum).ToList();
            foreach (var podetail in list)
            {
                var part = db.TA_PART.FirstOrDefault(p => p.PartCode == podetail.PartCode);
                if(part==null)continue;
                podetail.PackQty = part.SplyPackQty;
                //                podetail.PackCount = (int)podetail.BillQty/(int)podetail.PackQty;
                //                podetail.OtherQty = podetail.BillQty%podetail.PackQty;
                podetail.PackCount = 0;
                podetail.OtherQty = 0;
            }
            return list;
        }

        public static void UpdateState(SpareEntities db, TB_PO bill, BillState state)
        {
            bill.State = (int)state;//更新【单据】状态为：完成
            OperateType operType;
            switch (state)
            {
                case BillState.New:
                case BillState.Handling:
                    operType = OperateType.Update;
                    break;
                case BillState.Finished:
                    operType = OperateType.Finish;
                    break;
                case BillState.Cancelled:
                    operType = OperateType.Cancel;
                    break;
                default:
                    operType = OperateType.Update;
                    break;
            }
            BillLogController.Add(db, bill, bill.OperName, operType); //创建【单据日志】
        }

        public static void AddPoList(SpareEntities db, List<TB_PO> billList, List<TB_PO> detailList)
        {
            foreach (TB_PO bill in billList)
            {
                if (db.TB_PO.Any(p => p.BillNum == bill.BillNum))
                {
                    throw new WmsException(ResultCode.DataAlreadyExist, bill.BillNum, "单据号已存在");
                }
                db.TB_PO.Add(bill);
                db.TB_PO.AddRange(detailList);
            }

        }
    }
}