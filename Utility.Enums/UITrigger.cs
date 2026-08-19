using System;
using System.Collections.Generic;
using System.Text;

namespace Utility.Enums;

public enum UITrigger
{
    None,

    Loaded,
    Unloaded,

    MouseEnter,
    MouseLeave,
    MouseMove,
    MouseNearby,
    MouseLeftDown,
    Click,
    DoubleClick,

    FocusGained,
    FocusLost,

    KeyDown,
    KeyUp,

    SelectionChanged,
    TextChanged,

    Checked,
    Unchecked,

    Enabled,
    Disabled,

    VisibilityChanged,

    DragStarted,
    Dragging,
    DragCompleted,

    Custom,

}
