using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using ChangKeTec.Wms.Controllers.BaseData;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;

namespace ChangKeTec.Wms.Controllers.Bill
{
    public static class StockController
    {


        public static VS_STOCK GetV(SpareEntities db, string partCode,  string locCode)
        {
            var stock = db.VS_STOCK.SingleOrDefault(p => p.PartCode == partCode
                                                         && p.LocCode == locCode);
            return stock;
        }

        public static VS_STOCK Get(SpareEntities db, string locCode,string partCode, string batch)
        {
            var stock = db.VS_STOCK.Find(locCode, partCode, batch);
            return stock;
        }


        public static List<VS_STOCK> GetVListByPart(SpareEntities db, string partCode)
        {
            var stockList = db.VS_STOCK.Where(p => p.PartCode == partCode).ToList();
            return stockList;
        }
        
        



        public static List<VS_STOCK> GetVList(SpareEntities db,  string locCode)
        {
            var list = db.VS_STOCK.Where(p =>p.LocCode==locCode).ToList();
            return list;
        }

    

        public static List<VS_STOCK> GetListByPart(SpareEntities db, string partCode)
        {
            return db.VS_STOCK.Where(p => p.PartCode == partCode).ToList();
        }

        public static List<VS_STOCK> GetList(SpareEntities db)
        {
            return db.VS_STOCK.ToList();
        }
    }
}