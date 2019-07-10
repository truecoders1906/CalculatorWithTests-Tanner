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

        public static decimal Subtract(decimal num3, decimal num4)
        {
            return num3 - num4;
        }

        public static decimal Multiply(decimal num5, decimal num6)
        {
            return num5 * num6;
        }

        public static decimal Divide(decimal num7, decimal num8)
        {
            return num7 / num8;
        }

        public static decimal Factorial(decimal num9)
        {
            int i;
            int fact = 1;
            for(i = 1; i <= num9; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
