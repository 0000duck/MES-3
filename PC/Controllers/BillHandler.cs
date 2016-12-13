using System;
using System.Collections.Generic;
using System.Linq;
using ChangKeTec.Wms.Controllers.BaseData;
using ChangKeTec.Wms.Controllers.Bill;
using ChangKeTec.Wms.Controllers.Interface;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;

namespace ChangKeTec.Wms.Controllers
{
    public static class BillHandler
    {
        /// <summary>
        ///     添加移库单，原料入库，成品入库，原料发货，成品出库，其它移库等等都当做移库处理，以SubBillType进行区分
        /// </summary>
        /// <param name="db"></param>
        /// <param name="bill"></param>
        /// <param name="details"></param>
        /// <returns></returns>
        public static void AddStockMove(SpareEntities db, TB_BILL bill, List<TB_STOCK_MOVE> details)
        {
            SetBillNum(bill); //设置单据编号
            details.ForEach(p => p.BillNum = bill.BillNum); //设置明细编号
            BillController.AddOrUpdate(db, bill); //添加【移库单】单据
            StockMoveController.AddList(db, details); //添加【移库单】明细
            StockDetailController.ListMove(db, bill, details); //更新【库存主表】【库存明细】
        }

        /// <summary>
        ///     添加【其它出入库单】
        /// </summary>
        /// <param name="db"></param>
        /// <param name="bill">其它出入库单</param>
        /// <param name="details">其它出入库明细</param>
        /// <returns></returns>
        public static void AddOtherIn(SpareEntities db, TB_BILL bill, List<TB_OTHER_IN> details)
        {
            {
                SetBillNum(bill); //设置单据编号
                details.ForEach(p => p.BillNum = bill.BillNum); //设置明细编号
                BillController.AddOrUpdate(db, bill); //添加单据
                foreach (var detail in details)
                {
                    OtherInController.AddOrUpdate(db, detail); //添加明细
                }
                
                var subBillType = (SubBillType) bill.SubBillType;
                switch (subBillType)
                {
                    //出库
                    case SubBillType.OtherOut: //其它出库
//                    case SubBillType.ReturnToSupplier: //原料退货
                    case SubBillType.InventoryLoss: //盘亏
                    case SubBillType.ScrapDestroy: //报废销毁
//                        var detailsOut = details.Select(detail => detail.ToStockDetailOut(bill)).ToList();
//                         StockDetailController.ListOut(db, bill, detailsOut); //更新【库存主表】【库存明细】出库
//                       
                        break;
                    //入库
                    case SubBillType.OtherIn: //其它入库
//                    case SubBillType.ProductReturn: //成品退货
                    case SubBillType.InventoryProfit: //盘盈
                        var detailsIn = details.Select(detail => detail.ToStockDetailIn(bill)).ToList();
                         StockDetailController.ListIn(db, bill, detailsIn); //更新【库存主表】【库存明细】入库
                       
                        break;
                    case SubBillType.ProductUndecide: //隔离
                    case SubBillType.ProductScrap: //报废
//                        var detailsMove = details.Select(p => p.ToStockMove()).ToList();
//                         StockDetailController.ListMove(db, bill, detailsMove); //更新【库存主表】【库存明细】
                     
                        break;
                    default:
                        throw new WmsException(ResultCode.Exception, bill.BillNum, "单据二级类型错误");
                }
            }
        }

