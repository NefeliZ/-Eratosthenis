using System;
using System.Collections.Generic;
using System.Text;

namespace SolarCalc
{
    public class GeomMeanLongSun
    {
        public static double CalcGeomMeanLongSun (double JulianCentury)
        {
            double GeomMeanLongSun = (280.46646 + JulianCentury * (36000.76983 + JulianCentury * 0.0003032)) % 360;

            return GeomMeanLongSun;
        }
    }
}
