using Katas;
using NUnit.Framework;

namespace Tests.Katas.RomanNumbers
{
    public class ValidNumberToRoman
    {
        private readonly RomanNumeralGenerator _generator;

        public ValidNumberToRoman()
        {
            _generator = new RomanNumeralGenerator();            
        }

        [Test]
        public void One_Generates_I()
        {
            Assert.AreEqual("I", _generator.Generate(1));
        }

        [Test]
        public void Two_Generates_II()
        {
            Assert.AreEqual("II", _generator.Generate(2));
        }

        [Test]
        public void Three_Generates_III()
        {
            Assert.AreEqual("III", _generator.Generate(3));
        }

        [Test]
        public void Four_Generates_IV()
        {
            Assert.AreEqual("IV", _generator.Generate(4));
        }


        [Test]
        public void Five_Generates_V()
        {
            Assert.AreEqual("V", _generator.Generate(5));
        }

        [Test]
        public void Six_Generates_VI()
        {
            Assert.AreEqual("VI", _generator.Generate(6));
        }

        [Test]
        public void Ten_Generates_X()
        {
            Assert.AreEqual("X", _generator.Generate(10));
        }

        [Test]
        public void Fifty_Generates_L()
        {
            Assert.AreEqual("L", _generator.Generate(50));
        }

        [Test]
        public void Hundred_Generates_C()
        {
            Assert.AreEqual("C", _generator.Generate(100));
        }

        [Test]
        public void FourHundred_Generates_CD()
        {
            Assert.AreEqual("CD", _generator.Generate(400));
        }

        [Test]
        public void FiveHundred_Generates_D()
        {
            Assert.AreEqual("D", _generator.Generate(500));
        }

        [Test]
        public void NineHundred_Generates_CM()
        {
            Assert.AreEqual("CM", _generator.Generate(900));
        }

        [Test]
        public void OneThousand_Generates_M()
        {
            Assert.AreEqual("M", _generator.Generate(1000));
        }

        [Test]
        public void ThreeThousandEightHundredEitghtyNine_Generates_MMMDCCCLXXXIX()
        {
            Assert.AreEqual("MMMDCCCLXXXIX", _generator.Generate(3889));
        }
    }
}