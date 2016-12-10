using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ChangKeTec.Wms.Models.Enums;

namespace ChangKeTec.Wms.Models
{
    public static class GlobalBuffer
    {
/*
        public static List<string> InvalidAreaList = new List<string>
            {
                StoreArea.OTHER.ToString(),
                StoreArea.UNDECIDE.ToString(),
                StoreArea.SCRAP.ToString()
            };
*/


        private static readonly SpareEntities Db = EntitiesFactory.CreateSpareInstance();
        private static List<TA_PART> _partList=new List<TA_PART>();
        public static List<TA_PART> PartList
        {
            get
            {
                if(!_partList.Any())
                    _partList = Db.TA_PART.ToList();
                return _partList;
            }
        }

        private static List<TA_WORKLINE> _worklineList = new List<TA_WORKLINE>();
        private static List<TA_BILLTYPE> _billTypeList=new List<TA_BILLTYPE>();
        private static List<TA_STORE_LOCATION> _locList=new List<TA_STORE_LOCATION>();

        public static List<TA_WORKLINE> WorklineList
        {
            get
            {
                if (!_worklineList.Any())
                    _worklineList = Db.TA_WORKLINE.ToList();
                return _worklineList;
            }
        }

        public static List<TA_BILLTYPE> BillTypeList
        {
            get
            {
                if (!_billTypeList.Any())
                    _billTypeList = Db.TA_BILLTYPE.ToList();
                return _billTypeList;
            }
        }

        public static List<TA_STORE_LOCATION> LocList
        {
            get
            {
                if (!_locList.Any())
                    _locList = Db.TA_STORE_LOCATION.ToList();
                return _locList;
            }
        }

        public static int GetValidateDays(string partCode)
        {
            var part = GlobalBuffer.PartList.SingleOrDefault(p => p.PartCode == partCode);
            int days = part?.ValidityDays ?? 36500;
            return days;
        }

    }
}