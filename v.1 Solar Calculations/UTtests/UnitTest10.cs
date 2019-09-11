using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolarCalc;
using System;

namespace SolarCalcUT
{
    [TestClass]
    public class SunTrueLongUT
    {
        [TestMethod]
        public void TestSunTrueLong()
        {
            double GeomMeanLongSun = 77.49494398;
            double SunEqofCtr = 0.816822881;


            string finAnswer = Calc.compare(SunTrueLong.CalcSunTrueLong(GeomMeanLongSun,SunEqofCtr).ToString(), "78.31176686");

            Assert.AreEqual("78.31176686", finAnswer);

        }
    }



}
