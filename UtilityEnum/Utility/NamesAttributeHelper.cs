

using System;
using System.Collections.Generic;
using System.Linq;

namespace UtilityEnum
{
    public static class NamesAttributeHelper
    {
        public static T GetMatch<T>(string name, StringComparison stringcomparison = StringComparison.InvariantCultureIgnoreCase) where T : struct, IConvertible/*where T : System.Enum*/
        {

            foreach (var field in typeof(T).GetFields())
            {
                NamesAttribute attribute = Attribute.GetCustomAttribute(field, typeof(NamesAttribute)) as NamesAttribute;

                if (attribute != null && attribute.Names.Concat(new[] { field.Name }).Contains(name, stringcomparison))
                {
                    return (T)field.GetValue(null);
                }
            }
            throw new ArgumentException($"{name} not found in {typeof(T).Name}.", "name");
        }

    }




    static class StringExtension
    {
        public static bool Contains(this IEnumerable<string> source, string keyword, StringComparison comp = StringComparison.InvariantCultureIgnoreCase)
        {
            return source.Any(s => s.Equals(keyword, comp));
        }
    }
}
