namespace UtilityEnum
{
    /// <summary>
    /// <a href="https://en.wikipedia.org/wiki/Relative_direction"></a>
    /// relative direction
    /// </summary>
    [System.Flags]
    public enum Direction : byte
    {
        None = 0,
        Left = 1,
        Right = 2,
        Forward = 4,
        Backward = 8,
        Up = 16,
        Down = 32
    }
}