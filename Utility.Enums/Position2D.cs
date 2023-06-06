namespace Utility.Enums
{
    /// <summary>
    /// <a href="https://en.wikipedia.org/wiki/Relative_direction"></a>
    /// relative direction
    /// </summary>
    [System.Flags]
    public enum Position2D : byte
    {
        None = 0,
        Left = 1,
        Right = 2,     
        Top = 16,
        Bottom = 32,
        All = Left | Right | Top | Bottom
    }
}