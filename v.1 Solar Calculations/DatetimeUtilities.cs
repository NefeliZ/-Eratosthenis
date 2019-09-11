using System;

namespace SolarCalc
{
    public class DateTimeUtilities
    {
        public static double DayFraction(DateTime dt)
        {
            // afairo apo tin torini ora tin arxi tis idias meras (0:00)
            TimeSpan ts = dt.ToUniversalTime().Subtract(new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0, DateTimeKind.Utc)); 

            double totalDayMs = 24 * 60 * 60 * 1000.0;

            double dtFraction = ts.TotalMilliseconds / totalDayMs;

            return dtFraction;
        }
    }
}
