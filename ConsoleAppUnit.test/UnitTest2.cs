using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App02;
using System;

namespace ConsoleAppUnit.test
{
    [TestClass]
    public class TestBmiCalculator
    {   
        //Imperial Testing
        [TestMethod]
        public void TestImperialUnderweight()
        {   
            //Arrange
            BMI calculator = new BMI();
            
            calculator.Pounds = 100;
            calculator.Feet = 6;
            
            //Act
            calculator.CalculateImperialBMI();

            double expectedIndex = 13.56;
            double actualIndex = calculator.Index;
                        
            actualIndex = Math.Round(actualIndex, 2);

            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [TestMethod]
        public void TestImperialNormalRange()
        {   
            //Arrange
            BMI calculator = new BMI();

            calculator.Pounds = 150;
            calculator.Inches = 72;
            
            calculator.CalculateImperialBMI();

            double expectedIndex = 20.34;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);
            
            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [TestMethod]
        public void TestImperialOverWeight()
        {   
            //Arrange
            BMI calculator = new BMI();

            calculator.Stones = 10;
            calculator.Inches = 60;

            //Act
            calculator.CalculateImperialBMI();

            double expectedIndex = 27.34;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);

            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [TestMethod]
        public void TestImperialObeseLevel1()
        {   
            //Arrange
            BMI calculator = new BMI();

            calculator.Pounds = 185;
            calculator.Inches = 65;

            //Act
            calculator.CalculateImperialBMI();

            double expectedIndex = 30.78;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);
            
            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [TestMethod]
        public void TestImperialObeseLevel2()
        {   
            //Arrange
            BMI calculator = new BMI();

            calculator.Pounds = 180;
            calculator.Feet = 5;

            //Act
            calculator.CalculateImperialBMI();

            double expectedIndex = 35.15;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);
            
            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [TestMethod]
        public void TestImperialObeseLevel3()
        {   
            //Arrange
            BMI calculator = new BMI();

            calculator.Stones = 15;
            calculator.Inches = 60;

            //Act
            calculator.CalculateImperialBMI();

            double expectedIndex = 41.01;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);
            
            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }
        
        //Metric Testing
        [TestMethod]
        public void TestMetricUnderweight()
        {
            //Arrange
            BMI calculator = new BMI();

            calculator.Kilograms = 45;
            calculator.Centimetres = 160;

            //Act
            calculator.CalculateMetricBMI();

            double expectedIndex = 17.58;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);

            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestMethod]
        public void TestMetricNormalRange()
        {
            //Arrange
            BMI calculator = new BMI();

            calculator.Kilograms = 61;
            calculator.Centimetres = 157;

            //Act
            calculator.CalculateMetricBMI();

            double expectedIndex = 24.75;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);

            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestMethod]
        public void TestMetricOverWeight()
        {
            //Arrange
            BMI calculator = new BMI();

            calculator.Kilograms = 77;
            calculator.Centimetres = 162;

            //Act
            calculator.CalculateMetricBMI();

            double expectedIndex = 29.34;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);

            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [TestMethod]
        public void TestMetricObeseLevel1()
        {
            //Arrange
            BMI calculator = new BMI();

            calculator.Kilograms = 80;
            calculator.Centimetres = 155;

            //Act
            calculator.CalculateMetricBMI();

            double expectedIndex = 33.30;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);

            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [TestMethod]
        public void TestMetricObeseLevel2()
        {
            //Arrange
            BMI calculator = new BMI();

            calculator.Kilograms = 92;
            calculator.Centimetres = 161;

            //Act
            calculator.CalculateMetricBMI();

            double expectedIndex = 35.49;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);

            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [TestMethod]
        public void TestMetricObeseLevel3()
        {
            //Arrange
            BMI calculator = new BMI();

            calculator.Kilograms = 120;
            calculator.Centimetres = 162;

            //Act
            calculator.CalculateMetricBMI();

            double expectedIndex = 45.72;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);

            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }

    }
}
