namespace Utility.Enums
{
    public enum AddRemove : byte
    {
        None,
        Add = 1,
        Remove,
        All = Add | Remove
    }
}