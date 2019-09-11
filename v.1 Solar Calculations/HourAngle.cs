using System;
using System.Collections.Generic;
using System.Text;

namespace SolarCalc
{
    public class HourAngle
    {
        public static double CalcHourAngle (double TrueSolarTime)
        {
            double HourAngle;

            if (TrueSolarTime/4 < 0)
            {
               HourAngle = TrueSolarTime / 4 + 180;
            }
            else
            {
               HourAngle = TrueSolarTime / 4 - 180;
            }

            return HourAngle;
        }

    
    }
}
