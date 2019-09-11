using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolarCalc;
using System;

namespace SolarCalcUT
{
    [TestClass]
    public class JulianCenturyUT
    {
        [TestMethod]
        public void TestJulianCentury()
        {
            double JulianDay = 2458643.92;

           string finAnswer = Calc.compare(JulianCentury.CalcJulianCentury(JulianDay).ToString(), "0.19435775");

            Assert.AreEqual("0.194357837097876", finAnswer);

        }
    }



}
