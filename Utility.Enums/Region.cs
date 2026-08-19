namespace Utility.Enums
{
    [Flags]
    public enum Region : short
    {
        None = 0,

        TopLeft = 1 << 0,
        Top = 1 << 1,
        TopRight = 1 << 2,
        Right = 1 << 3,
        BottomRight = 1 << 4,
        Bottom = 1 << 5,
        BottomLeft = 1 << 6,
        Left = 1 << 7,
        Center = 1 << 8,

        TopRow = TopLeft | Top | TopRight,
        BottomRow = BottomLeft | Bottom | BottomRight,
        LeftColumn = TopLeft | Left | BottomLeft,
        RightColumn = TopRight | Right | BottomRight,

        Horizontal = Left | Right,
        Vertical = Top | Bottom,

        All = TopRow | BottomRow | Left | Right | Center
    }
}
