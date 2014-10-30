using System;

namespace Katas
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter a number to convert to Roman numerals...");
                string input = Console.ReadLine();
                int number;
                if (IsANumber(input, out number))
                {
                    try
                    {
                        string romanNo = new RomanNumeralGenerator().Generate(number);
                        Console.WriteLine("{0} => {1}", number, romanNo);
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }

        private static bool IsANumber(string input, out int number)
        {
            return int.TryParse(input, out number);
        }
    }
}
