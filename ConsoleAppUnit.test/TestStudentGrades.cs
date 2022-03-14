using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;


namespace ConsoleAppUnit.test
{
    [TestClass]
    public class TestStudentGrades
    { 
        private readonly StudentGrades converter = new StudentGrades();
        private int[] testMarks;

        public TestStudentGrades()
        {
            testMarks = new int[]
            {
                10, 20, 30, 40, 50, 60, 70, 80, 90, 100
            };
        }

        [TestMethod]
        public void TestConvert0toGradeF()
        {
             //Arrange
             Grades expectedGrade = Grades.F;
             
             //Act
             Grades actualGrade = converter.ConvertToGrade(0);
             
            //Assert
             Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert39toGradeF()
        {
            //Arrange
            Grades expectedGrade = Grades.F;

            //Act
            Grades actualGrade = converter.ConvertToGrade(39);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }
        [TestMethod]
        public void TestConvert40toGradeD()
        {
            //Arrange
            Grades expectedGrade = Grades.D;

            //Act
            Grades actualGrade = converter.ConvertToGrade(40);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert49toGradeD()
        {
            //Arrange
            Grades expectedGrade = Grades.D;

            //Act
            Grades actualGrade = converter.ConvertToGrade(49);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert50toGradeC()
        {
            //Arrange
            Grades expectedGrade = Grades.C;

            //Act
            Grades actualGrade = converter.ConvertToGrade(50);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert59toGradeC()
        {
            //Arrange
            Grades expectedGrade = Grades.C;

            //Act
            Grades actualGrade = converter.ConvertToGrade(59);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert60toGradeB()
        {
            //Arrange
            Grades expectedGrade = Grades.B;

            //Act
            Grades actualGrade = converter.ConvertToGrade(60);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert69toGradeB()
        {
            //Arrange
            Grades expectedGrade = Grades.B;

            //Act
            Grades actualGrade = converter.ConvertToGrade(69);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert70toGradeA()
        {
            //Arrange
            Grades expectedGrade = Grades.A;

            //Act
            Grades actualGrade = converter.ConvertToGrade(70);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert100toGradeA()
        {
            //Arrange
            Grades expectedGrade = Grades.A;

            //Act
            Grades actualGrade = converter.ConvertToGrade(100);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }
        [TestMethod]
        public void TestCalculateMean()
        {
            //Arrange
            converter.Marks = testMarks;
            double expectedMean = 55.0;

            //Act
            converter.CalculateStats();

            //Assert
            Assert.AreEqual(expectedMean, converter.Mean);
        }
        [TestMethod]
        public void TestCalculateMin()
        {
            //Arrange
            converter.Marks = testMarks;
            double expectedMin = 10;

            //Act
            converter.CalculateStats();

            //Assert
            Assert.AreEqual(expectedMin, converter.Minimum);
        }

        [TestMethod]
        public void TestCalculateMax()
        {
            //Arrange
            converter.Marks = testMarks;
            double expectedMax = 100;

            //Act
            converter.CalculateStats();

            //Assert
            Assert.AreEqual(expectedMax, converter.Maximum);
        }

        [TestMethod]
        public void TestGradeProfile()
        {
            //Arrange
            converter.Marks = testMarks;

            //Act
            converter.CalculateGradeProfile();

            bool expectedProfile;
            expectedProfile = ((converter.GradeProfile[0] == 3) &&
                               (converter.GradeProfile[1] == 1) &&
                               (converter.GradeProfile[2] == 1) &&
                               (converter.GradeProfile[3] == 1) &&
                               (converter.GradeProfile[4] == 4));

            //Assert
            Assert.IsTrue(expectedProfile);
        }
    }
}
