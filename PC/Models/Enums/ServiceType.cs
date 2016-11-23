namespace ChangKeTec.Wms.Models.Enums
{
    public enum ServiceType
    {
        GetConfigList,
        GetWhseList,
        GetAreaList,
        GetGroupList,
        GetLocList,
        GetPartList,
        GetSupplierList,
        GetCustomerList,
        GetShiftList,
        GetTeamList,
        GetWorklineList,
        GetBomList,

        GetLocByLocCode,
        GetPartByPartCode,
        GetPartByErpPartCode,
        GetCustPartByCustPartCode,
        PoByCode,
        AsnByCode,
        ProducePlan,
        SoByCode,
        GetEqptByCode,

        GetStock,
        GetStockList,

        GetBill,
        GetBillList,
        GetSourceBill,

        AddBill,
        StartBill,

        InventoryLoc,
        FinishBill,
        GetInventoryLoc,
        GetStockDetailList,
        CancelBill,
        GetOtscByID,
        GetPdaPowerMenu
    }
} 