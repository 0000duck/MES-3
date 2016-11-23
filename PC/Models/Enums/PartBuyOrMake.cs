using System.ComponentModel;

namespace ChangKeTec.Wms.Models.Enums
{
    public enum PartBuyOrMake
    {
        [Description("采购件")]
        B=0,
        [Description("制造件")]
        M=1,
    }
}