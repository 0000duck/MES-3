using System.ComponentModel;

namespace ChangKeTec.Wms.Models.Enums
{
    public enum GroupType
    {
        [Description("高位货架")]
        Shelf = 0,
        [Description("地面库位")]
        Ground = 1,
        [Description("线边货架")]
        Wip = 2,

    }
}