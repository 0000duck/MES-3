using System.ComponentModel;

namespace ChangKeTec.Wms.Models.Enums
{
    public enum GroupType
    {
        [Description("��λ����")]
        Shelf = 0,
        [Description("�����λ")]
        Ground = 1,
        [Description("�߱߻���")]
        Wip = 2,

    }
}