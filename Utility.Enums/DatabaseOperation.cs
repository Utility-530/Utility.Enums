namespace Utility.Enums
{
    public enum DatabaseOperation : byte
    {
        None,
        Add = 1,
        Remove,
        Update,
        Insert,
        Delete,
        Replace,
        Upsert
    }
}