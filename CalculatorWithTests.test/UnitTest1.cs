using System;
using Xunit;
using CalculatorWithTests;

namespace CalculatorWithTests.test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3, 2, 5)]
        [InlineData(16, 16, 32)]
        [InlineData(99, 99, 198)]
        [InlineData(-10, 0, -10)]
        [InlineData(0, 0, 0)]
        [InlineData(-32, -32, -64)]
        [InlineData(15, -15, 0)]
        public void ShouldAdd(decimal num1, decimal num2, decimal expected)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            decimal actual = Calculator.Add(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(72, 12, 60)]
        [InlineData(-99, -33, -66)]
        [InlineData(-100, 100, -110)]
        [InlineData(0, 0, 0)]
        [InlineData(-32, -16, -16)]
        [InlineData(15, -15, 30)]
        public void ShouldSubtract(decimal minuend, decimal subtrahend, decimal expected)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            decimal actual = Calculator.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(100, 10, 1000)]
        [InlineData(50, 5, 250)]
        [InlineData(9, 9, 81)]
        [InlineData(-10, 0, 0)]
        [InlineData(10, -10, -100)]
        [InlineData(-12, -12, 144)]
        [InlineData(150, -10, -1500)]
        public void ShouldMultiply(decimal num3, decimal num4, decimal expected)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            decimal actual = Calculator.Multiply(num3, num4);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(25000, 1000, 25)]
        [InlineData(160, 16, 10)]
        [InlineData(99, 33, 3)]
        [InlineData(0, 100000, 0)]
        [InlineData(-120000, 1, -120000)]
        [InlineData(-150, 5, -30)]
        [InlineData(-200000, 1000, -200)]
        public void ShouldDivide(decimal dividend, decimal divisor, decimal expected)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            decimal actual = Calculator.Divide(dividend, divisor);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 40320)]
        [InlineData(5, 120)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(0, 1)]
        public void ShouldFactorial(int num5, int expected)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            decimal actual = Calculator.Factorial(num5);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
