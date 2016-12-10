using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using ChangKeTec.Wms.Common;
using ChangKeTec.Wms.Controllers.BaseData;
using ChangKeTec.Wms.Controllers.Bill;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;

namespace ChangKeTec.Wms.WinForm
{
    public static class GlobalVar
    {
        public static TS_OPERATOR Oper { get; set; }
        public static List<VS_POWER_MENU> PowerMenuList { get; set; }
        public static List<TS_ROLE_NOTIFYTYPE> NotifytypeList { get; set; }
        public const string PortalCode = "SPAREPC";

        public static List<TA_CONFIG> ConfigList { get; set; }
        public static SortableBindingList<TL_NOTIFY> NotifyList { get; set; }


        public static PrintType PrintType { get; set; }
        public static int DefaultPreDays { get; set; }

        public static string PrintTemplatePath { get; set; } = @"\PrintTemplate\";
        public static string ImportTemplatePath { get; set; } = @"\ImportTemplate\";
        public static string LongTimeString { get; set; } = "yyyy-MM-dd HH:mm:ss";

        public const string WmsDbServer = "WmsDbServer";
        public const string WmsDbPort = "WmsDbPort";
        public const string WmsDbUser = "WmsDbUser";
        public const string WmsDbPassword = "WmsDbPassword";
        public const string WmsDbName = "WmsDbName";

        public const string PowerDbServer = "PowerDbServer";
        public const string PowerDbPort = "PowerDbPort";
        public const string PowerDbUser = "PowerDbUser";
        public const string PowerDbPassword = "PowerDbPassword";
        public const string PowerDbName = "PowerDbName";

        public const string UpdateServerUrl = "UpdateServerUrl";
        public const string UpdateFileName = "UpdateFileName";

             
        public static void InitGlobalVar(SpareEntities db, TS_OPERATOR oper)
        {
            Oper = oper;

            ConfigList = ConfigController.GetList(db);
            //GetConfig();


        }
        
        private static void GetConfig()
        {
            var strPrintType = ConfigList.Single(p => p.ParamName == "PrintType").ParamValue;
            PrintType printType;
            if (Enum.TryParse(strPrintType, true, out printType))
                PrintType = printType;
            DefaultPreDays = 3;
//            DefaultPreDays = Convert.ToInt32(ConfigList.Single(p => p.ParamName == "DefaultPreDays").ParamValue);
        }

        public static void InitGlobalVar(SpareEntities db)
        {
            InitGlobalVar(db,Oper);
        }

        public static bool GetNotifyList(SpareEntities db)
        {
            var list = NotifyController.GetNewList(db);
            if (NotifyList==null||list.Count(p=>p.State==(int)BillState.New) != NotifyList.Count(p => p.State == (int)BillState.New))
            {
                NotifyList = new SortableBindingList<TL_NOTIFY>(list);
                return true;
            }
            return false;
        }

        public static void CloseNotify(int id,Form form)
        {
            var notify = NotifyList.SingleOrDefault(p => p.UID == id);
            if (notify == null) return;
            if (notify.State == (int) BillState.Finished) return;
            using (SpareEntities db = EntitiesFactory.CreateSpareInstance())
            {
                try
                {
                    NotifyController.CloseNotify(db, GlobalVar.Oper.OperName, notify);
                    EntitiesFactory.SaveDb(db);

                }
                catch (Exception ex)
                {
                    MessageHelper.ShowInfo(ex.ToString());

                }

            }
            NotifyType notifyType = (NotifyType) notify.NotifyType;
            var formMain = (FormMain)form;
            if (formMain == null) return;
          /*  switch (notifyType)
            {
                case NotifyType.Ask:
                    formMain.SetMdiForm("仓库申请单", typeof(FormWhseAskView));
                    break;
                case NotifyType.Stock:
                    formMain.SetMdiForm("仓库库存", typeof(FormStockProduct));
                    break;
                case NotifyType.TransferSend:
                    formMain.SetMdiForm("中转发运单", typeof(FormFactoryTransferSend));
                    break;
                case NotifyType.DirectSend:
                    formMain.SetMdiForm("直送发运单", typeof(FormFactoryDirectSend));
                    break;
                case NotifyType.WhseSend:
                    formMain.SetMdiForm("仓库发运单", typeof(FormWhseSend));
                    break;
            }*/

        }
     
    }
}