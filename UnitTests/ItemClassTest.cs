using NUnit.Framework;
using System;
using System.Collections;
using VendingMachineTechTest;
namespace UnitTests
{
    [TestFixture()]
    public class ItemClassTest
    {
        Item item;

        [SetUp]
        public void SetUp()
        {
            item = new Item();
        }

        [Test()]
        public void Class_can_be_initialized()
        {
            Assert.IsInstanceOf<Item>(item);
        }

        [Test()]
        public void Class_contains_a_hash_when_initialized()
        {
            Assert.IsInstanceOf<Hashtable>(item.list);
        }

        [Test()]
        public void List_hashtable_contains_item_names_as_keys_and_prices_as_values()
        {
            Assert.AreEqual(item.list["Crisps"], 0.40 );
            Assert.AreEqual(item.list["Water"], 0.60 );
        }
    }
}
