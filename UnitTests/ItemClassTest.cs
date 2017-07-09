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
    }
}
