using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolarCalc;
using System;

namespace SolarCalcUT
{
    [TestClass]
    public class SunDeclinUT
    {
        [TestMethod]
        public void TestSunDeclin()
        {
            double ObliqCorr = 23.43592491;
            double SunAppLong = 78.31351602;

            Assert.AreEqual("22.9220662262343", SunDeclin.CalcSunDeclin(ObliqCorr,SunAppLong).ToString());

        }
    }
}
