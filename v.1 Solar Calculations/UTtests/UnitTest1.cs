using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolarCalc;
using System;

namespace SolarCalcUT
{
    [TestClass]
    public class DistanceUT
    {
        [TestMethod]
        public void TestDistanceSameLon()
        {
            double x2 = 40.86;
            double y2 = 25.81;
            double x1 = 30;
            double y1 = 25.81;

            Assert.AreEqual("1207.57690335991", Distance.CalculateDistance(x1, y1, x2, y2).ToString());

        }


        [TestMethod]
        public void TestRad()
        {
            Assert.AreEqual(0.0, Calc.rad(0));
            Assert.AreEqual("1.5707963267949", Calc.rad(90.0).ToString());
            Assert.AreEqual("4.71238898038469", Calc.rad(270.0).ToString());
            Assert.AreEqual(Math.PI, Calc.rad(180.0));
        }
    }



}
