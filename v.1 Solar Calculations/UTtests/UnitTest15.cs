using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolarCalc;
using System;

namespace SolarCalcUT
{
    [TestClass]
    public class varYUT
    {
        [TestMethod]
        public void TestvarY()
        {
            double ObliqCorr = 23.43592489;

            string finAnswer = Calc.compare(varY.CalcvarY(ObliqCorr).ToString(), "0.04302181");

            Assert.AreEqual("0.04302181", finAnswer);

        }
    }



}
