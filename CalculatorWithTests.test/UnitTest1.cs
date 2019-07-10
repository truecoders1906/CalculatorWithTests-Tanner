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

        

    }
}
