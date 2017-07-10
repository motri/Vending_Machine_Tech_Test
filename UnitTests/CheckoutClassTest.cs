using NUnit.Framework;
using System;
using System.Collections;
using System.IO;
using VendingMachineTechTest;
namespace UnitTests
{
    [TestFixture()]
    public class CheckoutClassTest
    {
        Checkout checkout;
        Hashtable productList;
        Hashtable basketItems;
        Decimal credit;

        [SetUp]
        public void SetUp()
        {
            checkout = new Checkout();
            productList = new Hashtable();
            productList.Add("Water", 0.6m);
            productList.Add("Crisps", 0.4m);
            basketItems = new Hashtable();
            basketItems.Add("Water", 3);
            basketItems.Add("Crisps", 2);
        }

        [Test()]
        public void Class_can_be_instantiated()
        {
            Assert.IsInstanceOf<Checkout>(checkout);
        }

        [Test()]
        public void Calculates_total_owed()
        {
            checkout.calculateTotal(basketItems, productList);
            Assert.AreEqual(checkout.total, 2.6m);
        }

        [Test()]
        public void Raises_error_if_credit_insufficient()
        {
			using (StringWriter alert = new StringWriter())
            {
                Console.SetOut(alert);
				credit = 0.0m;
				checkout.calculateTotal(basketItems, productList);
				checkout.proceedToPayment(credit, checkout.total);
				Assert.AreEqual("Not enough credit, please add coins.\n", alert.ToString());
			}
        }
    }
}