using System;
using System.Collections.Generic;
using System.Text;

namespace SolarCalc
{
    public class MeanObliqEcliptic
    {

        public static double CalcMeanObliqEcliptic (double JulianCentury)
        {
            double MeanObliqEcliptic = 23 + (26 + ((21.448 - JulianCentury * (46.815 + JulianCentury 
                                        * (0.00059 - JulianCentury * 0.001813)))) / 60) / 60;

            return MeanObliqEcliptic; 

        }
    }
}
