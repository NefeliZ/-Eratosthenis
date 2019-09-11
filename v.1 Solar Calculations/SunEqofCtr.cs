using System;
using System.Collections.Generic;
using System.Text;

namespace SolarCalc
{
    public class SunEqofCtr
    {
        public static double CalcSunEqofCtr(double GeomMeanAnomSun, double JulianCentury)
        {
            double SunEqofCtr = Math.Sin(Calc.rad(GeomMeanAnomSun)) * (1.914602 - JulianCentury 
                                * (0.004817 + 0.000014 * JulianCentury)) + Math.Sin(Calc.rad(2 * GeomMeanAnomSun))
                                * (0.019993 - 0.000101 * JulianCentury) + Math.Sin(Calc.rad(3 + GeomMeanAnomSun)) * 0.000289;

            return SunEqofCtr;
        }
    }
}
