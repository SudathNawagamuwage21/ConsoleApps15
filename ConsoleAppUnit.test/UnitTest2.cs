using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App02;
using System;

namespace ConsoleAppUnit.test
{
    [TestClass]
    public class TestBmiCalculator
    {
        [TestMethod]
        public void TestImperialUnderweight()
        {
            BMI calculator = new BMI();
            calculator.Pounds = 100;
            calculator.Feet = 6;
            
            calculator.CalculateImperialBMI();

            double expectedIndex = 13.56;
            double actualIndex = calculator.Index;  

            actualIndex = Math.Round(actualIndex, 2);

           Assert.AreEqual(expectedIndex, actualIndex);
        }
        [TestMethod]
        public void TestImperialNormalRange()
        {
            BMI calculator = new BMI();
            calculator.Pounds = 150;
            calculator.Inches = 72;
            
            calculator.CalculateImperialBMI();

            double expectedIndex = 20.34;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);

            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [TestMethod]
        public void TestImperialOverWeight()
        {
            BMI calculator = new BMI();
            calculator.Stones = 10;
            calculator.Inches = 60;

            calculator.CalculateImperialBMI();

            double expectedIndex = 27.34;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);

            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [TestMethod]
        public void TestImperialObeseLevel1()
        {
            BMI calculator = new BMI();
            calculator.Pounds = 185;
            calculator.Inches = 65;

            calculator.CalculateImperialBMI();

            double expectedIndex = 30.78;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);

            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [TestMethod]
        public void TestImperialObeseLevel2()
        {
            BMI calculator = new BMI();
            calculator.Pounds = 180;
            calculator.Feet = 5;

            calculator.CalculateImperialBMI();

            double expectedIndex = 35.15;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);

            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [TestMethod]
        public void TestImperialObeseLevel3()
        {
            BMI calculator = new BMI();
            calculator.Stones = 180;
            calculator.Inches = 60;

            calculator.CalculateImperialBMI();

            double expectedIndex = 35.15;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);

            Assert.AreEqual(expectedIndex, actualIndex);
        }
    }
}
