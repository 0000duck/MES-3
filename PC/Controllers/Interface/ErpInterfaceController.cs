using System;
using System.Collections.Generic;
using System.Linq;
using ChangKeTec.Wms.Controllers.BaseData;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;

namespace ChangKeTec.Wms.Controllers.Interface
{
    public static class ErpInterfaceController
    {
        const string Sp = ",";
        const string ErpDateFormat = "MM/dd/yy";
        const string FileDateFormat = "yyMMdd";

        public static IEnumerable<TL_INTERFACE> GetNewList(SpareEntities db,ErpInterfaceType billType)
        {
            string strType = billType.ToString();

            var list = GetNewList(db).Where(p => p.InterfaceType == strType);
            return list;
        }

        public static IEnumerable<TL_INTERFACE> GetNewList(SpareEntities db)
        {
            var list = db.TL_INTERFACE.Where(p => p.State == (int) BillState.New);
            return list;
        }

        public static List<TL_INTERFACE> GetList(SpareEntities db)
        {
            var list = db.TL_INTERFACE.OrderByDescending(p => p.UID).ToList();
            return list;
        }



        /// <summary>
        /// 更新接口记录
        /// </summary>
        /// <param name="db"></param>
        /// <param name="interfaceType"></param>
        /// <param name="billNum"></param>
        /// <param name="billType"></param>
        /// <param name="pList"></param>
        private static void AddOrUpdateRecord(SpareEntities db, ErpInterfaceType interfaceType,string billNum, BillType billType, List<string> pList)
        {
            TL_INTERFACE erpInterface=null;
            string p01 = pList.Count > 00 ? pList[00] : "";
            string p02 = pList.Count > 01 ? pList[01] : "";
            string p03 = pList.Count > 02 ? pList[02] : "";
            string p04 = pList.Count > 03 ? pList[03] : "";
            string p05 = pList.Count > 04 ? pList[04] : "";
            string p06 = pList.Count > 05 ? pList[05] : "";
            string p07 = pList.Count > 06 ? pList[06] : "";
            string p08 = pList.Count > 07 ? pList[07] : "";
            string p09 = pList.Count > 08 ? pList[08] : "";
            string p10 = pList.Count > 09 ? pList[09] : "";
            string p11 = pList.Count > 10 ? pList[10] : "";
            string p12 = pList.Count > 11 ? pList[11] : "";
            string p13 = pList.Count > 12 ? pList[12] : "";
            string p14 = pList.Count > 13 ? pList[13] : "";
            string p15 = pList.Count > 14 ? pList[14] : "";
            string p16 = pList.Count > 15 ? pList[15] : "";
            string p17 = pList.Count > 16 ? pList[16] : "";
            string p18 = pList.Count > 17 ? pList[17] : "";
            string p19 = pList.Count > 18 ? pList[18] : "";
            string p20 = pList.Count > 19 ? pList[19] : "";

            switch (interfaceType)
            {
                   case ErpInterfaceType.TR:
                    erpInterface = db.TL_INTERFACE.FirstOrDefault(p =>
                        p.p01 == p01
//                        && p.p02 == p02 qty
                        && p.p03 == p03
                        && p.p04 == p04
                        && p.p05 == p05
                        && p.p06 == p06
                        && p.p07 == p07
                        && p.p08 == p08
                        && p.p09 == p09
                        && p.p10 == p10
                        && p.p11 == p11
                        && p.p12 == p12
                        && p.p13 == p13
                        && p.p14 == p14
                        && p.p15 == p15
                        && p.p16 == p16
                        && p.p17 == p17
                        && p.p18 == p18
                        && p.p19 == p19
                        && p.p20 == p20

                        );
                    break;
                    case ErpInterfaceType.BK:
                    erpInterface = db.TL_INTERFACE.FirstOrDefault(p =>
                        p.p01 == p01
                        && p.p02 == p02
                        && p.p03 == p03
                        && p.p04 == p04
                        && p.p05 == p05
                        && p.p06 == p06
                        && p.p07 == p07
                        && p.p08 == p08
                        && p.p09 == p09
                        && p.p10 == p10
                        && p.p11 == p11
                            //&& p.p12 == p12 qty
                        && p.p13 == p13
                        && p.p14 == p14
                        && p.p15 == p15
                        && p.p16 == p16
                        && p.p17 == p17
                        && p.p18 == p18
                        && p.p19 == p19
                        && p.p20 == p20

                        );
                    break;
                case ErpInterfaceType.SH:
                    erpInterface = db.TL_INTERFACE.FirstOrDefault(p =>
                        p.p01 == p01
                        && p.p02 == p02
                        && p.p03 == p03
                        && p.p04 == p04
                        && p.p05 == p05
                        //&& p.p06 == p06 //qty
                        && p.p07 == p07
                        && p.p08 == p08
                        && p.p09 == p09
                        && p.p10 == p10
                        && p.p11 == p11
                        && p.p12 == p12
                        && p.p13 == p13
                        && p.p14 == p14
                        && p.p15 == p15
                        && p.p16 == p16
                        && p.p17 == p17
                        && p.p18 == p18
                        && p.p19 == p19
                        && p.p20 == p20

                        );
                    break;

            }

            if (erpInterface == null)
            {
                erpInterface = new TL_INTERFACE
                {
                    BillType = billType.ToString(),
                    BillNum = billNum,
                    InterfaceType = interfaceType.ToString(),
                    State = (int)BillState.New,
                    CreateTime = DateTime.Now,
                    ProcessTime = DateTime.Now,
                    pQty = pList.Count,
                    p01 = pList.Count > 00 ? pList[00] : "",
                    p02 = pList.Count > 01 ? pList[01] : "",
                    p03 = pList.Count > 02 ? pList[02] : "",
                    p04 = pList.Count > 03 ? pList[03] : "",
                    p05 = pList.Count > 04 ? pList[04] : "",
                    p06 = pList.Count > 05 ? pList[05] : "",
                    p07 = pList.Count > 06 ? pList[06] : "",
                    p08 = pList.Count > 07 ? pList[07] : "",
                    p09 = pList.Count > 08 ? pList[08] : "",
                    p10 = pList.Count > 09 ? pList[09] : "",
                    p11 = pList.Count > 10 ? pList[10] : "",
                    p12 = pList.Count > 11 ? pList[11] : "",
                    p13 = pList.Count > 12 ? pList[12] : "",
                    p14 = pList.Count > 13 ? pList[13] : "",
                    p15 = pList.Count > 14 ? pList[14] : "",
                    p16 = pList.Count > 15 ? pList[15] : "",
                    p17 = pList.Count > 16 ? pList[16] : "",
                    p18 = pList.Count > 17 ? pList[17] : "",
                    p19 = pList.Count > 18 ? pList[18] : "",
                    p20 = pList.Count > 19 ? pList[19] : "",
                };
                db.TL_INTERFACE.Add(erpInterface);
            }
            else
            {
                switch (interfaceType)
                {
                    case ErpInterfaceType.TR:
                        pList[01] = (Convert.ToDecimal(erpInterface.p02) + Convert.ToDecimal(pList[01])).ToString();
                        erpInterface.p02 = pList[01];
                        break;
                    case ErpInterfaceType.BK:
                        pList[11] = (Convert.ToDecimal(erpInterface.p12) + Convert.ToDecimal(pList[11])).ToString();
                        erpInterface.p12 = pList[11];
                        break;
                    case ErpInterfaceType.SH:
                        pList[5] = (Convert.ToDecimal(erpInterface.p06) + Convert.ToDecimal(pList[5])).ToString();
                        erpInterface.p06 = pList[5];
                        break;
                }
            }
            var interfaceString = pList.Aggregate(string.Empty, (current, p) => current + (p + Sp));
            erpInterface.InterfaceString = interfaceString;
            erpInterface.CreateTime = DateTime.Now;
            erpInterface.ProcessTime = DateTime.Now;
        }

        

     
        public static void RemoveList(SpareEntities db, List<TL_INTERFACE> list)
        {
            db.TL_INTERFACE.RemoveRange(list);
        }
    }
}