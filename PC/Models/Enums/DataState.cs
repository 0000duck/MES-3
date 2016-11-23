using System.ComponentModel;

namespace ChangKeTec.Wms.Models.Enums
{
    public enum DataState
    {
        [Description("无效")]
        Disabled = 0,
        [Description("有效")]
        Enabled = 1,
    }
}