        /// <summary>
        ///     添加【其它出库单】
        /// </summary>
        /// <param name="db"></param>
        /// <param name="bill">其它出库单</param>
        /// <param name="details">其它出库明细</param>
        /// <returns></returns>
        public static void AddOtherOut(SpareEntities db, TB_BILL bill, List<TB_OTHER_OUT> details)
        {
            {
                SetBillNum(bill); //设置单据编号
                details.ForEach(p => p.BillNum = bill.BillNum); //设置明细编号
                BillController.AddOrUpdate(db, bill); //添加单据
                foreach (var detail in details)
                {
                    OtherOutController.AddOrUpdate(db, detail); //添加明细
                }

                var subBillType = (SubBillType)bill.SubBillType;
                switch (subBillType)
                {
                    //出库
                    case SubBillType.OtherOut: //其它出库
                    //                    case SubBillType.ReturnToSupplier: //原料退货
                    case SubBillType.InventoryLoss: //盘亏
                    case SubBillType.ScrapDestroy: //报废销毁
                        var detailsOut = details.Select(detail => detail.ToStockDetailOut(bill)).ToList();
                        StockDetailController.ListOut(db, bill, detailsOut); //更新【库存主表】【库存明细】出库
                        break;

                    default:
                        throw new WmsException(ResultCode.Exception, bill.BillNum, "单据二级类型错误");
                }
            }
        }

        public static void AddMaterialReturn(SpareEntities db, TB_BILL bill, List<TB_RETURN> details)
        {
            BillController.AddOrUpdate(db, bill); //添加单据
            foreach (var detail in details)
            {
                var dbReturns = SpareReturnController.GetList(db, bill.BillNum).ToList();
                foreach (var sparereturn in dbReturns)
                {
                    if (details.FirstOrDefault(p => p.UID == sparereturn.UID) == null)
                    {
                        SpareReturnController.RemaveDetail(db,sparereturn);
                    }
                }
                SpareReturnController.AddOrUpdate(db, detail);//添加或修改【领用归还单】明细
            }
        }


        #region SetBillNum

        private static void SetBillNum(TB_BILL bill)
        {
            if (!string.IsNullOrEmpty(bill.BillNum)) return;
            bill.BillNum = BillTypeController.GetBillNum((BillType) bill.BillType);
            bill.State = (int) BillState.New;
            bill.BillTime = DateTime.Now;
//            bill.StartTime = DateTime.Now;
//            bill.FinishTime = DateTime.Now;
        }

        #endregion

        #region 收货

        /// <summary>
        ///     添加【原料收货单】
        /// </summary>
        /// <param name="db"></param>
        /// <param name="billList">原料收货单列表</param>
        /// <param name="detailList">原料收货明细列表</param>
        /// <returns></returns>
        public static void AddMaterialIn(SpareEntities db, List<TB_BILL> billList,
            List<TB_IN> detailList)
        {

            {
                foreach (var bill in billList)
                {
                    //校验订单状态
                    var po = BillController.GetBill(db, bill.SourceBillNum);
                    if (po == null) //订单不存在
                        throw new WmsException(ResultCode.DataNotFound, bill.SourceBillNum, "订单不存在");

                    if (po.State != (int) DataState.Enabled) //订单状态已关闭
                        throw new WmsException(ResultCode.DataStateError, po.BillNum, "订单已关闭");
                  
                    var details = detailList.Where(p => p.PoBillNum == bill.SourceBillNum).ToList();
                    //校验收货数量是否超出订单未收货数量
                    foreach (var detail in details)
                    {
                        var poDetail =
                            db.TB_PO.SingleOrDefault(
                                p => p.BillNum == po.BillNum && p.PartCode == detail.PartCode);
                        if (poDetail == null)
                            throw new WmsException(ResultCode.DataNotFound, detail.BillNum,
                                "订单明细不存在" + "\t" + detail.PartCode);
//                        if (poDetail.OpenQty < detail.Qty)
//                            throw new WmsException(ResultCode.DataQtyError, detail.BillNum,
//                                "收货数量超出订单剩余数量" + "\t" + detail.PartCode + "\t" + detail.Qty + "<->" + poDetail.OpenQty);
                        //更新订单收货数量
                        //poDetail.OpenQty -= detail.Qty;
                        //poDetail.ClosedQty += detail.Qty;
                        poDetail.ArrialQty += detail.Qty;
                    }

                    SetBillNum(bill); //设置单据编号
                    details.ForEach(p => p.BillNum = bill.BillNum); //设置明细编号

                    BillController.AddOrUpdate(db, bill); //添加【原料收货单】单据
                    SpareInController.AddList(db, details); //添加【原料收货单】明细

                    var stockDetails = details.Select(detail => detail.ToStockDetailIn(bill)).ToList();
                     StockDetailController.ListIn(db, bill, stockDetails); //更新【库存主表】【库存明细】
                    
                }
                 EntitiesFactory.SaveDb(db);
            }

        }

