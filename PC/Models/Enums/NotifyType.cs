using System.ComponentModel;

namespace ChangKeTec.Wms.Models.Enums
{
    public enum NotifyType
    {
        [Description("新增备料单")]
        MaterialAsk=0,
        [Description("未知客户零件号")]
        UnknowCustPart=1,
        [Description("新增检验单")]
        Inspect=2,
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
    }
}