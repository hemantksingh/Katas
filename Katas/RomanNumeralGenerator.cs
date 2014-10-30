using System;
using System.Collections.Generic;
using System.Text;

namespace Katas
{
    public class RomanNumeralGenerator
    {
        private readonly Dictionary<int, string> _romanNumbers = new Dictionary<int, string>
            {
                {1000, "M"},
                {900, "CM"},
                {500, "D"},
                {400, "CD"},
                {100, "C"},
                {50, "L"},
                {40, "XL"},
                {10, "X"},
                {9, "IX"},
                {5, "V"},
                {4, "IV"},
                {1, "I"},
            };

        public string Generate(int number)
        {
            EnsureNumberIsValid(number);
            
            var roman = new StringBuilder();

            foreach (var item in _romanNumbers)
            {
                while (number >= item.Key)
                {
                    roman.Append(item.Value);
                    number -= item.Key;
                }
            }

            return roman.ToString();
        }

        private static void EnsureNumberIsValid(int number)
        {
            if (number < 1 || number > 3999)
                throw new ArgumentOutOfRangeException("number", "The number can only be a value between 1 and 3999.");
        }
    }
}