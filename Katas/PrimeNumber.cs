using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class PrimeNumber
    {
        public IEnumerable<int> FidAll(int num)
        {
            var numbers = new Dictionary<int, int>();

            for (int i = num; i > 0; i--)
            {
                int noOfDivisors = 0;
                for (int j = i; j > 0; j--)
                {
                    if (i%j == 0)
                        noOfDivisors++;
                }

                numbers.Add(i, noOfDivisors);
            }

            return numbers
                .Where(item => item.Value == 2)
                .Select(item => item.Key).ToList();
        }
    }
}