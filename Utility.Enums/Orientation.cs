namespace Utility.Enums
{
    [Flags]
    public enum Orientation : byte
    {
        None,
        Horizontal = 1,
        Vertical = 2,

        Both = Horizontal | Vertical,
    }
}
