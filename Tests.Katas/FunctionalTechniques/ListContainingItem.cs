using System;
using Katas;
using NUnit.Framework;

namespace Tests.Katas.FunctionalTechniques
{
    internal class ListContainingItem
    {
        private readonly Func<string, bool> _isInList;

        public ListContainingItem()
        {
            _isInList = Functional.IsInList(new[] {"1", "2", "3"}, "1");
        }

        [Test]
        public void ShouldReturnTrueIfItemIsPresent()
        {
            Assert.True(_isInList("1"));
        }

        [Test]
        public void ShouldReturnFalseIfItemIsNotPresent()
        {
            Assert.False(_isInList("4"));
        }
    }
}