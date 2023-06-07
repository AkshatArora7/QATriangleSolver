using TriangleSolver;
using NUnit.Framework;

namespace TestClass
{
    [TestFixture]
    public class TriangleTests
    {

        //-	Only one (1) test for a valid equilateral triangle
        [Test]
        public void ValidTriangle_Input20and20and20_OutputEquilateralTriangle()
        {
            //Arrange
            int firstSide = 20;
            int secondSide = 20;
            int thirdSide = 20;

            string expected = "An EQUILATERAL triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide); 

            //Assert
            Assert.AreEqual(expected, actual);
        }



        //-	Three (3) tests for a valid isosceles triangle

        [Test]
        public void ValidTriangle_Input20and20and30_OutputIsoscelesTrianlge()
        {
            //Arrange
            int firstSide = 20;
            int secondSide = 20;
            int thirdSide = 30;

            string expected = "An ISOSCELES triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void ValidTriangle_Input12and5and5_OutputIsoscelesTrianlge()
        {
            //Arrange
            int firstSide = 12;
            int secondSide = 5;
            int thirdSide = 5;

            string expected = "An ISOSCELES triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void ValidTriangle_Input3and14and3_OutputIsoscelesTrianlge()
        {
            //Arrange
            int firstSide = 3;
            int secondSide = 14;
            int thirdSide = 3;

            string expected = "An ISOSCELES triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        //-	Five (5) tests for a valid scalene triangle

        [Test]
        public void ValidTriangle_Input20and30and40_OutputScaleneTrianlge()
        {
            //Arrange
            int firstSide = 20;
            int secondSide = 30;
            int thirdSide = 40;

            string expected = "A SCALENE triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void ValidTriangle_Input12and4and9_OutputScaleneTrianlge()
        {
            //Arrange
            int firstSide = 12;
            int secondSide = 4;
            int thirdSide = 9;

            string expected = "A SCALENE triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void ValidTriangle_Input89and56and180_OutputScaleneTrianlge()
        {
            //Arrange
            int firstSide = 89;
            int secondSide = 56;
            int thirdSide = 180;

            string expected = "A SCALENE triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void ValidTriangle_Input7and12and15_OutputScaleneTrianlge()
        {
            //Arrange
            int firstSide = 7;
            int secondSide = 12;
            int thirdSide = 15;

            string expected = "A SCALENE triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void ValidTriangle_Input10and12and13_OutputScaleneTrianlge()
        {
            //Arrange
            int firstSide = 10;
            int secondSide = 12;
            int thirdSide = 13;

            string expected = "A SCALENE triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }



        //-	Three (3) tests for verifying an invalid response (other than a zero length)


        [Test]
        public void InvalidTriangle_Input20and20and40_OutputInvalidTrianlge()
        {
            //Arrange
            int firstSide = 20;
            int secondSide = 20;
            int thirdSide = 40;

            string expected = "INVALID Triangle detected!!";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void InvalidTriangle_Input1and4and7_OutputInvalidTrianlge()
        {
            //Arrange
            int firstSide = 1;
            int secondSide = 4;
            int thirdSide = 7;

            string expected = "INVALID Triangle detected!!";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void InvalidTriangle_Input1and2and5_OutputInvalidTrianlge()
        {
            //Arrange
            int firstSide = 1;
            int secondSide = 2;
            int thirdSide = 5;

            string expected = "INVALID Triangle detected!!";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        //-	Three (3) tests for verifying a zero length for one or more sides

        [Test]
        public void InvalidTriangle_Input10and20and0_OutputInvalidTrianlge()
        {
            //Arrange
            int firstSide = 10;
            int secondSide = 20;
            int thirdSide = 0;

            string expected = "Invalid Triangle - at least one side is zero";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void InvalidTriangle_Input0and20and0_OutputInvalidTrianlge()
        {
            //Arrange
            int firstSide = 0;
            int secondSide = 20;
            int thirdSide = 0;

            string expected = "Invalid Triangle - at least one side is zero";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void InvalidTriangle_Input0and0and0_OutputInvalidTrianlge()
        {
            //Arrange
            int firstSide = 0;
            int secondSide = 0;
            int thirdSide = 0;

            string expected = "Invalid Triangle - at least one side is zero";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }


    }
}