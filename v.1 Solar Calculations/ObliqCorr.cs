using System;
using System.Collections.Generic;
using System.Text;

namespace SolarCalc
{
    public class ObliqCorr
    {

        public static double CalcObliqCorr (double MeanObliqEcliptic, double JulianCentury)
        {
            double ObliqCorr = MeanObliqEcliptic + 0.00256 * Math.Cos(Calc.rad(125.04 - 1934.136 * JulianCentury));

            return ObliqCorr;
        }
    }
}
