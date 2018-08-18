using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UtilityEnum
{
    [AttributeUsage(AttributeTargets.Field)]
    public class NamesAttribute : Attribute
    {
        protected List<string> _names { get; set; }

        public List<string>Names
        {
            get
            {
                return _names;
            }
            set
            {
                _names = value;
            }
        }

        public NamesAttribute()
        {
            _names = new List<string>();
        }

        public NamesAttribute(params string[] names)
        {
            _names = names.ToList();
        }
    }

}
