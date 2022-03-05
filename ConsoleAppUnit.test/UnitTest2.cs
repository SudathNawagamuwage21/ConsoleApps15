using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App02;
using System;

namespace ConsoleAppUnit.test
{
    [TestClass]
    public class TestBmiCalculator
    {
        [TestMethod]
        public void TestMetricUnderweight()
        {
            BMI calculator = new BMI();
            calculator.Kilograms = 45.5;
            calculator.Centimetres = 193;
            calculator.CalculateMetricBMI();

            double expectedIndex = 12;

            Assert.AreEqual(expectedIndex, calculator.Index);
        }
        [TestMethod]
        public void TestImeriallUnderweight()
        {
            BMI calculator = new BMI();
            calculator.Pounds = 145;
            calculator.Inches = 72;
            calculator.CalculateImperialBMI();

            double expectedIndex = 12;

            Assert.AreEqual(expectedIndex, calculator.Index);
        }
    }
}
