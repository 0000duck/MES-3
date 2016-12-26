using System;
using System.Collections.Generic;
using System.Linq;
using ChangKeTec.Wms.Models;

namespace ChangKeTec.Wms.Controllers
{
    public static class ReportViewController
    {
        /// <summary>
        /// 根据视图计算库存预警表，提前30天
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<VIEW_CalOverdue_DAYS> GetOverdueDaysList(SpareEntities db)
        {
            return db.VIEW_CalOverdue_DAYS.ToList();           
        }

        /// <summary>
        /// 根据视图计算安全库存表
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<VIEW_CalSafeQty> GetSafeQtysList(SpareEntities db)
        {
            return db.VIEW_CalSafeQty.ToList();
        }

        /// <summary>
        /// 根据视图查询盘点差异表
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<VIEW_INVENTORY_DETAIL> GetInventoryDetail(SpareEntities db)
        {
            return db.VIEW_INVENTORY_DETAIL.ToList();
        }

        /// <summary>
        /// 根据视图查询库存明细异表
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<VIEW_STOCK_DETAIL> GetStockDetail(SpareEntities db)
        {
            return db.VIEW_STOCK_DETAIL.ToList();
        }

        /// <summary>
        /// 根据视图查询库存呆滞表 一年没有移动的
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<VIEW_CalInaction_DAYS> GetCalInaction(SpareEntities db)
        {
            return db.VIEW_CalInaction_DAYS.ToList();
        }

        /// <summary>
        /// 根据视图查询库存在库时长表
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<VIEW_STOCK_DETAIL_AGE> GetStockDetailAge(SpareEntities db)
        {
            return db.VIEW_STOCK_DETAIL_AGE.ToList();
        }
    }
}