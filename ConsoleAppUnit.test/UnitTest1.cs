using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;

namespace ConsoleAppUnit.Test
{
    [TestClass]
    public class TestDistanceConverter
    {
        [TestMethod]
        public void TestMileToFeet()
        {
            //Arrange
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Miles;
            converter.ToUnit = DistanceUnits.Feet;

            converter.FromDistance = 1.0;

            //Act
            converter.CalculateDistance();
            double expectedDistance = 5280;

            //Assert
            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }
        [TestMethod]
        public void TestFeetToMiles()
        {
            //Arrange
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Feet;
            converter.ToUnit = DistanceUnits.Miles;

            converter.FromDistance = 5280;

            //Act
            converter.CalculateDistance();
            double expectedDistance = 1;

            //Assert
            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }
        [TestMethod]
        public void TestMilesToMetres()
        {
            //Arrange
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Miles;
            converter.ToUnit = DistanceUnits.Metres;

            converter.FromDistance = 1;

            //Act
            converter.CalculateDistance();
            double expectedDistance = 1609.34;

            //Assert
            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }
        [TestMethod]
        public void TestMetresToMiles()
        {
            //Arrange
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Metres;
            converter.ToUnit = DistanceUnits.Miles;

            converter.FromDistance = 1609.34;

            //Act
            converter.CalculateDistance();
            double expectedDistance = 1;

            //Assert
            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }
        [TestMethod]
        public void TestMetresToFeet()
        {
            //Arrange
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Metres;
            converter.ToUnit = DistanceUnits.Feet;

            converter.FromDistance = 1;

            //Act
            converter.CalculateDistance();
            double expectedDistance = 3.28084;

            //Assert
            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }
        [TestMethod]
        public void TestFeetToMetres()
        {
            //Arrange
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Feet;
            converter.ToUnit = DistanceUnits.Metres;

            converter.FromDistance = 3.28084;

            //Act
            converter.CalculateDistance();
            double expectedDistance = 1;

            //Assert
            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }
    }
}