namespace Utility.Enums
{
    [Flags]
    public enum Step
    {
        None,
        Backward = 1,
        Forward = 2,
        In = 4,
        Out = 8,
        Over = 16,
        All = Backward | Forward | In | Out
    }
}
