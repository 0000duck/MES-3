using System.ComponentModel;

namespace ChangKeTec.Wms.Models.Enums
{
    public enum BillState
    {
        [Description("取消")]
        Cancelled = -1,

        [Description("新建")]
        New = 0,
        [Description("批准")]
        Approve = 1,
        [Description("执行中")]
        Handling = 2,
        [Description("完成")]
        Finished = 3,
        [Description("失败")]
        Failed = 4,
    }
}