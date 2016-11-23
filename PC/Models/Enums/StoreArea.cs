using System.ComponentModel;

namespace ChangKeTec.Wms.Models.Enums
{
    public enum StoreArea
    {
        [Description("原料库")]
        RAW=11,
        [Description("线边库")]
        WIP=21,
        [Description("成品库")]
        FG=12,
        [Description("销售库")]
        SALE=13,
        [Description("隔离库")]
        UNDECIDE=22,
        [Description("在途库")]
        ROAD=14,
        [Description("其它库")]
        OTHER=15,
        [Description("废品库")]
        SCRAP=23,
        [Description("半成品库")]
        HF=16,
        [Description("待检库")]
        RCT=0,
        
    }
}