using System.ComponentModel;

namespace ChangKeTec.Wms.Models.Enums
{
    public enum InventoryState
    {
        //状态 0:新建 1:已初盘 2:已重盘 3:已生成接口 -1:已取消
        [Description("新建")]
        New = 0,
        [Description("已初盘")]
        Checked = 1,
        [Description("已重盘")]
        ReChecked = 2,
        [Description("已生成接口")]
        ToErp = 3,
        [Description("取消")]
        Cancelled = -1
    }
}