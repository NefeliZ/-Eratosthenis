using System;
using System.Collections.Generic;
using System.Text;

namespace SolarCalc
{
    public class TrueSolarTime
    {
        public static double CalcTrueSolarTime(DateTime Time, double Eq, double RemoteLan, double TimeZone)
        {
            double dayFraction = DateTimeUtilities.DayFraction(Time);

            double TrueSolarTime = (dayFraction * 1440 + Eq + 4 * RemoteLan - 60 * TimeZone) % 1440;

            return TrueSolarTime;
        }


    }
}
