using System;

namespace Katas
{
    public class Factorial
    {
        public int Compute(int number)
        {
            if (number < 0)
                throw new ArgumentException("The number must be a positive integer.");
            int fact = 1;
            for (int i = number; i > 0; i--)
            {
                fact *= i;
            }

            return fact;
        }

        public int Fact(int number)
        {
            if (number < 0)
                throw new InvalidOperationException();

            if (number == 0)
                return 1;
            return Fact(number - 1)*number;
        }
    }
}