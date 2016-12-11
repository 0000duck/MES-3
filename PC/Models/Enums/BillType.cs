using System.ComponentModel;

namespace ChangKeTec.Wms.Models.Enums
{
    public enum BillType
    {
        [Description("原料收货")]
        MaterialReceive=101,
        [Description("原料入库")]
        MaterialIn = 102,
        [Description("原料出库")]
        MaterialDeliver=103,
        [Description("生产叫料")]
        MaterialAsk=104,
        [Description("原料退货")]
        MatertialReturn = 105,
        [Description("生产退库")]
        MaterialBack = 106,
        [Description("备件领用归还")]
        SpareReturn = 107,


        [Description("委外出库")]
        MaterialOutsourceOut = 109,

//        [Description("原料退货")]
//        MaterialBack = 105,
//        [Description("生产退库")]
//        MaterialReturn = 106,

        [Description("成品收货")]
        ProductReceive = 201,
        [Description("成品入库")]
        ProductIn=202,
        [Description("成品发货")]
        DeliverPlan = 204,
        [Description("客户退货")]
        ProductReturn = 205,
        [Description("成品顺序发货")]
        ProductSortedDeliver = 206,
        [Description("成品销售")]
        ProductSell = 207,
        [Description("成品返修")]
        ProductRepair = 208,

        [Description("委外入库")]
        ProductOutsourceIn = 209,


        [Description("其它出入库")]
        OtherInOut = 301,
        [Description("移库")]
        StockMove = 302,
        [Description("打包")]
        StockPack = 303,
        [Description("拆包")]
        StockUnpack = 304,
        [Description("盘点计划")]
        InventoryPlan = 305,
        [Description("结算比对")]
        BalanceCompare = 307,
        [Description("盘点库位")]
        InventoryLoc = 306,

        [Description("器具初始化")]
        EqptRecover = 401,
        [Description("器具保养")]
        EqptMaintain = 402,
        [Description("器具报废")]
        EqptScrap = 403,
        [Description("码托")]
        EqptLoad = 404,

        [Description("JIS收货")]
        VinReceive = 501,
        [Description("JIS发货")]
        VinDeliver = 502,
        [Description("JIS销售")]
        VinSell = 503,

        [Description("报检")]
        Inspect =601,
        [Description("追溯")]
        TraceBack = 602,
        [Description("备货单")]
        PickPlan = 603,
        [Description("拣料单")]
        PickFact = 604,
        [Description("生产计划")]
        ProducePlan = 605,
        [Description("委外计划")]
        OutsourcePlan = 606,

        ReHandleVin = 701,
        [Description("采购订单")]
        PuchaseOrder = 702,
        [Description("发货单")]
        AsnOrder = 703,
        [Description("销售订单")]
        SaleOrder = 704,

        
    }
}