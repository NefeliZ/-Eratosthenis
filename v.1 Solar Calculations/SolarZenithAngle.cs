using System;
using System.Collections.Generic;
using System.Text;

namespace SolarCalc
{
    public class SolarZenithAngle
    {
        public static double CalcSolarZenith(double RemoteLat, double SunDeclim, double HourAngle)
        {
            double SolarZenith = Calc.degree(Math.Acos(Math.Sin(rad(RemoteLat)) *
                                Math.Sin(rad(SunDeclim)) + Math.Cos(rad(RemoteLat)) *
                                Math.Cos(rad(SunDeclim)) * Math.Cos(rad(HourAngle))));
            return SolarZenith;
        }

        public static double rad(double degree)
        {
            double rad = Math.PI * degree / 180.0;

            return rad;
        }
        

    }
}
