using System;
using System.Collections.Generic;
using System.Text;

namespace SolarCalc
{
    public class varY
    {
        public static double CalcvarY(double ObliqCorr)
        {
            double varY = Math.Tan(Calc.rad(ObliqCorr / 2)) * Math.Tan(Calc.rad(ObliqCorr / 2));

            return varY;
        }
    }
}
