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
            Assert.AreEqual(25, calculateTaxiRate(5,10));
        }

        [TestMethod]
        public void TestCalculateTaxiRate_DayTime_21km()
        {
            Assert.AreEqual(168, calculateTaxiRate(21, 10));
        }

        [TestMethod]
        public void TestCalculateTaxiRate_DayTime_65km()
        {
            Assert.AreEqual(390, calculateTaxiRate(65, 10));
        }


        [TestMethod]
        public void TestCalculateTaxiRate_NightTime_5km()
        {
            Assert.AreEqual(35, calculateTaxiRate(5, 0));
        }

        [TestMethod]
        public void TestCalculateTaxiRate_NightTime_21km()
        {
            Assert.AreEqual(210, calculateTaxiRate(21, 0));
        }

        [TestMethod]
        public void TestCalculateTaxiRate_NightTime_65km()
        {
            Assert.AreEqual(520, calculateTaxiRate(65, 0));
        }






        public double calculateTaxiRate(double distance, double hour)
        {
            double realUnitFee = 0;
            if(distance <= 20)
            {
                realUnitFee = 5;
            }

            if (distance >= 21 && distance < 60)
            {
                realUnitFee = 4*2;
            }

            if (distance > 60)
            {
                realUnitFee = 3*2;
            }

            return Math.Round((distance * realUnitFee), 2);
        }


    }
}
