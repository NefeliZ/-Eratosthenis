using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolarCalc;
using System;

namespace SolarCalcUT
{
    [TestClass]
    public class TrueSolarTimeUT
    {
        [TestMethod]
        public void TestTrueSolarTime()
        {
            //DateTime Time = "12:18";
            double Eq = 0.802783445;
            double RemoteLan = 25.81;
            double TimeZone = 2;

            DateTime dt = new DateTime(2019, 6, 9, 12, 18, 0, DateTimeKind.Utc);

            //TimeSpan ts = dt.ToUniversalTime().Subtract(new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0, DateTimeKind.Utc));

            //double totalDayMs = 24 * 60 * 60 * 1000.0;

            //double dtFraction = ts.TotalMilliseconds / totalDayMs;


            Assert.AreEqual("722.042783445", TrueSolarTime.CalcTrueSolarTime(dt, Eq, RemoteLan, TimeZone).ToString());

        }
    }



}
