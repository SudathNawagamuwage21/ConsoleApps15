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
        public void TestImperialUnderweightLow()
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
        //Imperial Testing
        [TestMethod]
        public void TestImperialUnderweightMax()
        {
            //Arrange
            BMI calculator = new BMI();

            calculator.Pounds = 135;
            calculator.Feet = 6;

            //Act
            calculator.CalculateImperialBMI();

            double expectedIndex = 18.31;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);

            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [TestMethod]
        public void TestImperialNormalRangeLow()
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
        public void TestImperialNormalRangeMax()
        {
            //Arrange
            BMI calculator = new BMI();

            calculator.Pounds = 175;
            calculator.Inches = 72;

            calculator.CalculateImperialBMI();

            double expectedIndex = 23.73;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);

            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [TestMethod]
        public void TestImperialOverWeightLow()
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
        public void TestImperialOverWeightMax()
        {
            //Arrange
            BMI calculator = new BMI();

            calculator.Stones = 9;
            calculator.Inches = 55;

            //Act
            calculator.CalculateImperialBMI();

            double expectedIndex = 29.28;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);

            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [TestMethod]
        public void TestImperialObeseLevel1Low()
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
        public void TestImperialObeseLevel1Max()
        {
            //Arrange
            BMI calculator = new BMI();

            calculator.Pounds = 190;
            calculator.Inches = 65;

            //Act
            calculator.CalculateImperialBMI();

            double expectedIndex = 31.61;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);

            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [TestMethod]
        public void TestImperialObeseLevel2Low()
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
        public void TestImperialObeseLevel2Max()
        {
            //Arrange
            BMI calculator = new BMI();

            calculator.Pounds = 198;
            calculator.Feet = 5;

            //Act
            calculator.CalculateImperialBMI();

            double expectedIndex = 38.67;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);

            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [TestMethod]
        public void TestImperialObeseLevel3Low()
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
        public void TestImperialObeseLevel3Max()
        {
            //Arrange
            BMI calculator = new BMI();

            calculator.Stones = 20;
            calculator.Inches = 60;

            //Act
            calculator.CalculateImperialBMI();

            double expectedIndex = 54.68;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);

            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        //Metric Testing
        [TestMethod]
        public void TestMetricUnderweightLow()
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
        public void TestMetricUnderweightMax()
        {
            //Arrange
            BMI calculator = new BMI();

            calculator.Kilograms = 68;
            calculator.Centimetres = 193;

            //Act
            calculator.CalculateMetricBMI();

            double expectedIndex = 18.26;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);

            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestMethod]
        public void TestMetricNormalRangeLow()
        {
            //Arrange
            BMI calculator = new BMI();

            calculator.Kilograms = 60;
            calculator.Centimetres = 175;

            //Act
            calculator.CalculateMetricBMI();

            double expectedIndex = 19.59;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);

            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [TestMethod]
        public void TestMetricNormalRangeMax()
        {
            //Arrange
            BMI calculator = new BMI();

            calculator.Kilograms = 90;
            calculator.Centimetres = 193;

            //Act
            calculator.CalculateMetricBMI();

            double expectedIndex = 24.16;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);

            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestMethod]
        public void TestMetricOverWeightlow()
        {
            //Arrange
            BMI calculator = new BMI();

            calculator.Kilograms = 75;
            calculator.Centimetres = 172;

            //Act
            calculator.CalculateMetricBMI();

            double expectedIndex = 25.35;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);

            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [TestMethod]
        public void TestMetricOverWeightMax()
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
        public void TestMetricObeseLevel1Low()
        {
            //Arrange
            BMI calculator = new BMI();

            calculator.Kilograms = 80;
            calculator.Centimetres = 160;

            //Act
            calculator.CalculateMetricBMI();

            double expectedIndex = 31.25;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);

            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [TestMethod]
        public void TestMetricObeseLevel1Max()
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
        public void TestMetricObeseLevel2Low()
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
        public void TestMetricObeseLevel2Max()
        {
            //Arrange
            BMI calculator = new BMI();

            calculator.Kilograms = 95;
            calculator.Centimetres = 158;

            //Act
            calculator.CalculateMetricBMI();

            double expectedIndex = 38.05;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);

            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [TestMethod]
        public void TestMetricObeseLevel3Low()
        {
            //Arrange
            BMI calculator = new BMI();

            calculator.Kilograms = 97;
            calculator.Centimetres = 154;

            //Act
            calculator.CalculateMetricBMI();

            double expectedIndex = 40.90;
            double actualIndex = calculator.Index;

            actualIndex = Math.Round(actualIndex, 2);

            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [TestMethod]
        public void TestMetricObeseLevel3Max()
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
