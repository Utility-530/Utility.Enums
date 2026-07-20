using System.Linq;
using Utility.Enums.Attributes;

namespace Utility.Enums
{
    /// <summary>
    /// Time intervals ordered from smallest to largest
    /// </summary>

    public enum TimeInterval
    {
        [TimeSpan("FromTicks", 1)] // 1 tick = 100 ns
        Tick = 0,

        [TimeSpan("FromTicks", 0.00001)] // 1 attosecond = 1e-18 s
        Attosecond = 1,

        [TimeSpan("FromTicks", 0.0001)] // 1 femtosecond = 1e-15 s
        Femtosecond = 2,

        [TimeSpan("FromTicks", 0.001)] // 1 picosecond = 1e-12 s
        Picosecond = 3,

        [TimeSpan("FromTicks", 0.01)] // 1 nanosecond = 1e-9 s
        Nanosecond = 4,

        [TimeSpan("FromMilliseconds", 0.001)] // 1 microsecond = 1e-6 s
        Microsecond = 5,

        [TimeSpan("FromMilliseconds", 1)]
        Millisecond = 6,

        [TimeSpan("FromSeconds", 1)]
        Second = 7,

        [TimeSpan("FromMinutes", 1)]
        Minute = 8,

        [TimeSpan("FromHours", 1)]
        Hour = 9,

        [TimeSpan("FromDays", 1)]
        Day = 10,

        [TimeSpan("FromDays", 7)]
        Week = 11,

        [TimeSpan("FromDays", 14)]
        Fortnight = 12,

        [TimeSpan("FromDays", 30)]
        Month = 13,

        [TimeSpan("FromDays", 91)]
        Quarter = 14,

        [TimeSpan("FromDays", 365)]
        Year = 15,

        [TimeSpan("FromDays", 3650)]
        Decade = 16,

        [TimeSpan("FromDays", 36500)]
        Century = 17,

        [TimeSpan("FromDays", 365000)]
        Millennium = 18,

        [TimeSpan("FromDays", 3650000)]
        Eon = 19,
    }

    /// <summary>
    /// Extension methods for working with time intervals
    /// </summary>
    public static class TimeIntervalExtensions
    {
        /// <summary>
        /// Returns the TimeSpan representation  of a <see cref="TimeInterval"/>
        /// </summary>
        public static TimeSpan? ToTimeSpan(this TimeInterval interval) => typeof(TimeInterval).GetCustomAttributes(false).OfType<TimeSpanAttribute>().Single().TimeSpan;

        /// <summary>
        /// Returns an approximate duration in seconds of a <see cref="TimeInterval"/>
        /// </summary>
        public static double ToSeconds(this TimeInterval interval) => interval switch
        {
            TimeInterval.Nanosecond => 0.000000001,
            TimeInterval.Microsecond => 0.000001,
            TimeInterval.Millisecond => 0.001,
            TimeInterval.Second => 1,
            TimeInterval.Minute => 60,
            TimeInterval.Hour => 3600,
            TimeInterval.Day => 86400,
            TimeInterval.Week => 604800,
            TimeInterval.Month => 2629746, // Average month (30.44 days)
            TimeInterval.Quarter => 7889238, // 3 months
            TimeInterval.Year => 31556952, // Average year (365.25 days)
            TimeInterval.Decade => 315569520,
            TimeInterval.Century => 3155695200,
            TimeInterval.Millennium => 31556952000,
            _ => throw new ArgumentOutOfRangeException(nameof(interval))
        };

        /// <summary>
        /// Returns a human-readable string representation of a <see cref="TimeInterval"/>
        /// </summary>
        public static string ToUnit(this TimeInterval interval) => interval switch
        {
            TimeInterval.Nanosecond => "ns",
            TimeInterval.Microsecond => "μs",
            TimeInterval.Millisecond => "ms",
            TimeInterval.Second => "s",
            TimeInterval.Minute => "m",
            TimeInterval.Hour => "h",
            _ => interval.ToString()
        };
    }
}