        /// <summary>
        ///     执行【领用还回单】
        /// </summary>
        /// <param name="db"></param>
        /// <param name="billList">领用还回单列表</param>
        /// <param name="detailList">领用还回明细列表</param>
        /// <returns></returns>
        public static void ExecuteSpareReturn(SpareEntities db, TB_BILL billList,
            List<TB_RETURN> detailList)
        {
            {
                foreach (var detail in detailList)
                {
                    var stockDetail = new TS_STOCK_DETAIL()
                    {
                        LocCode = detail.ToLocCode,
                        PartCode = detail.PartCode,
                        Batch = detail.Batch,
                        Qty = (decimal)detail.InQty,
                        UnitPrice = detail.UnitPrice,
                        UpdateQty = (decimal)detail.InQty
                    };
                    var stockDetails = new List<TS_STOCK_DETAIL>();
                    stockDetails.Add(stockDetail);
                    StockDetailController.ListIn(db, billList, stockDetails); //更新【库存主表】【库存明细】 
                }   
                EntitiesFactory.SaveDb(db);
            }

        }
        #endregion

        #region 拣料

        /// <summary>
        ///     创建【拣料单】
        /// </summary>
        /// <param name="db"></param>
        /// <param name="billPickFact">拣料单</param>
        /// <param name="details">拣料明细</param>
        /// <returns></returns>
        public static void AddMaterialOut(SpareEntities db, TB_BILL billPickFact, List<TB_OUT> details)
        {
            {
                //校验单据状态是否为新建
                if (billPickFact.State != (int) BillState.New)
                {
                    throw new WmsException(ResultCode.DataStateError,
                        billPickFact.BillNum, "状态错误,不应为：" + billPickFact.State);
                }
                if (billPickFact.BillNum == "")
                {
                    SetBillNum(billPickFact); //设置单据编号
                    details.ForEach(p => p.BillNum = billPickFact.BillNum); //设置明细编号

                }
                else
                {
                    var dbOutList = db.TB_OUT.Where(p => p.BillNum == billPickFact.BillNum).ToList();
                    foreach (var det in dbOutList)
                    {
                        if (details.FirstOrDefault(p => p.UID == det.UID) == null)
                        {
                            SpareOutController.RemaveDetail(db,det);
                        }
                    }
                }               
                BillController.AddOrUpdate(db, billPickFact); //添加【原料拣料单】单据
                SpareOutController.AddOrUpdateList(db, details); //更新【实际拣料单】明细
                //                var billPickPlan = BillController.GetBill(db, billPickFact.SourceBillNum);
                //                BillController.UpdateState(db, billPickPlan, BillState.Finished); //更新【备料单】状态为：完成
                //
                //                var billAsk = BillController.GetBill(db, billPickPlan.SourceBillNum);
                //                BillController.UpdateState(db, billAsk, BillState.Finished); //更新【叫料单】状态为：完成

                //                if (!string.IsNullOrEmpty(billAsk.SourceBillNum))
                //                {
                //                    var billPlan = BillController.GetBill(db, billAsk.SourceBillNum);
                //                    BillController.UpdateState(db, billPlan, BillState.Handling); //更新【生产计划单】状态为：执行中
                //                }

                //                if (SysConfig.AutoFinishPartPick)
                //                {
                //                    FinishMaterialOut(db, billPickFact, details);
                //                }
                EntitiesFactory.SaveDb(db);
            }
        }

