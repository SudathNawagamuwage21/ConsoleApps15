using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01; 

namespace ConsoleApp.Test
{
    [TestClass]
    public class TestDistanceConverter
    {
        [TestMethod]
        public void TestMileToFeet()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Feet;
            converter.ToUnit = DistanceUnits.Miles;
            converter.FromDistance = 1.0;
            converter.ConvertDistance();

            double expectedDistance = 5280;

            Assert.AreEqual(expectedDistance, converter.FromDistance);

        }
    }
}