using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolarCalc;
using System;

namespace SolarCalcUT
{
    [TestClass]
    public class HourAngleUT
    {
        [TestMethod]
        public void TestHourAngle()
        {
            double TrueSolarTime = 722.0427834;

            Assert.AreEqual("0.510695849999991", HourAngle.CalcHourAngle(TrueSolarTime).ToString());

        }
    }
}