        /// <summary>
        ///     确认【拣料单】
        /// </summary>
        /// <param name="db"></param>
        /// <param name="bill"></param>
        /// <param name="details"></param>
        /// <returns></returns>
        public static void FinishMaterialOut(SpareEntities db, TB_BILL bill, List<TB_OUT> details)
        {
            //校验单据状态是否为执行中
            if (bill.State != (int) BillState.New)
            {
                throw new WmsException(ResultCode.DataStateError, bill.BillNum, "状态错误,不应为：" + bill.State);
            }
            foreach (var detail in details)
            {
                var detailOut = detail.ToStockDetailOut();
                StockDetailController.Out(db, bill, detailOut);
            }
            BillController.UpdateState(db, bill, BillState.Finished); //更新【拣料单】状态为：完成
        }

        #endregion

        #region 叫料

        /// <summary>
        ///     添加【叫料单】
        /// </summary>
        /// <param name="db"></param>
        /// <param name="bill">叫料单</param>
        /// <param name="details">叫料明细</param>
        /// <returns></returns>
        public static void AddMaterialAsk(SpareEntities db, TB_BILL bill, List<TB_ASK> details)
        {
            if (bill.BillNum == null)
            {
                SetBillNum(bill); //设置单据编号
                details.ForEach(p => p.BillNum = bill.BillNum); //设置明细编号
            }
            BillController.AddOrUpdate(db, bill); //添加【生产叫料单】单据
            foreach (var detail in details)
            {
                SpareAskController.AddOrUpdate(db,detail);//添加或修改【生产叫料单】明细
            }
            NotifyController.AddNotify(db, bill.OperName, NotifyType.MaterialAsk, bill.BillNum, ""); //添加【叫料提醒单】         
        }

        /// <summary>
        /// 取消【叫料单】
        /// </summary>
        /// <param name="db"></param>
        /// <param name="bill"></param>
        /// <returns></returns>
        public static void CancelMaterialAsk(SpareEntities db, TB_BILL bill)
        {
            {
                //校验【叫料单】状态是否为新建
                if (bill.State != (int) BillState.New)
                {
                     throw new WmsException(ResultCode.DataStateError, bill.BillNum, "状态错误,不应为：" + bill.State);
                }
                BillController.UpdateState(db, bill, BillState.Cancelled); //更新【叫料单】状态为：取消
            }
        }


        /// <summary>
        ///     执行【领用申请单】，生成【领用单】
        /// </summary>
        /// <param name="db"></param>
        /// <param name="billAsk">申请单</param>
        /// <param name="details">申请明细</param>
        /// <returns></returns>
        public static string HandleMaterialAsk(SpareEntities db, TB_BILL billAsk, List<TB_ASK> details)
        {
            try
            {
                //校验【领用单】状态是否为批准
                if (billAsk.State != (int) BillState.Approve)
                {
                    return "申请单状态错误，不应为：" + billAsk.State;
                }
                var partPickList = new List<TB_OUT>();
                foreach (var detail in details)
                {
                    var pList = SpareOutController.GetList(db, detail);
                    if (pList.Count == 0 || pList.Sum(p => p.OutQty) < detail.Qty)
                    {
                        return "库存不足，生成领用单失败！";
                    }
                    partPickList.AddRange(pList);
                }
                var billPick = new TB_BILL
                {
                    BillNum = "",
                    SourceBillNum = billAsk.BillNum,
                    BillType = (int) BillType.MaterialDeliver,
                    SubBillType = (int) billAsk.SubBillType,
                    BillTime = DateTime.Now,
                    OperName = billAsk.OperName,
                    SplyId = billAsk.SplyId,
                    State = (int) BillState.New,
                    Remark = "",
                };
                SetBillNum(billPick);
                partPickList.ForEach(p=> p.BillNum = billPick.BillNum);
                BillController.AddOrUpdate(db,billPick);
                SpareOutController.AddList(db,partPickList);
                BillController.UpdateState(db, billAsk, BillState.Handling); //更新【叫料单】状态为：执行中
                return "OK";
            }
            catch (Exception ex)
            {
                BillController.UpdateState(db, billAsk, BillState.Failed);
                billAsk.Remark = ex.ToString();
                return ex.ToString();
            }

        }

