using System;
using System.Collections.Generic;
using System.Xml;

namespace ChangKeTec.Wms.Utils
{
    /// <summary>
    /// 实体转Xml，Xml转实体类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class XmlHelper<T> where T : new()
    {
        #region 实体类转成Xml

        /// <summary>
        /// 对象实例转成xml
        /// </summary>
        /// <param name="item">对象实例</param>
        /// <returns></returns>
        public static string EntityToXml(T item)
        {
            IList<T> items = new List<T>();
            items.Add(item);
            return EntityToXml(items);
        }

        /// <summary>
        /// 对象实例集转成xml
        /// </summary>
        /// <param name="items">对象实例集</param>
        /// <returns></returns>
        public static string EntityToXml(IList<T> items)
        {
            //创建XmlDocument文档
            XmlDocument doc = new XmlDocument();
            //创建根元素
            XmlElement root = doc.CreateElement(typeof(T).Name + "s");
            //添加根元素的子元素集
            foreach (T item in items)
            {
                EntityToXml(doc, root, item);
            }
            //向XmlDocument文档添加根元素
            doc.AppendChild(root);

            return doc.InnerXml;
        }

        private static void EntityToXml(XmlDocument doc, XmlElement root, T item)
        {
            //创建元素
            XmlElement xmlItem = doc.CreateElement(typeof(T).Name);
            //对象的属性集

            System.Reflection.PropertyInfo[] propertyInfo =
                typeof(T).GetProperties(System.Reflection.BindingFlags.Public |
                                         System.Reflection.BindingFlags.Instance);



            foreach (System.Reflection.PropertyInfo pinfo in propertyInfo)
            {
                if (pinfo != null)
                {
                    //对象属性名称
                    string name = pinfo.Name;
                    //对象属性值
                    string value = String.Empty;

                    if (pinfo.GetValue(item, null) != null)
                        value = pinfo.GetValue(item, null).ToString(); //获取对象属性值
                    //设置元素的属性值
                    xmlItem.SetAttribute(name, value);
                }
            }
            //向根添加子元素
            root.AppendChild(xmlItem);
        }


        #endregion

        #region Xml转成实体类

        /// <summary>
        /// Xml转成对象实例
        /// </summary>
        /// <param name="xml">xml</param>
        /// <returns></returns>
        public static T XmlToEntity(string xml)
        {
            IList<T> items = XmlToEntityList(xml);
            if (items != null && items.Count > 0)
                return items[0];
            else return default(T);
        }

        /// <summary>
        /// Xml转成对象实例集
        /// </summary>
        /// <param name="xml">xml</param>
        /// <returns></returns>
        public static IList<T> XmlToEntityList(string xml)
        {
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.LoadXml(xml);
            }
            catch
            {
                return null;
            }
            if (doc.ChildNodes.Count != 1)
                return null;
            if (doc.ChildNodes[0].Name.ToLower() != typeof(T).Name.ToLower() + "s")
                return null;

            XmlNode node = doc.ChildNodes[0];

            IList<T> items = new List<T>();

            foreach (XmlNode child in node.ChildNodes)
            {
                if (child.Name.ToLower() == typeof(T).Name.ToLower())
                    items.Add(XmlNodeToEntity(child));
            }

            return items;
        }

        private static T XmlNodeToEntity(XmlNode node)
        {
            T item = new T();

            if (node.NodeType == XmlNodeType.Element)
            {
                XmlElement element = (XmlElement)node;

                System.Reflection.PropertyInfo[] propertyInfo =
                    typeof(T).GetProperties(System.Reflection.BindingFlags.Public |
                                             System.Reflection.BindingFlags.Instance);

                foreach (XmlAttribute attr in element.Attributes)
                {
                    string attrName = attr.Name.ToLower();
                    string attrValue = attr.Value.ToString();
                    foreach (System.Reflection.PropertyInfo pInfo in propertyInfo)
                    {
                        if (pInfo == null) continue;
                        var name = pInfo.Name.ToLower();
                        var dbType = pInfo.PropertyType;
                        if (name != attrName) continue;
                        if (String.IsNullOrEmpty(attrValue))continue;

                        if (!pInfo.PropertyType.IsGenericType)
                        {
                            pInfo.SetValue(item, string.IsNullOrEmpty(attrValue) ? null : Convert.ChangeType(attrValue, pInfo.PropertyType,null), null);
                        }
                        else
                        {
                            //泛型Nullable<>
                            Type genericTypeDefinition = pInfo.PropertyType.GetGenericTypeDefinition();
                            if (genericTypeDefinition == typeof(Nullable<>))
                            {
                                pInfo.SetValue(item, string.IsNullOrEmpty(attrValue) ? null : Convert.ChangeType(attrValue, Nullable.GetUnderlyingType(pInfo.PropertyType),null), null);
                            }
                        }
/*原来的方法
                        if (dbType.IsGenericType && dbType.GetGenericTypeDefinition() == typeof(Nullable<>))//判断convertsionType是否为nullable泛型类
                        {
                            if (dbType.FullName.IndexOf("System.Int32", System.StringComparison.Ordinal) > 0)
                                dbType = typeof(System.Int32);
                            if (dbType.FullName.IndexOf("System.Boolean", System.StringComparison.Ordinal) > 0)
                                dbType = typeof(System.Boolean);
                            if (dbType.FullName.IndexOf("System.DateTime", System.StringComparison.Ordinal) > 0)
                                dbType = typeof(System.DateTime);
                            if (dbType.FullName.IndexOf("System.Decimal", System.StringComparison.Ordinal) > 0)
                                dbType = typeof(System.Decimal);
                            if (dbType.FullName.IndexOf("System.Double", System.StringComparison.Ordinal) > 0)
                                dbType = typeof(System.Double);
                            if (dbType.FullName.IndexOf("System.String", System.StringComparison.Ordinal) > 0)
                                dbType = typeof(System.String);
//WinCe下此段不可用
//                                    //如果type为nullable类，声明一个NullableConverter类，该类提供从Nullable类到基础基元类型的转换
//                                    System.ComponentModel.NullableConverter nullableConverter = new System.ComponentModel.NullableConverter(dbType);
//                                    //将type转换为nullable对的基础基元类型
//                                    dbType = nullableConverter.UnderlyingType;
                        }
                        switch (dbType.ToString())
                        {
                            case "System.Int32":
                                pInfo.SetValue(item, Convert.ToInt32(attrValue), null);
                                break;
                            case "System.Boolean":
                                pInfo.SetValue(item, Convert.ToBoolean(attrValue), null);
                                break;
                            case "System.DateTime":
                                pInfo.SetValue(item, Convert.ToDateTime(attrValue), null);
                                break;
                            case "System.Decimal":
                                pInfo.SetValue(item, Convert.ToDecimal(attrValue), null);
                                break;
                            case "System.Double":
                                pInfo.SetValue(item, Convert.ToDouble(attrValue), null);
                                break;
                            default:
                                pInfo.SetValue(item, attrValue, null);
                                break;
                        }*/
                    }
                }
            }
            return item;
        }

        #endregion
    }
}