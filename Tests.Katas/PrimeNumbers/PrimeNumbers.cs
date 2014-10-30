using System.Collections.Generic;
using System.Linq;
using Katas;
using NUnit.Framework;

namespace Tests.Katas.PrimeNumbers
{
    class PrimeNumbers
    {
        [Test]
        public void NoOfPrimeNumbersUpto10ShouldBe_4()
        {
            IEnumerable<int> primeNumbers = new PrimeNumber().FidAll(10).ToList();
            Assert.AreEqual(4, primeNumbers.Count());            
            Assert.True(primeNumbers.Contains(2));
            Assert.True(primeNumbers.Contains(3));
            Assert.True(primeNumbers.Contains(5));
            Assert.True(primeNumbers.Contains(7));
        }

        [Test]
        public void NoOfPrimeNumbersUpto20ShouldBe_8()
        {
            IEnumerable<int> primeNumbers = new PrimeNumber().FidAll(20).ToList();
            Assert.AreEqual(8, primeNumbers.Count());
            Assert.True(primeNumbers.Contains(11));
            Assert.True(primeNumbers.Contains(13));
            Assert.True(primeNumbers.Contains(17));
            Assert.True(primeNumbers.Contains(19));
        }

        [Test]
        public void NoOfPrimeNumbersUpto30ShouldBe_10()
        {
            IEnumerable<int> primeNumbers = new PrimeNumber().FidAll(30).ToList();
            Assert.AreEqual(10, primeNumbers.Count());
            Assert.True(primeNumbers.Contains(23));
            Assert.True(primeNumbers.Contains(29));
        }

        [Test]
        public void NoOfPrimeNumbersUpto40ShouldBe_12()
        {
            IEnumerable<int> primeNumbers = new PrimeNumber().FidAll(40).ToList();
            Assert.AreEqual(12, primeNumbers.Count());
            Assert.True(primeNumbers.Contains(31));
            Assert.True(primeNumbers.Contains(37));
        }

        [Test]
        public void NoOfPrimeNumbersForANegativeNumberShouldBe_0()
        {
            IEnumerable<int> primeNumbers = new PrimeNumber().FidAll(-1).ToList();
            Assert.AreEqual(0, primeNumbers.Count());            
        }
    }
}
