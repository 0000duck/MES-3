using System;
using System.Collections.Generic;
using System.Linq;
using ChangKeTec.Wms.Models;

namespace ChangKeTec.Wms.Controllers
{
    public static class ReportViewController
    {
        /// <summary>
        /// ������ͼ������Ԥ������ǰ30��
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<VIEW_CalOverdue_DAYS> GetOverdueDaysList(SpareEntities db)
        {
            return db.VIEW_CalOverdue_DAYS.ToList();           
        }

        /// <summary>
        /// ������ͼ���㰲ȫ����
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<VIEW_CalSafeQty> GetSafeQtysList(SpareEntities db)
        {
            return db.VIEW_CalSafeQty.ToList();
        }

        /// <summary>
        /// ������ͼ��ѯ�̵�����
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<VIEW_INVENTORY_DETAIL> GetInventoryDetail(SpareEntities db)
        {
            return db.VIEW_INVENTORY_DETAIL.ToList();
        }

        /// <summary>
        /// ������ͼ��ѯ�����ϸ���
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<VIEW_STOCK_DETAIL> GetStockDetail(SpareEntities db)
        {
            return db.VIEW_STOCK_DETAIL.ToList();
        }

        /// <summary>
        /// ������ͼ��ѯ�����ͱ� һ��û���ƶ���
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<VIEW_CalInaction_DAYS> GetCalInaction(SpareEntities db)
        {
            return db.VIEW_CalInaction_DAYS.ToList();
        }

        /// <summary>
        /// ������ͼ��ѯ����ڿ�ʱ����
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<VIEW_STOCK_DETAIL_AGE> GetStockDetailAge(SpareEntities db)
        {
            return db.VIEW_STOCK_DETAIL_AGE.ToList();
        }
    }
}