
namespace Utility.Enums;

[Flags]
public enum Axis
{
    X, Y = 1, Z = 2, All = X | Y | Z,
}
