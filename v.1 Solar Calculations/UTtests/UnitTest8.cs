using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolarCalc;
using System;

namespace SolarCalcUT
{
    [TestClass]
    public class MeanObliqEclipticUT
    {
        [TestMethod]
        public void TestMeanObliqEcliptic()
        {
            double JulianCentury = 0.19435775;

            Assert.AreEqual("23.4367636480437", MeanObliqEcliptic.CalcMeanObliqEcliptic(JulianCentury).ToString());

        }
    }



}
