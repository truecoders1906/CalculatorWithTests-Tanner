using System;
using System.Linq;

namespace CalculatorWithTests
{
    public class Calculator
    {
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static decimal Subtract(decimal minuend, decimal subtrahend)
        {
            return minuend - subtrahend;
        }

        public static decimal Multiply(decimal num3, decimal num4)
        {
            return num3 * num4;
        }

        public static decimal Divide(decimal dividend, decimal divisor)
        {
            return dividend / divisor;
        }

        public static decimal Factorial(decimal num5)
        {
            int i;
            int fact = 1;
            for(i = 1; i <= num5; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
