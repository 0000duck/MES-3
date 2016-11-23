using System;
using System.Collections.Generic;
using System.Linq;
using ChangKeTec.Wms.Models;

namespace ChangKeTec.Wms.Controllers.BaseData
{
    public static class SysConfig
    {
        public static bool IsProductInspect = false;
        public static bool IsOutSourceInspect = true;
        public static bool IsBackFlush = true;
        public static bool AutoFinishPartPick = true;

        public static string CcPartCode = "Cockpit";
        public static string CcProjectId = "X261CC";
        public static string LocCodeVinWip = "VinWIP";
        public static string LocCodeVinFg = "VinFG";
        public static string LocCodeVinSale = "VinSALE";
        public static List<string> IgnoreErpPartCodeList = new List<string> { "ELL00095-A", "PLL02432-A" };
        public static string LongTimeString { get; set; } = "yyyy-MM-dd HH:mm:ss";
        public static bool AutoHandleMaterialAsk = true;

        static SysConfig ()
        {
            Init();
        }

        private static void Init()
        {
            using (SpareEntities db = EntitiesFactory.CreateWmsInstance())
            {
                var configList = ConfigController.GetList(db);
                foreach (TA_CONFIG config in configList)
                {
                    switch (config.ParamName)
                    {
                        case "IsProductInspect":
                            IsProductInspect = Convert.ToBoolean(config.ParamValue);
                            break;
                        case "IsOutSourceInspect":
                            IsOutSourceInspect = Convert.ToBoolean(config.ParamValue);
                            break;
                        case "IsBackFlush":
                            IsBackFlush = Convert.ToBoolean(config.ParamValue);
                            break;
                        case "AutoFinishPartPick":
                            AutoFinishPartPick = Convert.ToBoolean(config.ParamValue);
                            break;
                        case "AutoHandleMaterialAsk":
                            AutoHandleMaterialAsk = Convert.ToBoolean(config.ParamValue);
                            break;
                        case "CcPartCode":
                            CcPartCode = config.ParamValue;
                            break;
                        case "CcProjectId":
                            CcProjectId = config.ParamValue;
                            break;
                        case "IgnoreErpPartCodeList":
                            IgnoreErpPartCodeList = config.ParamValue.Split(',').ToList();
                            break;
                        case "LocCodeVinWip":
                            LocCodeVinWip = config.ParamValue;
                            break;
                        case "LocCodeVinFg":
                            LocCodeVinFg = config.ParamValue;
                            break;
                        case "LocCodeVinSale":
                            LocCodeVinSale = config.ParamValue;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        
    }
}