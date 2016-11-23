using System.ComponentModel;

namespace ChangKeTec.Wms.Models.Enums
{
    public enum PartKind
    {
        [Description("总成")]
        A,
        [Description("原料")]
        M,
        [Description("半成品")]
        H
    }
}