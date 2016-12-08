using System.ComponentModel;
using System.Security.Cryptography;

namespace ChangKeTec.Wms.Models.Enums
{
    public enum SubBillType
    {
        //其它出入库-出库
        [Description("其它出库")]
        OtherOut = 30101,          
        //[Description("原料退货")]
        //ReturnToSupplier=30102,
        [Description("盘盈单")]
        InventoryProfit = 30103,
        [Description("报废销毁")]
        ScrapDestroy=30104,
        [Description("备件领用")]
        SpareOut = 30105,
        [Description("备件借出")]
        SpareLoan = 30106,

        //其它出入库-入库
        [Description("其它入库")]
        OtherIn = 30111,           
        //[Description("销售退货")]
        //ProductReturn=30112,
        [Description("盘亏单")]
        InventoryLoss=30113,
        [Description("备件归还")]
        SpareReturn = 30114,

        //其它出入库-移库
        [Description("成品隔离")]
        ProductUndecide = 30131,
        //[Description("成品返修")]
        //ProductRepair = 30132,
        [Description("成品报废")]
        ProductScrap = 30133,
        //[Description("生产退库")]
        //BackToStore = 30134,


        //移库
        [Description("移库单")]
        StockMove = 30201,
        [Description("原料入库单")]
        MaterialStockIn = 30202,
        [Description("成品入库单")]
        ProductStockIn = 30203,
        [Description("成品出库单")]
        ProductStockOut = 30204,
        [Description("原料出库单")]
        PartPickFact = 30205,
        

        //采购收货
        [Description("订单收货单")]
        PoReceive = 10101,
        [Description("ASN收货单")]
        AsnReceive = 10102,
        
    }
}