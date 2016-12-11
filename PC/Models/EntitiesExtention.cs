using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using ChangKeTec.Wms.Models.Enums;

namespace ChangKeTec.Wms.Models
{
    public partial class SpareEntities
    {
        public SpareEntities(string strConn)
            : base(strConn)
        {
        }
    }

    public partial class PowerEntities
    {
        public PowerEntities(string strConn)
            : base(strConn)
        {
        }
    }





    public partial class TB_INVENTORY_DETAIL
    {
        public override string ToString()
        {
            PropertyInfo[] peroperties = typeof(TB_INVENTORY_DETAIL).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            StringBuilder sb = new StringBuilder();
            foreach (PropertyInfo property in peroperties)
            {
                sb.AppendLine(property.Name + ": " + property.GetValue(this) + ",");
            }
            return sb.ToString();
        }

        public TB_STOCK_MOVE ToStockMove()
        {
            return new TB_STOCK_MOVE
            {
                PartCode = this.PartCode,
                Batch = this.Batch,
                ToLocCode = this.CheckLocCode,
                Qty = this.BookQty-(decimal)this.CheckQty,
            };
        }
    }

    public partial class TA_STORE_LOCATION
    {
        public bool IsCheck { get; set; }
    }

    public partial class TB_OUT
    {
        public override string ToString()
        {
            PropertyInfo[] peroperties = typeof(TB_OUT).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            StringBuilder sb = new StringBuilder();
            foreach (PropertyInfo property in peroperties)
            {
                sb.AppendLine(property.Name + ": " + property.GetValue(this) + ",");
            }
            return sb.ToString();
        }

        public TB_STOCK_MOVE ToStockMove()
        {
            return new TB_STOCK_MOVE
            {
                PartCode = this.PartCode,
                Batch = this.Batch,
                FromLocCode = this.FromLocCode,
                ToLocCode = this.FromLocCode,
                Qty = this.OutQty,
            };
        }

        public TS_STOCK_DETAIL ToStockDetailOut()
        {
            return new TS_STOCK_DETAIL
            {
                PartCode = this.PartCode,
                Batch = this.Batch,
                LocCode = this.FromLocCode,
                Qty = this.OutQty,
                UpdateQty = 0-this.OutQty
            };
        }
    }
    
    public partial class TB_OTHER_IN
    {
        public override string ToString()
        {
            PropertyInfo[] peroperties = typeof(TB_OTHER_IN).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            StringBuilder sb = new StringBuilder();
            foreach (PropertyInfo property in peroperties)
            {
                sb.AppendLine(property.Name + ": " + property.GetValue(this) + ",");
            }
            return sb.ToString();
        }

        public TS_STOCK_DETAIL ToStockDetailIn(TB_BILL bill)
        {
            return new TS_STOCK_DETAIL
            {
                PartCode = this.PartCode,
                Batch = this.Batch,
                LocCode = this.ToLocCode,
                Qty = this.Qty,
                UpdateQty = this.Qty,
                ProduceDate = this.ProduceDate.Value,
                ReceiveDate = DateTime.Now,
                OverdueDate = this.ProduceDate.Value.AddDays(GlobalBuffer.GetValidateDays(this.PartCode)),
            };
        }

    }

    public partial class TB_OTHER_OUT
    {
        public override string ToString()
        {
            PropertyInfo[] peroperties = typeof(TB_OTHER_OUT).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            StringBuilder sb = new StringBuilder();
            foreach (PropertyInfo property in peroperties)
            {
                sb.AppendLine(property.Name + ": " + property.GetValue(this) + ",");
            }
            return sb.ToString();
        }


        public TS_STOCK_DETAIL ToStockDetailOut(TB_BILL bill)
        {
            return new TS_STOCK_DETAIL
            {
                PartCode = this.PartCode,
                Batch = this.Batch,
                LocCode = this.FromLocCode,
                Qty = this.Qty,
                UpdateQty = 0-this.Qty
            };
        }
    }

    public partial class TS_STOCK_DETAIL
    {
        public override string ToString()
        {
            PropertyInfo[] peroperties = typeof(TS_STOCK_DETAIL).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            StringBuilder sb = new StringBuilder();
            foreach (PropertyInfo property in peroperties)
            {
                sb.AppendLine(property.Name + ": " + property.GetValue(this) + ",");
            }
            return sb.ToString();
        }

        public TB_INVENTORY_DETAIL ToInventoryDetail(TB_INVENTORY_LOC locBill)
        {
            return new TB_INVENTORY_DETAIL
            {
                BillNum = locBill.BillNum,
                CheckLocCode = locBill.LocCode,
                OperName = "",
                PartCode = this.PartCode,
                Batch = this.Batch,
                BookQty = this.Qty,
                CheckQty = 0,
                CheckTime = DateTime.Now
            };
        }

        public TS_STOCK_DETAIL Clone()
        {
            return new TS_STOCK_DETAIL
            {
                LocCode = this.LocCode,
                PartCode = this.PartCode,
                Batch = this.Batch,
                State = this.State,
                Qty = 0,
                ProduceDate = this.ProduceDate,
                OverdueDate = this.OverdueDate,
                UnitPrice = this.UnitPrice,
                ReceiveDate = this.ReceiveDate
            };
        }
    }

    public partial class TB_BILL
    {

        public override string ToString()
        {
            PropertyInfo[] peroperties = typeof(TB_BILL).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            StringBuilder sb = new StringBuilder();
            foreach (PropertyInfo property in peroperties)
            {
                sb.AppendLine(property.Name + ": " + property.GetValue(this) + ",");
            }
            return sb.ToString();
        }

   
    }

    public partial class TB_IN
    {

