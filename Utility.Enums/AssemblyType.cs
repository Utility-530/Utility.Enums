using System;

namespace Utility.Enums
{
    [Flags]
    public enum AssemblyType
    {
        Default = 0,
        UserControl = 1,
        ResourceDictionary = 2,
        Application = 4,
        ViewModel = 8,
        Service = 16,
        Miscellaneous = 32,
        Custom = 64,
        Control = 128
    }
}