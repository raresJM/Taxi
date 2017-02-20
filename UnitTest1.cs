using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TarifTaxi
{
    [TestClass]
    public class TarifTaxi
    {
        [TestMethod]
        public void TestCalculateTaxiRate_DayTime_5km()
        {
            Assert.AreEqual(2, calculateTaxiRate(5,10);
        }
        [TestMethod]
        public void TestCalculateTaxiRate_DayTime_21km()
        {
            Assert.AreEqual(168, calculateTaxiRate(21, 10);
        }


    }
}
