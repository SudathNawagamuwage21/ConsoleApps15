using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App02;
using System;

namespace ConsoleApp2.Test
{
    [TestClass]
    public class TestBmiCaculater
    {
        [TestMethod]
        public void TestUnderWeightLow()
        {
            BMI Calculater = new BMI();

           // Calculater.Feet = 0;
            Calculater.Inches = 8;
            Calculater.Pounds = 100;
            
            Calculater.CalculaterIndex();
            double expectedIndex = 12;

            Assert.AreEqual(expectedIndex, Calculater.Index);

        }
    }
}