using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;


namespace ConsoleAppUnit.test
{
    [TestClass]
    internal class TestStudentGrades
    {
        [TestMethod]
        public void TestConvert0toGradeF()
        {
            private readonly StudentGrades converter = new StudentGrades();

        //Arrange
        Grades expectedGrade = Grades.F;

            //Act
            Grades actualGrade = converter.ConvertToGrade(0);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);

        }
    }
}
