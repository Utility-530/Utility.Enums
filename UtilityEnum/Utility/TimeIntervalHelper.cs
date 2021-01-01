using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace UtilityEnum.Utility
{
    class TimeIntervalHelper
    {
        public static long? GetDateDifference(TimeInterval intervalType, DateTime startDate, DateTime endDate)
        {
            return intervalType switch
            {

                _ => GetDifference(endDate - startDate)
            };

            long? GetDifference(TimeSpan ts)
            {
                switch (intervalType)
                {
                    case TimeInterval.Year:
                        return endDate.Year - startDate.Year;
                    case TimeInterval.Month:
                        return (endDate.Month - startDate.Month) + (12 * (endDate.Year - startDate.Year));
                    case TimeInterval.Day:
                        return Round(ts.TotalDays);
                    case TimeInterval.Hour:
                        return Round(ts.TotalHours);

                    case TimeInterval.Minute:
                        return Round(ts.TotalMinutes);

                    case TimeInterval.Second:
                        return Round(ts.TotalSeconds);
                    default:
                        return default;
                }

                static long Round(double dVal)
                {
                    if (dVal >= 0) return (long)System.Math.Floor(dVal);
                    return (long)System.Math.Ceiling(dVal);
                }

            }
        }

        public static long? GetDateDifference(TimeFraction timeFraction, DateTime startDate, DateTime endDate, DayOfWeek firstDayOfWeek)
        {
            return GetDifference(endDate - startDate);
    
                long? GetDifference(TimeSpan ts)
            {
                switch (timeFraction)
                {
               
                    case TimeFraction.DayOfYear:
                        return Round(ts.TotalDays);

                    case TimeFraction.DayOfWeek:
                        return Round(ts.TotalDays / 7.0);

                    case TimeFraction.WeekOfYear:
                        {
                            while (endDate.DayOfWeek != firstDayOfWeek) endDate = endDate.AddDays(-1);
                            while (startDate.DayOfWeek != firstDayOfWeek) startDate = startDate.AddDays(-1);
                            ts = endDate - startDate;
                            return Round(ts.TotalDays / 7.0);
                        }
                    case TimeFraction.QuarterOfYear:
                        {
                            var d1Quarter = GetQuarter(startDate.Month);
                            var d2Quarter = GetQuarter(endDate.Month);
                            var d1 = d2Quarter - d1Quarter;
                            var d2 = (4 * (endDate.Year - startDate.Year));
                            return Round(d1 + d2);
                        }
                    default:
                        return null;
                }

                static long Round(double dVal)
                {
                    if (dVal >= 0) return (long)System.Math.Floor(dVal);
                    return (long)System.Math.Ceiling(dVal);
                }

                static int GetQuarter(int nMonth)
                {
                    if (nMonth <= 3)
                        return 1;
                    if (nMonth <= 6)
                        return 2;
                    return nMonth <= 9 ? 3 : 4;
                }
            }
        }
    }
}
