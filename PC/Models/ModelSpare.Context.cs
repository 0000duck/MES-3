﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SpareEntities : DbContext
    {
        public SpareEntities()
            : base("name=SpareEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TA_Attach> TA_Attach { get; set; }
        public virtual DbSet<TA_CONFIG> TA_CONFIG { get; set; }
        public virtual DbSet<TA_DEPT> TA_DEPT { get; set; }
        public virtual DbSet<TA_MACHINE> TA_MACHINE { get; set; }
        public virtual DbSet<TA_PART> TA_PART { get; set; }
        public virtual DbSet<TA_PROJECT> TA_PROJECT { get; set; }
        public virtual DbSet<TA_STORE_LOCATION> TA_STORE_LOCATION { get; set; }
        public virtual DbSet<TA_STORE_WHSE> TA_STORE_WHSE { get; set; }
        public virtual DbSet<TA_SUB_BILLTYPE> TA_SUB_BILLTYPE { get; set; }
        public virtual DbSet<TA_SUPERLIER> TA_SUPERLIER { get; set; }
        public virtual DbSet<TA_UNIT> TA_UNIT { get; set; }
        public virtual DbSet<TA_WORKLINE> TA_WORKLINE { get; set; }
        public virtual DbSet<TB_ASK> TB_ASK { get; set; }
        public virtual DbSet<TB_IN> TB_IN { get; set; }
        public virtual DbSet<TB_INVENTORY_DETAIL> TB_INVENTORY_DETAIL { get; set; }
        public virtual DbSet<TB_INVENTORY_LOC> TB_INVENTORY_LOC { get; set; }
        public virtual DbSet<TB_OTHER_IN> TB_OTHER_IN { get; set; }
        public virtual DbSet<TB_OTHER_OUT> TB_OTHER_OUT { get; set; }
        public virtual DbSet<TB_OUT> TB_OUT { get; set; }
        public virtual DbSet<TB_PO> TB_PO { get; set; }
        public virtual DbSet<TB_RETURN> TB_RETURN { get; set; }
        public virtual DbSet<TB_STOCK_MOVE> TB_STOCK_MOVE { get; set; }
        public virtual DbSet<TL_BASEDATA> TL_BASEDATA { get; set; }
        public virtual DbSet<TL_BILL> TL_BILL { get; set; }
        public virtual DbSet<TL_INTERFACE> TL_INTERFACE { get; set; }
        public virtual DbSet<TL_NOTIFY> TL_NOTIFY { get; set; }
        public virtual DbSet<TL_OPER> TL_OPER { get; set; }
        public virtual DbSet<TL_TRANSACTION> TL_TRANSACTION { get; set; }
        public virtual DbSet<TS_STOCK_DETAIL> TS_STOCK_DETAIL { get; set; }
        public virtual DbSet<TT_GROUP_TYPE> TT_GROUP_TYPE { get; set; }
        public virtual DbSet<TT_LOC_TYPE> TT_LOC_TYPE { get; set; }
        public virtual DbSet<TT_MACHINE_TYPE> TT_MACHINE_TYPE { get; set; }
        public virtual DbSet<TT_PART_TYPE> TT_PART_TYPE { get; set; }
        public virtual DbSet<VIEW_CalInaction_DAYS> VIEW_CalInaction_DAYS { get; set; }
        public virtual DbSet<VIEW_CalOverdue_DAYS> VIEW_CalOverdue_DAYS { get; set; }
        public virtual DbSet<VIEW_INVENTORY_DETAIL> VIEW_INVENTORY_DETAIL { get; set; }
        public virtual DbSet<VIEW_STOCK_DETAIL_AGE> VIEW_STOCK_DETAIL_AGE { get; set; }
        public virtual DbSet<VS_IDLE_STOCK_DETAIL> VS_IDLE_STOCK_DETAIL { get; set; }
        public virtual DbSet<VS_OVERDUE_STOCK> VS_OVERDUE_STOCK { get; set; }
        public virtual DbSet<VS_STOCK> VS_STOCK { get; set; }
        public virtual DbSet<VS_STOCK_AGE> VS_STOCK_AGE { get; set; }
        public virtual DbSet<TS_CONFIG> TS_CONFIG { get; set; }
        public virtual DbSet<VW_BILL> VW_BILL { get; set; }
        public virtual DbSet<TB_BILL> TB_BILL { get; set; }
        public virtual DbSet<VIEW_CalSafeQty> VIEW_CalSafeQty { get; set; }
        public virtual DbSet<TA_STORE_GROUP> TA_STORE_GROUP { get; set; }
        public virtual DbSet<VIEW_STOCK_DETAIL> VIEW_STOCK_DETAIL { get; set; }
        public virtual DbSet<TA_BILLTYPE> TA_BILLTYPE { get; set; }
        public virtual DbSet<TA_PROCESS> TA_PROCESS { get; set; }
        public virtual DbSet<TA_WORKSHOP> TA_WORKSHOP { get; set; }
        public virtual DbSet<TA_LINESTATION> TA_LINESTATION { get; set; }
        public virtual DbSet<TA_LINE> TA_LINE { get; set; }
    }
}
