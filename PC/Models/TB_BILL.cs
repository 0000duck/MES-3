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
    
    public partial class TB_BILL
    {
        public int UID { get; set; }
        public string BillNum { get; set; }
        public string SourceBillNum { get; set; }
        public int BillType { get; set; }
        public int SubBillType { get; set; }
        public System.DateTime BillTime { get; set; }
        public string StartTime { get; set; }
        public string FinishTime { get; set; }
        public string OperName { get; set; }
        public string SplyId { get; set; }
        public int State { get; set; }
        public string Remark { get; set; }
        public string Factory { get; set; }
    }
}
