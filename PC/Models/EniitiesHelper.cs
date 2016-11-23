using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using ChangKeTec.Wms.Utils;

namespace ChangKeTec.Wms.Models
{
    public static class EniitiesHelper
    {
        public static List<dynamic> GetData<T, TKey>(DbContext db, Expression<Func<T, dynamic>> select,
            Expression<Func<T, bool>> where, Expression<Func<T, TKey>> order, out int count)
            where T : class
        {
            List<dynamic> list = null;
            count = 0;
            try
            {
                count = db.Set<T>().Where(where).Count();
                list =
                    db.Set<T>()
                        .Where(where)
                        .OrderBy(order)
                        .Select(select).ToList();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex);
            }
            return list;

        }

        public static List<dynamic> GetPagedDataAsc<T, TKey>(DbContext db,Expression<Func<T, dynamic>> select,
            Expression<Func<T, bool>> where, Expression<Func<T, TKey>> order, int pageIndex, int pageSize, out int total)
            where T : class
        {
            List<dynamic> list = null;
            total = 0;
            try
            {
                total = db.Set<T>().Where(where).Count();
                list =
                    db.Set<T>()
                        .Where(where)
                        .OrderBy(order)
                        .Select(select)
                        .Skip((pageIndex - 1)*pageSize)
                        .Take(pageSize).ToList();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex);
            }
            return list;

        }

        public static List<dynamic> GetPagedDataDesc<T, TKey>(DbContext db, Expression<Func<T, dynamic>> select,
            Expression<Func<T, bool>> where, Expression<Func<T, TKey>> order, int pageIndex, int pageSize, out int total)
            where T : class
        {
            List<dynamic> list = null;
            total = 0;
            try
            {
                total = db.Set<T>().Where(where).Count();
                list =
                    db.Set<T>()
                        .Where(where)
                        .OrderByDescending(order)
                        .Select(select)
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex);
            }
            return list;
        }
    }
}