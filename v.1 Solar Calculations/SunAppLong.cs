using System;
using System.Collections.Generic;
using System.Text;

namespace SolarCalc
{
    public class SunAppLong
    {
        public static double CalcSunAppLong (double SunTrueLong, double JulianCentury)
        {
            double SunAppLong = SunTrueLong - 0.00569 - 0.00478 *
                                Math.Sin(Calc.rad(125.04 - 1934.136 * JulianCentury));

            return SunAppLong;
        }
    }
}
