using System;
using System.Linq;
using System.Text;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;

namespace ChangKeTec.Wms.Controllers.BaseData
{
    public static class BillTypeController
    {
        const char Separator = '-';

        public static string GetBillNum(BillType billType)
        {
            using (var db = EntitiesFactory.CreateSpareInstance())
            {
                var bt = db.TA_BILLTYPE.SingleOrDefault(p => p.BillType == (int)billType);
                var rules = bt.BillNumRule.Split('|');
                var sb = CreateNewBillNum(rules, bt);
                var strBillNum = sb.TrimEnd(Separator);
                bt.LastNumber += 1;
                bt.LastBillNum = strBillNum;
                bt.LastBillTime = DateTime.Now;
                EntitiesFactory.SaveDb(db);
                return strBillNum;
            }
        }


        private static string CreateNewBillNum(string[] rules, TA_BILLTYPE bt)
        {
            var sb = new StringBuilder();
            foreach (var rule in rules)
            {
                var cs = rule.Split(':');
                var condName = cs[0];
                var condValue = "";
                if (cs.Length > 1)
                    condValue = cs[1];
                switch (condName)
                {
                    case "P":
                        sb.Append(bt.Prefix);
                        break;
                    case "D":
                        var sDate = string.Empty;
                        switch (condValue)
                        {
                            case "l":
                                sDate = DateTime.Now.ToString("yyyyMMdd");
                                break;
                            case "s":
                                sDate = DateTime.Now.ToString("yyMMdd");
                                break;
                        }
                        sb.Append(sDate);
                        break;
                    case "T":
                        var sTime = string.Empty;
                        switch (condValue)
                        {
                            case "l":
                                sTime = DateTime.Now.ToString("hhmmss");
                                break;
                            case "s":
                                sTime = DateTime.Now.ToString("hhmm");
                                break;
                        }
                        sb.Append(sTime);
                        break;
                    case "N":
                        if (DateTime.Now.DayOfYear - bt.LastBillTime.DayOfYear > 0)
                            bt.LastNumber = 1;
                        var serialCount = Convert.ToInt32(condValue);
                        var sNumber = GetSerialNumStr(serialCount, bt.LastNumber);
                        sb.Append(sNumber);
                        break;
                }
                sb.Append(Separator);
            }
            return sb.ToString();
        }

        public static string GetSerialNumStr(int serialCount, int serialNum)
        {
            string serialNumStr = string.Empty;
            if (serialNum == 0) return serialNumStr;
//            serialNumStr += Separator;
            int n = serialNum.ToString().Length;
            for (int i = 0; i < serialCount - n; i++)
            {
                serialNumStr += "0";
            }
            serialNumStr += serialNum.ToString();
            return serialNumStr;
        }


    }
}