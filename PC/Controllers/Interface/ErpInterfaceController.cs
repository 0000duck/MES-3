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
        /// 收货接口
        /// </summary>
        /// <param name="db"></param>
        /// <param name="partCode"></param>
        /// <param name="qty"></param>
        /// <param name="fromLocCode"></param>
        /// <param name="toLocCode"></param>
        /// <param name="billNum"></param>
        /// <param name="billType"></param>
        /// <param name="validTime"></param>
        public static void CreateRCT(SpareEntities db, string partCode, decimal qty, string fromLocCode, string toLocCode,string billNum, BillType billType, DateTime validTime)
        {
            var fromLoc = db.TA_STORE_LOCATION.FirstOrDefault(p => p.LocCode == fromLocCode);
            var toLoc = db.TA_STORE_LOCATION.FirstOrDefault(p => p.LocCode == toLocCode);
            var validDate = GetValidDate(db, validTime);

            //地点,料号,订单,日期,库位,数量
            //viam,2G0031C,sotest,15 / 05 / 22,a112,100
            List<string> pList = new List<string>
            {
                fromLoc?.ErpSiteCode, //地点
                partCode, //料号
                billNum, //订单
                validDate.ToString(ErpDateFormat), //日期
                toLoc?.ErpLocCode, //库位
                qty.ToString(), //数量
            };
            AddOrUpdateRecord(db, ErpInterfaceType.SH, validDate.ToString(FileDateFormat), billType, pList);

        }

        /// <summary>
        /// 销售接口
        /// </summary>
        /// <param name="db"></param>
        /// <param name="partCode"></param>
        /// <param name="qty"></param>
        /// <param name="fromLocCode"></param>
        /// <param name="toLocCode"></param>
        /// <param name="billNum"></param>
        /// <param name="billType"></param>
        /// <param name="validTime"></param>
        public static void CreateSH(SpareEntities db,  string partCode, decimal qty,string fromLocCode,string toLocCode, string billNum, BillType billType, DateTime validTime)
        {
            var fromLoc = db.TA_STORE_LOCATION.FirstOrDefault(p => p.LocCode == fromLocCode);
            var toLoc = db.TA_STORE_LOCATION.FirstOrDefault(p => p.LocCode == toLocCode);
            var validDate = GetValidDate(db, validTime);

            //sh*.in
            //地点,料号,订单,日期,库位,数量
            //viam,2G0031C,sotest,15 / 05 / 22,a112,100
            List<string> pList = new List<string>
            {
                fromLoc?.ErpSiteCode, //地点
                partCode, //料号
                billNum, //订单
                validDate.ToString(ErpDateFormat), //日期
                fromLoc?.ErpLocCode, //库位
                qty.ToString(), //数量
            };
            AddOrUpdateRecord(db, ErpInterfaceType.SH, billNum, billType, pList);

        }

        /// <summary>
        /// 移库接口
        /// </summary>
        /// <param name="db"></param>
        /// <param name="partCode"></param>
        /// <param name="qty"></param>
        /// <param name="fromLocCode"></param>
        /// <param name="toLocCode"></param>
        /// <param name="billNum"></param>
        /// <param name="billType"></param>
        /// <param name="validTime"></param>
        public static void CreateTR(SpareEntities db,string partCode,decimal qty, string fromLocCode, string toLocCode,string fromBatch,string toBatch,string billNum, BillType billType,DateTime validTime)
        {
            var fromLoc = db.TA_STORE_LOCATION.FirstOrDefault(p => p.LocCode == fromLocCode);
            var toLoc = db.TA_STORE_LOCATION.FirstOrDefault(p => p.LocCode == toLocCode);
            if (fromLoc?.ErpSiteCode == toLoc?.ErpSiteCode && fromLoc?.ErpLocCode == toLoc?.ErpLocCode)return;

            var validDate = GetValidDate(db, validTime);

            var fromRefCode = "";
            var toRefCode = "";

            //tr*.in
            //FGD1I001-A,1,YES,至,YES,,CIAICC,FG-Q5,052 4PZQG3E2211,Q5-01,CIAICC,ROAD,052 4PZQG6P343K,吉AH9518,16/06/27,

            List<string> pList = new List<string>
            {
                partCode,
                qty.ToString(),
                "YES",
                "至",
                "YES",
                "",
                fromLoc?.ErpSiteCode,
                fromLoc?.ErpLocCode,
                fromBatch,
                fromRefCode,
                toLoc?.ErpSiteCode,
                toLoc?.ErpLocCode,
                toBatch,
                toRefCode,
                validDate.ToString(ErpDateFormat)
            };

            AddOrUpdateRecord(db, ErpInterfaceType.TR, billNum, billType, pList);

        }

        /// <summary>
        /// 回冲接口
        /// </summary>
        /// <param name="db"></param>
        /// <param name="partCode"></param>
        /// <param name="qty"></param>
        /// <param name="fromLocCode"></param>
        /// <param name="toLocCode"></param>
        /// <param name="billNum"></param>
        /// <param name="billType"></param>
        /// <param name="validTime"></param>
        public static void CreateBK(SpareEntities db,string partCode,decimal qty,string fromLocCode,string toLocCode,string billNum, BillType billType,DateTime validTime)

        {
          
            var fromLoc = db.TA_STORE_LOCATION.FirstOrDefault(p => p.LocCode == fromLocCode);
            var toLoc = db.TA_STORE_LOCATION.FirstOrDefault(p => p.LocCode == toLocCode);
            var validDate = GetValidDate(db, validTime);

            //            bk *.in
            //            BJW,,10000,00 - 001,10,00 - 001,,,,,,3,,,,,,07 / 10 / 16,  
            List<string> pList = new List<string>
            {
                "004" , //< Empplyee雇员 >,
                "01" , //< Shift班次 >,
                toLoc?.ErpSiteCode , //< Site地点 >,
                partCode , //< Item Number零件号 >,
                "10" , //< Operation工序 >,
                "X261" , //< Line生产线 >,
                "" , //< Routing置空 >
                "" , //< BOM置空 >
                "" , //< Work Center置空 >
                "" , //< Machine置空 >
                "" , // < Department置空 >
                qty.ToString() , //< Qty Processed完工数量 >,
                "" , //< Qty Scrapped废品数量 >,
                "" , //< Reason Code置空 >
                "" , //< Qty Rejected置空 >
                "" , //< Reason Code置空 >
                toLoc?.ErpLocCode , //< 入库库位 >
                validDate.ToString(ErpDateFormat)  //< eff date生效日期 >,
            };
            AddOrUpdateRecord(db, ErpInterfaceType.BK,billNum, billType, pList);

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

        /// <summary>
        /// 获取生效日期
        /// </summary>
        /// <param name="db"></param>
        /// <param name="validTime"></param>
        /// <returns></returns>
        private static DateTime GetValidDate(SpareEntities db, DateTime validTime)
        {
            var billTime = PaymentDayController.GetPaymentDay(db, validTime);
            return billTime?.EndTime ?? validTime;
        }
        

        public static void AddHisList(SpareEntities db, List<TL_INTERFACE> list)
        {
            var bakList = new List<TS_INTERFACE_HIS>();
            foreach (TL_INTERFACE t in list)
            {
                t.State = (int)BillState.Finished;
                t.ProcessTime = DateTime.Now;

                var bak = new TS_INTERFACE_HIS
                {
                    CreateTime = t.CreateTime,
                    InterfaceString = t.InterfaceString,
                    InterfaceType = t.InterfaceType,
                    ProcessTime = t.ProcessTime,
                    Remark = t.Remark,
                    State = t.State,
                    BillNum = t.BillNum,
                    BillType = t.BillType,
                    pQty = t.pQty,
                    p01 = t.p01,
                    p02 = t.p02,
                    p03 = t.p03,
                    p04 = t.p04,
                    p05 = t.p05,
                    p06 = t.p06,
                    p07 = t.p07,
                    p08 = t.p08,
                    p09 = t.p09,
                    p10 = t.p10,
                    p11 = t.p11,
                    p12 = t.p12,
                    p13 = t.p13,
                    p14 = t.p14,
                    p15 = t.p15,
                    p16 = t.p16,
                    p17 = t.p17,
                    p18 = t.p18,
                    p19 = t.p19,
                    p20 = t.p20,
                };
                bakList.Add(bak);
                //
                //                WmsDb.TL_INTERFACE.AddOrUpdate(p=>p.UID,t);
            }
            db.TS_INTERFACE_HIS.AddRange(bakList);
        }

        public static void RemoveList(SpareEntities db, List<TL_INTERFACE> list)
        {
            db.TL_INTERFACE.RemoveRange(list);
        }
    }
}