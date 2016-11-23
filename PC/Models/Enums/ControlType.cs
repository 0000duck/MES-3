using System.ComponentModel;

namespace ChangKeTec.Wms.Models.Enums
{
    public enum ControlType
    {
        [Description("标签")]
        Tab = 0,
        [Description("群组")]
        Grp = 1,
        [Description("容器")]
        Ctn = 2,
        [Description("菜单项")]
        Itm = 3,
    }
}