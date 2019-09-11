using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolarCalc;
using System;

namespace SolarCalcUT
{
    [TestClass]
    public class SolarZenithUT
    {
        [TestMethod]
        public void TestSolarZenith()
        {
            double RemoteLat = 30;
            double SunDeclim = 22.92206623;
            double HourAngle = 0.510695861;

            Assert.AreEqual("7.09265175811662", SolarZenithAngle.CalcSolarZenith(RemoteLat, SunDeclim, HourAngle).ToString());

        }
    }
}
