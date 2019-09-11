using System;

namespace SolarCalc
{
    public class Distance
    {
        public static double EARTH_RADIUS = 6371;

        public static double CalculateDistance (double x1, double y1, double x2, double y2)
        {
            double dist = Math.Acos(
                                Math.Cos(Calc.rad(90 - x1)) * Math.Cos(Calc.rad(90 - x2)) + 
                                Math.Sin(Calc.rad(90 - x1)) * Math.Sin(Calc.rad(90 - x2)) * Math.Cos(Calc.rad(y1 - y2))) * EARTH_RADIUS;
            return dist;

        }

    }
}
