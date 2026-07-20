
namespace Utility.Enums
{
    public enum ValueType
    {
        [Type(typeof(int))]
        Int,

        [Type(typeof(float))]
        Float,

        [Type(typeof(double))]
        Double,

        [Type(typeof(decimal))]
        Decimal,

        [Type(typeof(bool))]
        Bool,

        [Type(typeof(char))]
        Char,

        [Type(typeof(byte))]
        Byte,

        [Type(typeof(sbyte))]
        SByte,

        [Type(typeof(short))]
        Short,

        [Type(typeof(long))]
        Long,

        [Type(typeof(uint))]
        UInt,

        [Type(typeof(ushort))]
        UShort,

        [Type(typeof(ulong))]
        ULong
    }


    public static class ValueTypeConverter
    {
        private static readonly Dictionary<ValueType, Type> EnumToTypeMap = new();
        private static readonly Dictionary<Type, ValueType> TypeToEnumMap = new();

        static ValueTypeConverter()
        {
            foreach (ValueType typeEnum in Enum.GetValues(typeof(ValueType)))
            {
                var field = typeof(RuntimeType).GetField(typeEnum.ToString());
                var attribute = (TypeAttribute)Attribute.GetCustomAttribute(field, typeof(TypeAttribute));
                if (attribute != null)
                {
                    EnumToTypeMap[typeEnum] = attribute.Type;
                    TypeToEnumMap[attribute.Type] = typeEnum;
                }
            }
        }

        public static Type FromEnum(ValueType typeEnum) => EnumToTypeMap[typeEnum];

        public static ValueType FromType(Type type)
        {
            if (TypeToEnumMap.TryGetValue(type, out var typeEnum))
            {
                return typeEnum;
            }

            throw new ArgumentException($"Type '{type.Name}' is not supported.");
        }
    }
}
