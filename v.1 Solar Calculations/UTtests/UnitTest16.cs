using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolarCalc;
using System;

namespace SolarCalcUT
{
    [TestClass]
    public class GeomMeanAnomSunUT
    {
        [TestMethod]
        public void TestGeomMeanAnomSun()
        {
            double JulianCentury = 0.19435775;

            string finAnswer = Calc.compare(GeomMeanAnomSun.CalcGeomMeanAnomSun(JulianCentury).ToString(), "7354.2235206");

            Assert.AreEqual("7354.2235206", finAnswer);

        }
    }



}
