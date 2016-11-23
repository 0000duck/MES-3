using System.ComponentModel;

namespace ChangKeTec.Wms.Models.Enums
{
    public enum LocType
    {
        [Description("存储库位")]
        Store = 0,
        [Description("线边库位")]
        Wip = 1,
        [Description("功能库位")]
        Functional = 2,

    }
}