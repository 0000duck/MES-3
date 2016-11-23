using System.ComponentModel;

namespace ChangKeTec.Wms.Models.Enums
{
    public enum ResultCode
    {
        [Description("成功")]
        Success = 0,
        [Description("警告")]
        Warning = 1,
        [Description("连接错误")]
        ErrorConnection = 1001,
        [Description("未找到数据")]
        DataNotFound = 2001,
        [Description("数据已存在")]
        DataAlreadyExist = 2002,
        [Description("数据状态错误")]
        DataStateError = 2003,
        [Description("数量错误")]
        DataQtyError=2004,

        [Description("发现新零件")]
        NewCustPart = 4001,
        [Description("系统错误")]
        Exception=-1,
        [Description("数据校验失败")]
        DbEntityValidationException=-2,

        [Description("库存不足")]
        StockNotEnough,
    }
}