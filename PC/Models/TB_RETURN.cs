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
    
    public partial class TB_RETURN
    {
        public int UID { get; set; }
        public string BillNum { get; set; }
        public string PartCode { get; set; }
        public string Batch { get; set; }
        public string FromLocCode { get; set; }
        public string ToLocCode { get; set; }
        public decimal OutQty { get; set; }
        public Nullable<decimal> InQty { get; set; }
        public decimal UnitPrice { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string DeptCode { get; set; }
        public string ProjectCode { get; set; }
        public string WorklineCode { get; set; }
        public string EqptCode { get; set; }
        public string AskUser { get; set; }
        public Nullable<System.DateTime> AskTime { get; set; }
        public string ConfirmUser { get; set; }
        public Nullable<System.DateTime> ConfirmTime { get; set; }
        public string ReturnUser { get; set; }
        public Nullable<System.DateTime> ReturnTime { get; set; }
        public string TakeUser { get; set; }
        public System.DateTime TakeTime { get; set; }
        public int State { get; set; }
        public string Remark { get; set; }
    }
}
