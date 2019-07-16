using System;
using System.Linq;

namespace CalculatorWithTests
{
    public class Calculator
    {
        public decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public decimal Subtract(decimal minuend, decimal subtrahend)
        {
            return minuend - subtrahend;
        }

        public decimal Multiply(decimal num3, decimal num4)
        {
            return num3 * num4;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }

            return dividend / divisor;
        }

        public decimal Factorial(decimal num5)
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
