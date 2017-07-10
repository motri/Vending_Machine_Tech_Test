using NUnit.Framework;
using System;
using System.IO;
using System.Collections;
using VendingMachineTechTest;
namespace UnitTests
{
    [TestFixture()]
    public class BasketClassTest
    {
        Basket basket;
        [SetUp]
        public void SetUp()
        {
            basket = new Basket();
        }

        [Test()]
        public void Class_can_instantiated()
        {
            Assert.IsInstanceOf<Basket>(basket);
        }

        [Test()]
		public void Class_contains_a_hash_when_initialized()
		{
			Assert.IsInstanceOf<Hashtable>(basket.items);
		}
        [Test()]
        public void Hash_is_empty_when_initialized()
        {
            Assert.IsEmpty(basket.items);
        }

        [Test()]
        public void Item_is_added_to_basket_by_AddItem_method()
        {
            basket.AddItem("Water", 1);
            Assert.IsNotEmpty(basket.items);
            Assert.AreEqual(basket.items["Water"], 1);
        }

        [Test()]
        public void Only_items_available_to_add_are_water_and_crisps()
        {
            
			using (StringWriter alert = new StringWriter())
			{
				Console.SetOut(alert);
				basket.AddItem("Soda", 4);
				Assert.AreEqual("Item not avaliable.\n", alert.ToString());
			}
        }

		[Test()]
		public void If_product_already_in_basket_quantity_added_to_previous_number()
		{
			basket.AddItem("Water", 1);
            basket.AddItem("Water", 3);
            Assert.AreEqual(basket.items["Water"], 4);
		}
    }
}
