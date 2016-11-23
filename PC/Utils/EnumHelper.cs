using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms.VisualStyles;
using Microsoft.Office.Interop.Excel;

namespace ChangKeTec.Wms.Utils
{
    public class EnumItem
    {
        public EnumItem(string name, string desc, int value)
        {
            Name = name;
            Desc = desc;
            Value = value;
        }

        public EnumItem()
        {
           
        }


        public string Name { get; set; }
        public string Desc { get; set; }
        public int Value { get; set; }

    }

    public static class EnumHelper
    {
        public static List<EnumItem> EnumToList<T>()
        {
            List<EnumItem> list = new List<EnumItem>();
            var type = typeof(T);
            foreach (var name in Enum.GetNames(type))
            {
                var text = GetText<T>(type, name);
                int value = (int) Enum.Parse(type, name);
                list.Add(new EnumItem (name,text,value));
            }
            return list;
        }


        public static Dictionary<string,int> EnumToDict<T>()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            var type = typeof (T);
            foreach (var name in Enum.GetNames(type))
            {
                var text = GetText<T>(type, name);
                dictionary.Add(text, (int) Enum.Parse(type, name));
            }
            return dictionary;
        }

        private static string GetText<T>(Type type, string name)
        {
            var fieldInfo = type.GetField(name);
            var text = name;
            if (fieldInfo != null)
            {
                // 获取描述的属性。
                DescriptionAttribute attr = Attribute.GetCustomAttribute(fieldInfo,
                    typeof (DescriptionAttribute), false) as DescriptionAttribute;
                if (attr != null)
                {
                    text = attr.Description;
                }
            }
            return text;
        }


        public static string GetDescription(Enum value)
        {
            Type enumType = value.GetType();
            // 获取枚举常数名称。
            string name = Enum.GetName(enumType, value);
            if (name != null)
            {
                // 获取枚举字段。
                FieldInfo fieldInfo = enumType.GetField(name);
                if (fieldInfo != null)
                {
                    // 获取描述的属性。
                    DescriptionAttribute attr = Attribute.GetCustomAttribute(fieldInfo,
                        typeof(DescriptionAttribute), false) as DescriptionAttribute;
                    if (attr != null)
                    {
                        return attr.Description;
                    }
                }
            }
            return null;
        }

    }

}