using System.Collections;
using NUnit.Framework;
using VendingMachineTechTest;
namespace UnitTests
{
    [TestFixture]
    public class ProductClassTest
    {
        Product product;

        [SetUp]
        public void SetUp()
        {
            product = new Product();
        }

        [Test]
        public void Class_can_be_instantiated()
        {
            Assert.IsInstanceOf<Product>(product);
        }

        [Test]
        public void Class_contains_a_hash_when_initialized()
        {
            Assert.IsInstanceOf<Hashtable>(product.list);
			Assert.IsNotEmpty(product.list);
			Assert.AreEqual(product.list.Count, 2);
        }

        [Test]
        public void List_hashtable_contains_item_names_as_keys_and_prices_as_values()
        {

            Assert.AreEqual(product.list["Crisps"], 0.40);
            Assert.AreEqual(product.list["Water"], 0.60);
        }
    }
}
