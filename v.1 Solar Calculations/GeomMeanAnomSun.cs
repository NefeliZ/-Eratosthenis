using System;
using System.Collections.Generic;
using System.Text;

namespace SolarCalc
{
    public class GeomMeanAnomSun
    {
        public static double CalcGeomMeanAnomSun(double JulianCentury)
        {
            double GeomMeanAnomSun = 357.52911 + JulianCentury * (35999.05029 - 0.0001537 * JulianCentury);

            return GeomMeanAnomSun;
        }
    }
}
