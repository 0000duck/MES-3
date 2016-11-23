using System.Data;
using System.Linq;
using System.Reflection;
using System.Web.Services;
using ChangKeTec.Wms.Bll;
using ChangKeTec.Wms.Entity;
using ChangKeTec.Wms.Entity.Enums;
using ChangKeTec.Wms.Util;

namespace ChangKeTec.Wms.WebService
{
    /// <summary>
    /// Service1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class PdaService : System.Web.Services.WebService
    {
        WmsEntities rdb = EntitiesFactory.CreateWmsInstance();

        [WebMethod]
        public string GetVer()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        [WebMethod]
        public TS_OPERATOR Login(string operCode, string password)
        {
            PowerEntities db = EntitiesFactory.CreatePowerInstance();
            var oper = OperController.Login(db, operCode, password);
            //            if (oper != null) oper.State = LoginState.Online.ToString();
            EntitiesFactory.SaveDb(db);
            return oper;
        }

        [WebMethod]
        public void Logout(TS_OPERATOR oper)
        {
//            WMSDBEntities db = EntitiesFactory.CreateWmsInstance();
////            oper.State = LoginState.Offline.ToString();
//            OperController.Logout(db, oper);
//            db.SaveChanges();
        }

        [WebMethod]
        public void ModifyPassword(TS_OPERATOR oper)
        {
            PowerEntities db = EntitiesFactory.CreatePowerInstance();
            OperController.AddOrModify(db, oper);
            EntitiesFactory.SaveDb(db);
        }

        [WebMethod]
        public ServiceState AddData(ServiceType type, DataSet ds,BillType? billType =null)
        {
            ServiceState state = ServiceState.NoError;
            switch (type)
            {
                case ServiceType.AddBill:
                    state = billType == null ? ServiceState.BillNumError : AddBill(billType.Value, ds);
                    break;
            }
            return state;
        }

        private ServiceState AddBill(BillType billType, DataSet ds)
        {
            ServiceState state = ServiceState.NoError;
            DataTable dt = new DataTable();
            switch (billType)
            {
                case BillType.MaterialIn:
                    dt = ds.Tables[0];
                    var bill = ConvertHelper.DataTableToEntity<TB_BILL>(dt);
                    dt = ds.Tables[1];
                    var details = ConvertHelper.DataTableToList<TB_MATERIAL_IN>(dt);
                    state =BillHandler.AddMaterialIn( bill, details);
                    break;
            }
            return state;
        }

        [WebMethod]
        public DataSet GetData(ServiceType type,DataSet ds, string strIndex = null,BillType? billType=null)
        {
            DataSet rds = new DataSet();
            DataTable dt = new DataTable();
            switch (type)
            {
                case ServiceType.GetBill:
                    if (billType == null) return rds;
                    rds = GetBill(billType.Value,strIndex);
                    break;

                case ServiceType.GetPartByPartCode:
                    var part = PartController.GetPartByPartCode(rdb, strIndex);
                    dt = ConvertHelper.EntityToDataTable(part);
                    rds.Tables.Add(dt);
                    break;
                case ServiceType.GetPartList:
                    var partList = PartController.GetList(rdb);
                    dt = ConvertHelper.ListToDataTable(partList);
                    rds.Tables.Add(dt);
                    break;
            }

            return rds;
        }

        private DataSet GetBill(BillType billType,string billNum)
        {
           DataSet rds = new DataSet();
            DataTable dt = new DataTable();
            switch (billType)
            {
                case BillType.SortedDeliver:
                    var bill = SortBillController.GetBill(rdb, billNum);
                    dt = ConvertHelper.EntityToDataTable(bill);
                    rds.Tables.Add(dt);
                    var details = SortDetailController.GetList(rdb, billNum);
                    dt = ConvertHelper.ListToDataTable(details);
                    rds.Tables.Add(dt);
                    break;
            }
            return rds;
        }

        [WebMethod]
        public ServiceState UpdateData(ServiceType type, DataSet ds,BillType? billType=null)
        {
            ServiceState state= ServiceState.NoError;
            switch (type)
            {
                case ServiceType.UpdateBill:
                    state = billType==null ? ServiceState.BillNumError : UpdateBill(billType.Value, ds);
                    break;
            }
            return state;
        }

        private ServiceState UpdateBill(BillType billType, DataSet ds)
        {
            ServiceState state = ServiceState.NoError;
            DataTable dt = new DataTable();
            switch (billType)
            {
                case BillType.SortedDeliver:
                    dt = ds.Tables[0];
                    var sortBill = ConvertHelper.DataTableToEntity<TS_SORT_BILL>(dt);
                    BillHandler.UpdateSortBill("", sortBill);
                    break;
            }
            return state;
        }

        [WebMethod]
        public TB_BILL GetBill(string billNum)
        {
            TB_BILL bill = new TB_BILL();
            bill = BillController.GetBill(rdb, billNum);
            return bill;
        }

        [WebMethod]
        public TB_BILL GetSourceBill(string sourceBillNum)
        {
            TB_BILL bill = new TB_BILL();
            bill = BillController.GetSourceBill(rdb, sourceBillNum);
            return bill;
        }

        [WebMethod]
        public TB_BILL[] GetBills(BillType billType)
        {
            return  BillController.GetList(rdb,billType).ToArray();
        }


        [WebMethod]
        public VB_CHECK_DETAIL[] GetCheckDetails(string billNum)
        {
            VB_CHECK_DETAIL[] details = CheckController.GetDetailList(rdb, billNum).ToArray();
            return details;
        }
        [WebMethod]
        public TA_PART GetPart(string partCode)
        {
            return PartController.GetPartByErpCode(rdb, partCode);
        }

        [WebMethod]
        public VS_STOCK GetStock(string barCode,string locCode)
        {
            return StockController.GetStock(rdb, barCode,locCode);
        }

        [WebMethod]
        public VS_STOCK[] GetStockList(string areaCode,string locCode)
        {
            return StockController.GetList(rdb, areaCode, locCode).ToArray();
        }

        [WebMethod]
        public TA_PAYMENT_DAY[] GetBillTimes()
        {
            return BillTimeController.GetList(rdb).ToArray();
        }

        [WebMethod]
        public TA_PART[] GetParts()
        {
            return PartController.GetList(rdb).ToArray();
        }

        [WebMethod]
        public TA_TRUCK[] GetTrucks()
        {
            return TruckController.GetList(rdb).ToArray();
        }

        [WebMethod]
        public StoreArea[] GetAreas()
        {
            return EnumHelper.EnumToList<StoreArea>().ToArray();
        }

        [WebMethod]
        public TA_STORE_LOCATION[] GetLocs()
        {
            return StoreLocationController.GetList(rdb).ToArray();
        }

        [WebMethod]
        public TS_CONFIG[] GetConfigs()
        {
            return ConfigController.GetList(rdb).ToArray();
        }

        [WebMethod]
        public BillState GetState()
        {
            return BillState.New;
        }

        [WebMethod]
        public StoreArea GetArea()
        {
            return StoreArea.FG;
        }

        [WebMethod]
        public TS_SORT_BILL GetSortBill(string billNum)
        {
            return SortBillController.GetBill(rdb, billNum);
        }

        [WebMethod]
        public TS_SORT_DETAIL[] GetSortDetailList(string billNum)
        {
            return SortDetailController.GetList(rdb, billNum).ToArray();
        }

        [WebMethod]
        public void UpdateSortBill(TS_SORT_BILL sortBill)
        {
            BillHandler.UpdateSortBill("", sortBill);
        }

        //        [WebMethod]
        //        public void StockMove(string barCode, string areaCode, string locCode)
        //        {
        //            WMSDBEntities db = EntitiesFactory.CreateWmsInstance();
        //
        //                StockController.UpdateStock(db, barCode, areaCode, locCode,BillType.StockMove.ToString(),"");
        //                db.SaveChanges();
        //        }
        /*

                [WebMethod]
                public void StockMove(TB_BILL bill, VB_DETAIL[] detailList)
                {
                    Bill.OtherInOutAdd(bill, detailList.ToList());
                }

                [WebMethod]
                public void FactoryDirectSendAdd(TB_BILL bill, VB_DETAIL[] detailList, string truckCode)
                {
                    Bill.FactoryDirectSendAdd(bill,detailList.ToList(),truckCode);            
                }

                [WebMethod]
                public void PartReturnAdd(TB_BILL bill, VB_DETAIL[] detailList)
                {
                    Bill.PartReturnAdd(bill, detailList.ToList());
                }

                [WebMethod]
                public void OtherInOutAdd(TB_BILL bill, VB_DETAIL[] detailList)
                {
                    Bill.OtherInOutAdd(bill, detailList.ToList());
                }

                [WebMethod]
                public void FactoryTransferSendUpdate(TB_BILL bill, VB_DETAIL[] detailList, string truckCode)
                {
                    Bill.FactoryTransferSendUpdate(bill, detailList.ToList(),  truckCode);
                }

                [WebMethod]
                public void WhseSendUpdate(TB_BILL bill, VB_DETAIL[] detailList)
                {
                    Bill.WhseSendUpdate(bill, detailList.ToList());
                }

                [WebMethod]
                public void FactoryDirectSendUpdate(TB_BILL bill, VB_DETAIL[] detailList)
                {
                    Bill.FactoryDirectSendFinish(bill, detailList.ToList());
                }

                [WebMethod]
                public void WhseReceiveAdd(TB_BILL bill, VB_DETAIL[] detailList,string toLocCode)
                {
                    Bill.WhseReceiveAdd(bill, detailList.ToList(),toLocCode);
                }

                [WebMethod]
                public void WhseCheckAdd(TB_BILL bill, VB_CHECK_DETAIL[] detailList)
                {
                    Bill.WhseCheckAdd(bill, detailList.ToList());
                }

        */

    }
}
