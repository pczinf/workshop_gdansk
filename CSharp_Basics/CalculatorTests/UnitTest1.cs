using System;
using NUnit.Framework;
using Calculator;

namespace CalculatorTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void AddingPP()
        {
            //Arrange
            MathData mathData = new MathData(5, 3, "+");
            //Act
            var result = Calculations.Calculation(mathData);
            //Assert
            Assert.AreEqual(8, result);
        }

        [Test]
        public void AddingPN()
        {
            //Arrange
            MathData mathData = new MathData(1, -1, "+");
            //Act
            var result = Calculations.Calculation(mathData);
            //Assert
            Assert.AreEqual(0, result);
        }
        [Test]
        public void AddingMAX()
        {
            //Arrange
            MathData mathData = new MathData(double.MaxValue, double.MaxValue, "+");
            //Act
            var result = Calculations.Calculation(mathData);
            //Assert
            Assert.AreEqual(2*double.MaxValue, result);
        }

        [TestCase(1,4,5)]
        [TestCase(1, -1, 0)]
        [TestCase(double.MaxValue, double.MaxValue, 2* double.MaxValue)]
        public void AddingOperation(double v1, double v2, double res)
        {
            //Arrange
            MathData mathData = new MathData(v1, v2, "+");
            //Act
            var result = Calculations.Calculation(mathData);
            //Assert
            Assert.AreEqual(res, result);
        }
    }
}
