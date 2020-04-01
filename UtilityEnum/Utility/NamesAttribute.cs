using System;
using System.Linq;


namespace UtilityEnum
{
    [AttributeUsage(AttributeTargets.Field)]
    public class NamesAttribute : Attribute
    {
        public string[] Names;

        public NamesAttribute(params string[] names)
        {
            Names = names;
        }
    }

}
