using System;
using System.Collections.Generic;
using System.Text;

namespace SolarCalc
{
    public class JulianCentury
    {
        public static double CalcJulianCentury (double JulianDay)
        {
            double JulianCentury = (JulianDay - 2451545) / 36525;

            return JulianCentury;
        }


    }
}
