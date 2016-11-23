using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;

namespace ChangKeTec.Wms.Utils
{
    public static class ListHelper
    {
        public static IList<T> SearchList<T>(IEnumerable<T> tList, string txt)
        {
            IList<T> selectedList = new List<T>();
            foreach (var t in tList)
            {
                var a = typeof(T);
                var ps = a.GetProperties();
                foreach (PropertyInfo info in ps)
                {
                    object o = info.GetValue(t);
                    if (o != null && o.ToString().Contains(txt))
                    {
                        selectedList.Add(t);
                        break;
                    }
                }
            }

            return selectedList;
        }

        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            return source.Where(element => seenKeys.Add(keySelector(element)));
        }

        public static T DataTableToEntity<T>(DataTable dt) where T : new()
        {
            var t = new T();
            var tList = DataTableToList<T>(dt);
            if (tList.Count > 0)
                t = tList[0];
            return t;
        }

        public static List<T> DataTableToList<T>(DataTable dt) where T : new()
        {
            List<T> tList = new List<T>();
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    var t = new T();
                    var propertys = t.GetType().GetProperties();
                    foreach (var pi in propertys)
                    {
                        object value = null;
                        var piName = pi.Name;


                        if (dt.Columns.Contains(piName))
                        {
                            value = ConverToType(dr[piName], pi.PropertyType);
                        }

                        if (!pi.CanWrite) continue;
                        try
                        {
                            pi.SetValue(t, value, null);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            throw;
                        }

                    }
                    tList.Add(t);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return tList;
        }

        public static DataTable EntityToDataTable<T>(T t) where T : new()
        {
            if(t==null) return new DataTable();
            var tList = new List<T> { t };
            var dt = ListToDataTable(tList, t.GetType().Name);
            return dt;
        }

        public static DataSet EntityToDataSet<T>(T t) where T : new()

        {
            if (t == null) return new DataSet();
            var tList = new List<T> { t };
            var dt = ListToDataTable(tList, t.GetType().Name);
            var ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        public static DataSet ListToDataSet<T>(List<T> tList) where T : new()
        {
            var t = new T();
            var dt = ListToDataTable(tList, t.GetType().Name);
            var ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        public static DataTable ListToDataTable<T>(List<T> tList) where T : new()
        {
            if (tList == null) return new DataTable();
            var t = new T();
            var dt = ListToDataTable(tList, t.GetType().Name);
            return dt;
        }

        public static DataTable ListToDataTable<T>(List<T> tList, string tableName) where T : new()
        {
            var dt = new DataTable { TableName = tableName };
            if (tList == null) return dt;
            if (tList.Count == 0) return dt;
            var t = new T();
            var properties = t.GetType().GetProperties();
            foreach (var pi in properties)
            {
                // The the type of the property
                Type columnType = pi.PropertyType;

                // We need to check whether the property is NULLABLE
                if (pi.PropertyType.IsGenericType &&
                    pi.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    // If it is NULLABLE, then get the underlying type. eg if "Nullable<int>" then this will return just "int"
                    columnType = pi.PropertyType.GetGenericArguments()[0];
                }

                // Add the column definition to the datatable.
                dt.Columns.Add(new DataColumn(pi.Name, columnType));
                //                        dc = new DataColumn(columnName,pi.PropertyType); 
                //                        dt.Columns.Add(dc);

            }
            foreach (var tt in tList)
            {
                //TODO
                var dr = dt.NewRow();
                foreach (var pi in properties)
                {
                    var columnName = pi.Name;
                    var value = pi.GetValue(tt, null);

                    dr[columnName] = pi.GetValue(tt, null) ?? DBNull.Value;
                    if (pi.PropertyType.FullName == "System.Decimal")
                    {
                        dr[columnName] = Math.Round(Convert.ToDecimal(dr[columnName]), 6);
                    }

                }
                dt.Rows.Add(dr);


            }

            return dt;
        }

        private static object ConverToType(object value, Type convertsionType)
        {
            object returnValue = "";
            try
            {
                if (convertsionType.IsGenericType && convertsionType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    if (value != null && value != DBNull.Value && value.ToString() != "" && value.ToString().Length > 0)
                    {
                        var nullableConverter = new NullableConverter(convertsionType);
                        convertsionType = nullableConverter.UnderlyingType;
                        returnValue = Convert.ChangeType(value, convertsionType);
                    }
                    else
                    {
                        returnValue = null;
                    }
                }
                else
                {
                    if (value != null && value != DBNull.Value && value.ToString() != "" && value.ToString().Length > 0)
                    {
                        if (value.ToString().IndexOf("%", System.StringComparison.Ordinal) == value.ToString().Length - 1)
                        {
                            switch (convertsionType.ToString())
                            {
                                case "System.Decimal":
                                    returnValue = Convert.ToDecimal(value.ToString().Replace("%", "")) / 100;
                                    break;

                                case "System.Double":
                                    returnValue = Convert.ToDecimal(value.ToString().Replace("%", "")) / 100;
                                    break;

                                case "System.Single":
                                    returnValue = Convert.ToDecimal(value.ToString().Replace("%", "")) / 100;
                                    break;
                            }
                        }
                        else if (value.ToString() == "-")
                        {
                            returnValue = 0;
                        }
                        else
                        {
                            returnValue = Convert.ChangeType(value, convertsionType);
                            if (convertsionType.FullName == "System.Decimal")
                                returnValue = Math.Round((decimal)returnValue, 5);
                            if (convertsionType.FullName == "System.String")
                                returnValue = returnValue.ToString().TrimEnd();
                        }
                    }
                    else
                    {
                        returnValue = GetReturnValue(convertsionType);
                    }
                }
            }
            catch
            {
                returnValue = GetReturnValue(convertsionType);
            }
            return returnValue;
        }

        private static object GetReturnValue(Type convertsionType)
        {
            object returnValue;
            switch (convertsionType.ToString())
            {
                case "System.Guid":
                    returnValue = Guid.NewGuid();
                    break;

                case "System.DateTime":
                    returnValue = DateTime.Now;
                    break;

                case "System.Decimal":
                    returnValue = 0m;
                    break;

                case "System.Double":
                    returnValue = 0.0;
                    break;

                case " System.UInt16":
                    returnValue = 0;
                    break;

                case " System.UInt32":
                    returnValue = 0;
                    break;

                case " System.UInt64":
                    returnValue = 0;
                    break;

                case "System.Int32":
                    returnValue = 0;
                    break;

                case "System.Int16":
                    returnValue = 0;
                    break;

                case "System.Int64":
                    returnValue = 0;
                    break;

                case "System.String":
                    returnValue = "";
                    break;

                case "System.Single":
                    returnValue = 0.0f;
                    break;

                default:
                    returnValue = "";
                    break;
            }
            return returnValue;
        }
    }
}