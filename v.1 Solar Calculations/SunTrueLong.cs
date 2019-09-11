using System;
using System.Collections.Generic;
using System.Text;

namespace SolarCalc
{
    public class SunTrueLong
    {
        public static double CalcSunTrueLong (double GeomMeanLongSun, double SunEqofCtr)
        {
            double SunTrueLong = GeomMeanLongSun + SunEqofCtr;

            return SunTrueLong;
        }

    }
}
