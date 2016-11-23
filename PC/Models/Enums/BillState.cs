using System.ComponentModel;

namespace ChangKeTec.Wms.Models.Enums
{
    public enum BillState
    {
        [Description("取消")]
        Cancelled = -1,

        [Description("新建")]
        New = 0,
        [Description("执行中")]
        Handling = 1,
        [Description("完成")]
        Finished = 2,
        [Description("失败")]
        Failed = 3,
    }
}