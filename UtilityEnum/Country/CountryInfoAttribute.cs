using System;

namespace UtilityEnum
{
    public class CountryInfoAttribute : Attribute
    {
        public string Name { get; set; }
        public string Code2 { get; set; }
        public string Code3 { get; set; }
        public string Currency { get; set; }
        public string CurrencyCode { get; set; }
        public string PhoneCode { get; set; }
    }
}
