using System;
using Katas;
using NUnit.Framework;

namespace Tests.Katas.FunctionalTechniques
{
    internal class Adding2NumbersUsingManualCurrying
    {
        private readonly Functional _functional = new Functional();

        /// <summary>
        /// Currying - Splitting up the parameter list so that a function can be 
        /// called with an incomplete set of parameters. Mechanisms like overloading 
        /// and extension methods have a similar purpose.
        ///
        /// add2 function provides resuse and modularization in this case. 
        /// </summary>
        [Test]
        public void WithPartialSetOfParameters_ReturnsTheSum()
        {
            Func<int, int> add2 = _functional.Add(2);
            Assert.AreEqual(5, add2(3));
            Assert.AreEqual(7, add2(5));
        }

        [Test]
        public void WithFullSetOfParameters_ReturnsTheSum()
        {
            Assert.AreEqual(5, _functional.Add(2)(3));
        }
    }
}