using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolarCalc;
using System;

namespace SolarCalcUT
{
    [TestClass]
    public class GeomMeanLongSunUT
    {
        [TestMethod]
        public void TestGeomMeanLongSun()
        {
            double JulianCentury = 0.19435775;

            string finAnswer = Calc.compare(GeomMeanLongSun.CalcGeomMeanLongSun(JulianCentury).ToString(), "77.49494398");

            Assert.AreEqual("77.4950938800412", finAnswer);

        }
    }



}
