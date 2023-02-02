namespace Utility.Enums
{
    /// <summary>
    /// <see href="https://en.wikipedia.org/wiki/Process_state"/>
    /// </summary>
    public enum ProcessState : byte
    {
        None,
        Created = 1,
        Ready,
        Running,
        Blocked,
        Terminated,
    }
}