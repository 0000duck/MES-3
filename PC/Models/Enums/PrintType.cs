using System.ComponentModel;

namespace ChangKeTec.Wms.Models.Enums
{
    public enum PrintType
    {
        [Description("直接打印")]
        Print=0,
        [Description("打印预览")]
        PrintPreview=1
    }
}