        /// <summary>
        ///     根据【领用出库单】，生成【领用还回单】
        /// </summary>
        /// <param name="db"></param>
        /// <param name="billAsk">申请单</param>
        /// <param name="details">申请明细</param>
        /// <returns></returns>
        public static string HandleMaterialReturn(SpareEntities db, TB_BILL billOut, List<TB_OUT> details)
        {
            try
            {
                //校验【领用单】状态是否为批准
                if (billOut.State != (int)BillState.Finished)
                {
                    return "申请单状态错误，不应为：" + billOut.State;
                }
                if (billOut.SubBillType != (int) SubBillType.SpareLoan)
                {
                    return "非借出单，不能进行还回操作！";
                }
                var partPickList = new List<TB_RETURN>();
                foreach (var detail in details)
                {
                    var pList = SpareReturnController.OutToReturnList(detail);
                    partPickList.Add(pList);
                }
                var billPick = new TB_BILL
                {
                    BillNum = "",
                    SourceBillNum = billOut.BillNum,
                    BillType = (int)BillType.SpareReturn,
                    SubBillType = (int)SubBillType.SpareReturn,
                    BillTime = DateTime.Now,
                    OperName = billOut.OperName,
                    SplyId = billOut.SplyId,
                    State = (int)BillState.New,
                    Remark = "",
                };
                SetBillNum(billPick);
                partPickList.ForEach(p => p.BillNum = billPick.BillNum);
                BillController.AddOrUpdate(db, billPick);
                SpareReturnController.AddList(db, partPickList);
                SpareReturnController.AddList(db,partPickList);
                return "OK";
            }
            catch (Exception ex)
            {
                BillController.UpdateState(db, billOut, BillState.Failed);
                billOut.Remark = ex.ToString();
                return ex.ToString();
            }

        }
        #endregion

        #region 盘点

        /// <summary>
        ///     添加【盘点计划】
        /// </summary>
        /// <param name="db"></param>
        /// <param name="bill">盘点计划</param>
        /// <param name="locList">盘点库位明细</param>
        /// <returns></returns>
        public static void AddInventoryLoc(SpareEntities db, TB_BILL bill, List<TB_INVENTORY_LOC> locList)
        {
            {
                //新单据，增加盘点的三张表
                if (string.IsNullOrEmpty(bill.BillNum))
                {
                    SetBillNum(bill); //设置单据编号
                    locList.ForEach(p => p.BillNum = bill.BillNum); //设置明细编号
                    InventoryController.AddLocList(db, locList); //添加盘点库位列表
                    foreach (var locBill in locList)
                    {
                        var stockDetailList = StockDetailController.GetTListByLocCode(db, locBill.LocCode);
                        var inventoryDetailList = (stockDetailList.Select(p => p.ToInventoryDetail(locBill))).ToList();
                        InventoryController.AddDetailList(db, inventoryDetailList); //添加盘点明细
                    }
                }
                else
                {
                    //修改单据，对第二、三张表的增加或删除
                    foreach (var locBill in locList)
                    {
                        if (db.TB_INVENTORY_LOC.FirstOrDefault(p => p.BillNum == bill.BillNum && p.LocCode == locBill.LocCode) == null)
                        {
                            InventoryController.AddLocList(db, locList); //添加盘点库位列表
                            var stockDetailList = StockDetailController.GetTListByLocCode(db, locBill.LocCode);
                            var inventoryDetailList = (stockDetailList.Select(p => p.ToInventoryDetail(locBill))).ToList();
                            InventoryController.AddDetailList(db, inventoryDetailList); //添加盘点明细
                        }  
                    }

                    var DBLocList = db.TB_INVENTORY_LOC.Where(p => p.BillNum == bill.BillNum).ToList();
                    foreach (var loc in DBLocList)
                    {
                        if (locList.SingleOrDefault(p => p.LocCode == loc.LocCode) == null)
                        {
                            InventoryController.DeleteInventory(db,loc);
                        }
                    }
                }
                InventoryController.AddOrUpdate(db, bill); //添加盘点单据
                NotifyController.AddNotify(db, bill.OperName, NotifyType.InventoryPlan, bill.BillNum, ""); //添加【叫料提醒单】
            }
        }


