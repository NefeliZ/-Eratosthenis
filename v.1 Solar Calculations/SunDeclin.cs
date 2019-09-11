using System;
using System.Collections.Generic;
using System.Text;

namespace SolarCalc
{
    public class SunDeclin
    {
        public static double CalcSunDeclin(double ObliqCorr, double SunAppLong)
        {
            double SunDeclin = Calc.degree(Math.Asin(Math.Sin(Calc.rad(ObliqCorr)) *
                                Math.Sin(Calc.rad(SunAppLong))));

            return SunDeclin;
        }

       

    }



}

