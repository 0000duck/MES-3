using System.ComponentModel;

namespace ChangKeTec.Wms.Models.Enums
{
    public enum ErpInterfaceType
    {
        [Description("移库")]
        TR,
        [Description("回冲")]
        BK,
        MaterialIn,
        MaterialOut,
        ProductIn,
        ProductOut,
        [Description("销售")]
        SH,
        RCT
    }
}