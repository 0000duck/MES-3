using System.ComponentModel;

namespace ChangKeTec.Wms.Models.Enums
{
    public enum NotifyType
    {
        [Description("新增领用申请单")]
        MaterialAsk=0,
        [Description("新增领用出库单")]
        MaterialOut = 1,
        [Description("新增借出还回单")]
        SpareReturn=2,
        [Description("新增生产计划单")]
        ProducePlan=3,
        [Description("新增发货计划单")]
        DeliverPlan=4,
        [Description("新增盘点计划单")]
        InventoryPlan=5,
        [Description("新增委外计划单")]
        OmPlan=6,
        [Description("VIN处理错误")]
        VinError=7,

        [Description("领用申请单修改")]
        MaterialAskUpdate = 31,
        [Description("领用出单修改")]
        MaterialOutUpdate = 32,
        [Description("还回单修改")]
        SpareReturnUpdate = 33,
        [Description("盘点单修改")]
        InventoryPlanUpdate = 34,

        [Description("领用申请单取消")]
        MaterialAskCancel = 61,
        [Description("领用出库单取消")]
        MaterialOutCancel = 62,
        [Description("还回单取消")]
        SpareReturnCancel = 63,
        [Description("盘点单取消")]
        InventoryPlanCancel = 64,

        [Description("领用申请单批准")]
        MaterialAskApprove = 91,
        [Description("领用出库单执行")]
        MaterialOutApprove = 92,
        [Description("还回库单执行")]
        SpareReturnApprove = 93,
        [Description("其他入库执行")]
        OtherInApprove = 94,
        [Description("其他出库执行")]
        OtherOutApprove = 95,
        [Description("移库单执行")]
        StockMoveApprove = 96,
        [Description("盘点单执行")]
        InventoryPlanApprove = 97,


        [Description("库存呆滞提示")]
        StockInaction = 201,
        [Description("备件过期提示")]
        StockOverdue = 202,
        [Description("安全库存提示")]
        StockSafeQty = 203,

        [Description("QAD接口：基础数据同步")]
        OAInterfaceBase = 251,
        [Description("QAD接口：采购订单同步")]
        OAInterfacePO = 252,
        [Description("QAD接口：采购入库同步")]
        QADInterfaceInStock = 253,
    }
}