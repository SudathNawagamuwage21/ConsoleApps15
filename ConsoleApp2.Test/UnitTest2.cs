using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App02;

namespace ConsoleApp2.Test
{
    [TestClass]
    public class TestBmiCaculator
    {
        [TestMethod]
        public void TestUnderWeight()
        {
            BMI Calculater = new BMI();

            Calculater.CalculaterIndex = UnitSystem.Imperial;


        }
    }
}