        public override string ToString()
        {
            PropertyInfo[] peroperties = typeof(TB_IN).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            StringBuilder sb = new StringBuilder();
            foreach (PropertyInfo property in peroperties)
            {
                sb.AppendLine(property.Name + ": " + property.GetValue(this) + ",");
            }
            return sb.ToString();
        }

        public TS_STOCK_DETAIL ToStockDetailIn(TB_BILL bill)
        {
            return new TS_STOCK_DETAIL
            {
                PartCode = this.PartCode,
                Batch = this.Batch,
                LocCode = this.ToLocCode,
                Qty = 0,
                ProduceDate =this.ProduceDate,
                OverdueDate = (this.ProduceDate).AddDays(GlobalBuffer.GetValidateDays(this.PartCode)),
            };
        }  
    }

    public partial class TB_STOCK_MOVE
    {

        public override string ToString()
        {
            PropertyInfo[] peroperties = typeof(TB_STOCK_MOVE).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            StringBuilder sb = new StringBuilder();
            foreach (PropertyInfo property in peroperties)
            {
                sb.AppendLine(property.Name + ": " + property.GetValue(this) + ",");
            }
            return sb.ToString();
        }

        public TS_STOCK_DETAIL ToStockDetailOut()
        {
            return new TS_STOCK_DETAIL
            {
                PartCode = this.PartCode,
                Batch = this.Batch,
                LocCode = this.FromLocCode,
                Qty = this.Qty,
                UpdateQty = 0-this.Qty
            };
        }

        public TS_STOCK_DETAIL ToStockDetailIn(SpareEntities db)
        {
            var stockDetail = db.TS_STOCK_DETAIL.Find(this.FromLocCode, this.PartCode,this.Batch);
            var detailIn = stockDetail.Clone();
            detailIn.LocCode = this.ToLocCode;
            detailIn.Qty = this.Qty;
            detailIn.UpdateQty = this.Qty;
            return detailIn;

//            return new TS_STOCK_DETAIL
//            {
//                LocCode = this.ToLocCode,
//                PartCode = this.PartCode,
//                Batch = this.Batch,
//                EqptCode = this.EqptCode,                
//                Qty = 0,
//                UpdateQty = this.Qty,
//                ProduceDate = this.ProduceDate,
//                OverdueDate = (this.ProduceDate).AddDays(GlobalBuffer.GetValidateDays(this.PartCode)),
//            };

        }

        public TS_STOCK_DETAIL ToStockDetailInventory(SpareEntities db)
        {
            var stockDetail = db.TS_STOCK_DETAIL.Find(this.FromLocCode, this.PartCode, this.Batch);
            var detailIn = new TS_STOCK_DETAIL();
            if (stockDetail == null)
            {
                detailIn = db.TS_STOCK_DETAIL.Find(this.ToLocCode, this.PartCode, this.Batch).Clone();
            }
            else
            {
                detailIn = stockDetail.Clone();          
            }
            detailIn.LocCode = this.ToLocCode;
            detailIn.Qty = this.Qty;
            detailIn.UpdateQty = this.Qty;
            return detailIn;
        }

    }


    

    public partial class TL_OPER
    {
        public override string ToString()
        {
            PropertyInfo[] peroperties = typeof(TL_OPER).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            StringBuilder sb = new StringBuilder();
            foreach (PropertyInfo property in peroperties)
            {
                sb.AppendLine(property.Name + ": " + property.GetValue(this,null) + ",");
            }
            return sb.ToString();
        }
    }

    public partial class TA_PART
    {
        public override string ToString()
        {
            PropertyInfo[] peroperties = typeof(TA_PART).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            StringBuilder sb = new StringBuilder();
            foreach (PropertyInfo property in peroperties)
            {
                sb.AppendLine(property.Name + ": " + property.GetValue(this) + ",");
            }
            return sb.ToString();
        }
    }
    

    public partial class TA_STORE_LOCATION
    {
        public override string ToString()
        {
            PropertyInfo[] peroperties = typeof(TA_STORE_LOCATION).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            StringBuilder sb = new StringBuilder();
            foreach (PropertyInfo property in peroperties)
            {
                sb.AppendLine(property.Name + ": " + property.GetValue(this) + ",");
            }
            return sb.ToString();
        }
    }
    

    public partial class TA_BILLTYPE
    {
        public override string ToString()
        {
            PropertyInfo[] peroperties = typeof(TA_BILLTYPE).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            StringBuilder sb = new StringBuilder();
            foreach (PropertyInfo property in peroperties)
            {
                sb.AppendLine(property.Name + ": " + property.GetValue(this) + ",");
            }
            return sb.ToString();
        }
    }

    public partial class TA_CONFIG
    {
        public override string ToString()
        {
            PropertyInfo[] peroperties = typeof(TA_CONFIG).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            StringBuilder sb = new StringBuilder();
            foreach (PropertyInfo property in peroperties)
            {
                sb.AppendLine(property.Name + ": " + property.GetValue(this) + ",");
            }
            return sb.ToString();
        }
    }

    public partial class TL_INTERFACE
    {
        public override string ToString()
        {
            PropertyInfo[] peroperties = typeof(TL_INTERFACE).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            StringBuilder sb = new StringBuilder();
            foreach (PropertyInfo property in peroperties)
            {
                sb.AppendLine(property.Name + ": " + property.GetValue(this) + ",");
            }
            return sb.ToString();
        }
    }

    

    public partial class TA_SUPERLIER
    {
        public override string ToString()
        {
            PropertyInfo[] peroperties = typeof(TA_SUPERLIER).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            StringBuilder sb = new StringBuilder();
            foreach (PropertyInfo property in peroperties)
            {
                sb.AppendLine(property.Name + ": " + property.GetValue(this) + ",");
            }
            return sb.ToString();
        }

    }
    
}