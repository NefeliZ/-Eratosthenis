using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolarCalc;
using System;

namespace SolarCalcUT
{
    [TestClass]
    public class ObliqCorrUT
    {
        [TestMethod]
        public void TestObliqCorr()
        {
            double MeanObliqEcliptic = 23.43676364;
            double JulianCentury = 0.19435809;


            Assert.AreEqual("23.4359249058437", ObliqCorr.CalcObliqCorr(MeanObliqEcliptic, JulianCentury).ToString());

        }
    }



}
