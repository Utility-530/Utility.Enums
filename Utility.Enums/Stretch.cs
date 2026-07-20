namespace Utility.Enums;

[Flags]
public enum Stretch
{
    None,
    X = 1,
    Y = 2,
    Both = X | Y,
    Uniform = 4,
    UniformToFill = 8
}


