using System.ComponentModel;

namespace ChangKeTec.Wms.Models.Enums
{
    public enum PortalType
    {
        [Description("�ͻ���")]
        WinForm = 0,
        [Description("��վ")]
        Web = 1,
        [Description("�ֳ�")]
        Pda = 2,
        [Description("����")]
        Other = 3,
    }
}