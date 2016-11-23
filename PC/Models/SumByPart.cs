namespace ChangKeTec.Wms.Models
{
    public class SumByPart
    {
        public string ErpPartCode { get; set; }
        public string AreaCode { get; set; }
        public string CustPartCode { get; set; }
        public string PartDesc1 { get; set; }
        public string PartDesc2 { get; set; }
        public string ProjectId { get; set; }
        public decimal Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
        public decimal MaxQty { get; set; }
        public decimal MinQty { get; set; }
        public decimal SafeQty { get; set; }

    }

    public class SumByLoc
    {
        public string PartCode { get; set; }
        public string CustPartCode { get; set; }
        public string PartDesc1 { get; set; }
        public string PartDesc2 { get; set; }
        public string ProjectId { get; set; }
        public string AreaCode { get; set; }
        public string LocCode { get; set; }
        public string RefCode { get; set; }
        public decimal Qty { get; set; }
    }

    public class SumVinByDate
    {
        public string Date { get; set; }
        public string Shift { get; set; }
        public string ProjectId { get; set; }
        public decimal Qty { get; set; }
    }

    public class SumPartByDate
    {
        public string Date { get; set; }
        public string Shift { get; set; }
        public string ErpPartCode { get; set; }
        public string CustPartCode { get; set; }
        public string PartDesc1 { get; set; }
        public string PartDesc2 { get; set; }
        public string ProjectId { get; set; }
        public decimal Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
    }
}
