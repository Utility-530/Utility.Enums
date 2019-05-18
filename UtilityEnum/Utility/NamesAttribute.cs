using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
