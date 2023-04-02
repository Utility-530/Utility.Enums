namespace Utility.Enums
{
    public enum Persistence : byte
    {
        None,
        Load = 1,
        Save,
        All = Load | Save
    }
}