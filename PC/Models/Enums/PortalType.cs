using System.ComponentModel;

namespace ChangKeTec.Wms.Models.Enums
{
    public enum PortalType
    {
        [Description("客户端")]
        WinForm = 0,
        [Description("网站")]
        Web = 1,
        [Description("手持")]
        Pda = 2,
        [Description("其它")]
        Other = 3,
    }
}