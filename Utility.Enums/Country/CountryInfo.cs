using System;
using System.Linq;

namespace Utility.Enums
{
    public static class CountryInfo
    {
        private static Type type = typeof(Country);
        private static Type typeInfo = typeof(CountryInfoAttribute);

        public static string GetName(this Country value) => GetCountryInfoAttribute(value).Name;

        public static string GetCode2(this Enum value) => GetCountryInfoAttribute(value).Code2;

        public static string GetCode3(this Enum value) => GetCountryInfoAttribute(value).Code3;

        public static string GetCurrency(this Enum value) => GetCountryInfoAttribute(value).Currency;

        public static string GetCurrencyCode(this Enum value) => GetCountryInfoAttribute(value).CurrencyCode;

        public static string GetPhoneCode(this Enum value) => GetCountryInfoAttribute(value).PhoneCode;

        private static CountryInfoAttribute GetCountryInfoAttribute(this Enum value) => (type.GetField(value.ToString()).GetCustomAttributes(typeof(CountryInfoAttribute), false) as CountryInfoAttribute[])[0];

        public static Country GetCountry(string searchField, string attribute)
        {
            Func<Country, bool> func = null;
            string lower = searchField.ToLower();
            switch (attribute)
            {
                case nameof(CountryInfoAttribute.Name):
                    func = a => a.GetName().ToLower() == lower;
                    break;

                case nameof(CountryInfoAttribute.Code2):
                    func = a => a.GetCode2().ToLower() == lower;
                    break;

                case nameof(CountryInfoAttribute.Code3):
                    func = a => a.GetCode3().ToLower() == lower;
                    break;

                case nameof(CountryInfoAttribute.Currency):
                    func = a => a.GetCurrency().ToLower() == lower;
                    break;

                case nameof(CountryInfoAttribute.CurrencyCode):
                    func = a => a.GetCurrencyCode().ToLower() == lower;
                    break;

                case nameof(CountryInfoAttribute.PhoneCode):
                    func = a => new String(a.GetPhoneCode().Where(Char.IsDigit).ToArray()) == new String(lower.Where(Char.IsDigit).ToArray());
                    break;
            }

            return Enum.GetValues(typeof(Country)).Cast<Country>().FirstOrDefault(v => func(v));
        }

        public static Country GetCountry(string searchField)
        {
            var funcs = typeInfo
                .GetProperties()
                .Where(_ => _.PropertyType == typeof(string))
                .Select(_ => _.Name)
                .Select(_ => new Func<string, Country>(a => GetCountry(a, _)))
                .ToArray();

            return Country.GetValues(typeof(Country)).Cast<Country>()
                .SelectMany(v => funcs.Select(func => func(searchField)))
                .FirstOrDefault(_ => _ != default);
        }
    }
}