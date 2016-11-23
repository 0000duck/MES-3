using System.ComponentModel;

namespace ChangKeTec.Wms.Models.Enums
{
    public enum VinState
    {
        [Description("已收货")]
        Received = 0,
        [Description("部分收货")]
        Partial = 111,
        [Description("已发货")]
        Delivered = 222,
        [Description("销售中")]
        Selling = 300,
        [Description("已销售")]
        Sold = 333,
        [Description("已比对")]
        Balanced = 999,
        [Description("不存在数据")]
        DataNotFound = -1,
    }
}