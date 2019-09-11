using System;
using System.Collections.Generic;
using System.Text;

namespace SolarCalc
{
    public class JulianDay
    {
        public static double CalcJulianDay (DateTime Date, DateTime Time, double TimeZone)
        {
            double dayFraction = DateTimeUtilities.DayFraction(Time);
            double dayFraction2 = DateTimeUtilities.DayFraction(Date);


            double JulianDay = dayFraction2 + 2415018.5 + dayFraction - TimeZone / 24;

            return JulianDay;
        }
    }
}
