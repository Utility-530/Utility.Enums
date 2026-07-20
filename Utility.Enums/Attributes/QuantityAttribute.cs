namespace Utility.Enums.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public class QuantityAttribute(string symbol, params string[] validSymbols) : Attribute
    {
        public string SISymbol { get; } = symbol;
        public string[] ValidSymbols { get; } = validSymbols;
    }
}
