using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolarCalc;
using System;

namespace SolarCalcUT
{
    [TestClass]
    public class EqofTimeUT
    {
        [TestMethod]
        public void TestEqofTime()
        {
            double varY = 0.043021818;
            double GeomMeanLongSun = 77.49494398;
            double GeomMeanAnomSun = 7354.223371;
            double EccentEarthOrbit = 0.016700459;

           string finAnswer = Calc.compare(EqofTime.CalcEqofTime(varY, GeomMeanLongSun, GeomMeanAnomSun, EccentEarthOrbit).ToString(), "0.8052194815");

            Assert.AreEqual("0.8052194815", finAnswer);

        }
    }



}
