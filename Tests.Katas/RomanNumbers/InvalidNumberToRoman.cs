using System;
using Katas;
using NUnit.Framework;

namespace Tests.Katas.RomanNumbers
{
    public class InvalidNumberToRoman
    {
        private readonly RomanNumeralGenerator _generator;

        public InvalidNumberToRoman()
        {
            _generator = new RomanNumeralGenerator();
        }

        [Test]
        public void Test()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _generator.Generate(0));
        }

        [Test]
        public void TestUpperRange()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _generator.Generate(4000));
        }
    }
}