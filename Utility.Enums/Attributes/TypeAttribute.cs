namespace Utility.Enums
{
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    public class TypeAttribute : Attribute
    {
        public TypeAttribute(Type type)
        {
            Type = type;
        }

        public Type Type { get; }
    }
}
