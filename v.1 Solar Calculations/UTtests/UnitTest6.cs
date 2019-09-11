using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolarCalc;
using System;

namespace SolarCalcUT
{
    [TestClass]
    public class SunAppLongUT
    {
        [TestMethod]
        public void TestSunAppLong()
        {
            double SunTrueLong = 78.32372219;
            double JulianCentury = 0.19435809;


            Assert.AreEqual("78.3135160176784", SunAppLong.CalcSunAppLong(SunTrueLong, JulianCentury).ToString());

        }
    }



}
