using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolarCalc;
using System;

namespace SolarCalcUT
{
    [TestClass]
    public class JulianDayUT
    {
        [TestMethod]
        public void TestJulianDay()
        {
            DateTime dt = new DateTime(2019, 6, 9, 12, 18, 0, DateTimeKind.Utc).Date;

            DateTime dt2 = new DateTime(2019, 6, 9, 12, 18, 0, DateTimeKind.Utc);

            double TimeZone = 2.0;

            string finAnswer = Calc.compare(JulianDay.CalcJulianDay(dt, dt2, TimeZone).ToString(), "2458643.92");

            Assert.AreEqual("2458643.92", finAnswer);

        }
    }



}
