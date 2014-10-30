using NUnit.Framework;

namespace Tests.Katas.Factorial
{
    internal class ComputeFactorial
    {
        [Test]
        public void FactorailOf1ShouldBe_1()
        {
            Assert.AreEqual(1, new global::Katas.Factorial().Fact(1));
            Assert.AreEqual(1, new global::Katas.Factorial().Compute(1));
        }

        [Test]
        public void FactorailOf2ShouldBe_2()
        {
            Assert.AreEqual(2, new global::Katas.Factorial().Fact(2));
            Assert.AreEqual(2, new global::Katas.Factorial().Compute(2));
        }

        [Test]
        public void FactorailOf3ShouldBe_6()
        {
            Assert.AreEqual(6, new global::Katas.Factorial().Fact(3));
            Assert.AreEqual(6, new global::Katas.Factorial().Compute(3));
        }

        [Test]
        public void FactorailOf10ShouldBe_3628800()
        {
            Assert.AreEqual(3628800, new global::Katas.Factorial().Fact(10));
            Assert.AreEqual(3628800, new global::Katas.Factorial().Compute(10));
        }
    }
}