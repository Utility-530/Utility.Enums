namespace Utility.Enums
{
    public enum RuntimeType
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
        ULong,

        [Type(typeof(string))]  
        String,

        [Type(typeof(object))]  
        Object,
    }

    // Conversion methods
    public static class RuntimeTypeConverter
    {
        private static readonly Dictionary<RuntimeType, Type> EnumToTypeMap = new();
        private static readonly Dictionary<Type, RuntimeType> TypeToEnumMap = new();

        static RuntimeTypeConverter()
        {
            foreach (RuntimeType typeEnum in Enum.GetValues(typeof(RuntimeType)))
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

        public static Type FromEnum(RuntimeType typeEnum) => EnumToTypeMap[typeEnum];

        public static RuntimeType FromType(Type type)
        {
            if (TypeToEnumMap.TryGetValue(type, out var typeEnum))
            {
                return typeEnum;
            }

            throw new ArgumentException($"Type '{type.Name}' is not supported.");
        }
    }
}
