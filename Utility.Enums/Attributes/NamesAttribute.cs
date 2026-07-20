namespace Utility.Enums.Attributes
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
