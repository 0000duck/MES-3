using System.ComponentModel;

namespace ChangKeTec.Wms.Models.Enums
{
    public enum WhseType
    {
        [Description("生产仓库")]
        ProduceWhse = 0,
        [Description("第三方仓库")]
        ThirdWhse = 1,
    }
}