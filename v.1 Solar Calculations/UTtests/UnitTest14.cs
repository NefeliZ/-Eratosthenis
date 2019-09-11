using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolarCalc;
using System;

namespace SolarCalcUT
{
    [TestClass]
    public class SunEqofCtrUT
    {
        [TestMethod]
        public void TestSunEqofCtr()
        {
            double JulianCentury = 0.19435775;
            double GeomMeanAnomSun = 7354.223371;

            string finAnswer = Calc.compare(SunEqofCtr.CalcSunEqofCtr(GeomMeanAnomSun, JulianCentury).ToString(), "0.816652795653");

            Assert.AreEqual("0.816652795653", finAnswer);

        }
    }



}
