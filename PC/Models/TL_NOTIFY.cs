//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChangKeTec.Wms.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TL_NOTIFY
    {
        public int UID { get; set; }
        public int NotifyType { get; set; }
        public string NotifyMessage { get; set; }
        public string BillNum { get; set; }
        public string CreateOperName { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string CloseOperName { get; set; }
        public System.DateTime CloseTime { get; set; }
        public int State { get; set; }
    }
}
