using System;
using System.Collections.Generic;
using System.Text;

namespace SolarCalc
{
    public class EqofTime
    {
        public static double CalcEqofTime (double varY, double GeomMeanLongSun, double GeomMeanAnomSun, double EccentEarthOrbit)
        {
            double EqofTime = 4 * Calc.degree(varY * Math.Sin(2 * Calc.rad(GeomMeanLongSun)) - 2 * EccentEarthOrbit 
                            * Math.Sin(Calc.rad(GeomMeanAnomSun)) + 4 * EccentEarthOrbit * varY * Math.Sin(Calc.rad(GeomMeanAnomSun)) 
                            * Math.Cos(2 * Calc.rad(GeomMeanLongSun)) - 0.5 * varY * varY * Math.Sin(4 * Calc.rad(GeomMeanLongSun)) - 1.25 
                             * EccentEarthOrbit * EccentEarthOrbit * Math.Sin(2 * Calc.rad(GeomMeanAnomSun)));


            return EqofTime;
        }
    }
}
