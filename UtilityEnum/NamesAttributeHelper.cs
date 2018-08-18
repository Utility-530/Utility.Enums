using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace UtilityEnum
{
    public static class NamesAttributeHelper
    {
        public static T GetMatch<T>(string name, StringComparison stringcomparison=StringComparison.InvariantCultureIgnoreCase)  where T : struct, IConvertible/*where T : System.Enum*/
        {
            var type = typeof(T);
     
            foreach (var field in type.GetFields())
            {
                var atts = Attribute.GetCustomAttributes(field, false);

                var attribute = Attribute.GetCustomAttribute(field,
                    typeof(NamesAttribute)) as NamesAttribute;

                if (attribute != null)
                {

                    if (attribute.Names.Contains(name, stringcomparison))
                        return (T)field.GetValue(null);
                 }
                //else
                //    throw new  Exception("Attribute 'Names' is not part of enum field");
                //{
                //    if (attribute.Description.Equals(field.Name, stringcomparison))
                //        return (T)field.GetValue(null);
                //}
            }
            throw new ArgumentException("Not found.", "names");
     
        }

            public static TAttribute GetAttribute<TAttribute>(this Enum value)   where TAttribute : Attribute
    {
        var enumType = value.GetType();
        var name = Enum.GetName(enumType, value);
        return enumType.GetField(name).GetCustomAttributes(false).OfType<TAttribute>().SingleOrDefault();
    }

        //public static string Get(Type tp, string name)
        //{
        //    MemberInfo[] mi = tp.GetMember(name);
        //    if (mi != null && mi.Length > 0)
        //    {
        //        ExtensionTest attr = Attribute.GetCustomAttribute(mi[0],
        //            typeof(ExtensionTest)) as ExtensionTest;
        //        if (attr != null)
        //        {
        //            return attr.m_name;
        //        }
        //    }
        //    return null;
        //}
        //public static string Get(object enm)
        //{
        //    if (enm != null)
        //    {
        //        MemberInfo[] mi = enm.GetType().GetMember(enm.ToString());
        //        if (mi != null && mi.Length > 0)
        //        {
        //            ExtensionTest attr = Attribute.GetCustomAttribute(mi[0],
        //                typeof(ExtensionTest)) as ExtensionTest;
        //            if (attr != null)
        //            {
        //                return attr.m_name;
        //            }
        //        }
        //    }
        //    return null;
        //}
    }




    public static class StringExtension
    {
        public static bool Contains(this IEnumerable<string> source, string keyword, StringComparison comp=StringComparison.InvariantCultureIgnoreCase)
        {
            return source.Any(s => s.Equals(keyword, StringComparison.OrdinalIgnoreCase));
        }
    }
}