        /// <summary>
        ///     【盘点计划】开始
        /// </summary>
        /// <param name="db"></param>
        /// <param name="bill"></param>
        /// <returns></returns>
        public static void HandleInventoryBill(SpareEntities db, TB_BILL bill)
        {
            //校验【盘点计划】状态是否为新建
            if (bill.State != (int) BillState.New)
            {
                throw new WmsException(ResultCode.DataStateError, bill.BillNum, "状态错误,不应为：" + bill.State);

            }
            InventoryController.Start(db, bill);
        }

        /// <summary>
        ///     【盘点计划】结束
        /// </summary>
        /// <param name="db"></param>
        /// <param name="bill"></param>
        /// <param name="details"></param>
        /// <returns></returns>
        public static void FinishInventoryBill(SpareEntities db, TB_BILL bill, List<TB_INVENTORY_LOC> details)
        {
            //校验【盘点计划】状态是否为已开始
            if (bill.State != (int) BillState.Handling)
            {
                throw new WmsException(ResultCode.DataStateError, bill.BillNum, "状态错误,不应为：" + bill.State);

            }
            //校验【盘点单】状态是否为已结束或已取消
            foreach (
                var detail in
                    details.Where(
                        detail =>
                            detail.State != (int) BillState.Finished && detail.State != (int) BillState.Cancelled))
            {
                throw new WmsException(ResultCode.DataStateError, bill.BillNum,
                    "明细状态错误,盘点单：" + detail.LocCode + " 尚未盘点结束");

            }
            InventoryController.Finish(db, bill);
        }

        /// <summary>
        ///     【盘点计划】取消
        /// </summary>
        /// <param name="db"></param>
        /// <param name="bill"></param>
        /// <returns></returns>
        public static void CancelInventoryBill(SpareEntities db, TB_BILL bill)
        {
            //校验【盘点计划】状态是否为新建或已开始
            if (bill.State != (int) BillState.New && bill.State != (int) BillState.Handling)
            {
                throw new WmsException(ResultCode.DataStateError, bill.BillNum, "状态错误,不应为：" + bill.State);

            }
            InventoryController.Cancel(db, bill);
        }

        /// <summary>
        ///     添加临时盘点
        /// </summary>
        /// <param name="db"></param>
        /// <param name="locBill">盘点库位</param>
        /// <param name="details">盘点明细</param>
        /// <returns></returns>
        public static void AddTempInventory(SpareEntities db, TB_INVENTORY_LOC locBill,
            List<TB_INVENTORY_DETAIL> details)
        {
            var bill = new TB_BILL
            {
                BillType = (int) BillType.InventoryPlan,
                OperName = locBill.OperName,
                StartTime = locBill.CheckBeginTime,
                FinishTime = locBill.CheckEndTime,
                State = (int) BillState.Finished
            };

            locBill.State = (int) InventoryState.Checked;
            var locList = new List<TB_INVENTORY_LOC> {locBill};

            SetBillNum(bill); //设置单据编号
            locList.ForEach(p => p.BillNum = bill.BillNum); //设置明细编号

            InventoryController.AddOrUpdate(db, bill); //添加盘点计划
            InventoryController.AddLocList(db, locList); //添加盘点库位
            InventoryController.AddDetailList(db, details); //添加盘点明细

            InventoryController.AdjustStockByInventory(db, bill, details); //根据盘点结果调整库存
        }

