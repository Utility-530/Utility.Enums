using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityEnum
{
    public enum Region : byte
    {
        None,
        TopLeft = 1,
        Top,
        TopRight,
        Right,
        BottomRight,
        Bottom,
        BottomLeft,
        Left,
        Middle
    }
}
