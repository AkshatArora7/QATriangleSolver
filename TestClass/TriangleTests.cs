using TriangleSolver;
using NUnit.Framework;

namespace TestClass
{
    [TestFixture]
    public class TriangleTests
    {
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

        

    }
}