        /// <summary>
        ///     开始库位盘点
        /// </summary>
        /// <param name="db"></param>
        /// <param name="locBill"></param>
        /// <returns></returns>
        public static void HandleInventoryLoc(SpareEntities db, TB_INVENTORY_LOC locBill)
        {
           

            {

                //校验【盘点计划】状态是否为新建
                if (locBill.State != (int) InventoryState.New && locBill.State != (int) InventoryState.Checked &&
                    locBill.State != (int) InventoryState.ReChecked)
                {
                     throw new WmsException(ResultCode.DataStateError, locBill.BillNum + "." + locBill.LocCode,
                        "状态错误,不应为：" + locBill.State);

                }
                 InventoryController.LocStart(db, locBill);
                

            }

        }

        /// <summary>
        ///     完成库位盘点
        /// </summary>
        /// <param name="db"></param>
        /// <param name="locBill"></param>
        /// <param name="details"></param>
        /// <returns></returns>
        public static void FinishInventoryLoc(SpareEntities db, TB_INVENTORY_LOC locBill,
            List<TB_INVENTORY_DETAIL> details)
        {
           

            {


                //校验【盘点计划】状态是否为执行中

                if (locBill.State != (int) InventoryState.Checked && locBill.State != (int) InventoryState.ReChecked)
                {
                     throw new WmsException(ResultCode.DataStateError, locBill.BillNum + "." + locBill.LocCode,
                        "状态错误,不应为：" + locBill.State);

                }

                if (string.IsNullOrEmpty(locBill.BillNum))
                {
                    AddTempInventory(db, locBill, details);
                }
                else
                {
                     InventoryController.LocFinish(db, locBill, details);
                    
                }

            }

        }

        /// <summary>
        ///     取消【盘点单】
        /// </summary>
        /// <param name="db"></param>
        /// <param name="locBill"></param>
        /// <returns></returns>
        public static void CancelInventoryLoc(SpareEntities db, TB_INVENTORY_LOC locBill)
        {
            {
                //校验【盘点单】状态是否为新建或已开始
                if (locBill.State != (int) InventoryState.New && locBill.State != (int) InventoryState.Checked &&
                    locBill.State != (int) InventoryState.ReChecked)
                {
                     throw new WmsException(ResultCode.DataStateError, locBill.BillNum + "." + locBill.LocCode,
                        "状态错误,不应为：" + locBill.State);
                }
                 InventoryController.LocCancel(db, locBill);
            }
        }

        /// <summary>
        ///     【盘点单】调整库存
        /// </summary>
        /// <param name="db"></param>
        /// <param name="bill"></param>
        /// <param name="details"></param>
        /// <returns></returns>
        public static void AdjustStockByInventoryLoc(SpareEntities db, TB_BILL bill)
        {
            var details = db.TB_INVENTORY_DETAIL.Where(p => p.BillNum == bill.BillNum).ToList();
            InventoryController.AdjustStockByInventory(db, bill, details);
            BillController.UpdateState(db,bill,BillState.Finished);
        }

        /// <summary>
        ///     【盘点单】更新盘点明细表
        /// </summary>
        /// <param name="db"></param>
        /// <param name="bill"></param>
        /// <param name="details"></param>
        /// <returns></returns>
        public static void AddOrUpdateInventoryDetail(SpareEntities db,TB_BILL bill, List<TB_INVENTORY_DETAIL> details)
        {
            foreach (var detail in details)
            {
                InventoryController.AddOrUpdate(db,detail);
            }
            BillController.UpdateState(db,bill,BillState.Handling);
        }

        #endregion


    }
}