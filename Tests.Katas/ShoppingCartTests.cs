using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Tests.Katas
{
    public class ShoppingCartTests
    {
        [Test]
        public void ItemsCanBeAddedToShoppingCart()
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.AddItem(new Item());
            shoppingCart.AddItem(new Item());

            Assert.AreEqual(2, shoppingCart.Count());
        }
    }

    public class ShoppingCart : IEnumerable<Item>
    {
        private readonly List<Item> _items = new List<Item>();

        public IEnumerator<Item> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        internal void AddItem(Item item)
        {
            _items.Add(item);
        }
    }

    public class Item
    {
    }
}