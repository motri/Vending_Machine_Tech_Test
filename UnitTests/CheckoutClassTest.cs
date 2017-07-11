using System;
using System.Collections;
using System.IO;
using NUnit.Framework;
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
            productList = new Hashtable
            {
                { "Water", 0.6m },
                { "Crisps", 0.4m }
            };
            basketItems = new Hashtable
            {
                { "Water", 3 },
                { "Crisps", 2 }
            };
        }

        [Test()]
        public void Class_can_be_instantiated()
        {
            Assert.IsInstanceOf<Checkout>(checkout);
        }

        [Test()]
        public void Calculates_total_owed()
        {
            checkout.CalculateTotal(basketItems, productList);
            Assert.AreEqual(checkout.total, 2.6m);
        }

        [Test()]
        public void Raises_error_if_credit_insufficient()
        {
            using (StringWriter alert = new StringWriter())
            {
                Console.SetOut(alert);
                credit = 0.0m;
                checkout.CalculateTotal(basketItems, productList);
                checkout.ProceedToPayment(credit, checkout.total);
                Assert.AreEqual("Not enough credit, please add coins.\n", alert.ToString());
            }
        }

        [Test()]
        public void Calculates_change()
        {
            credit = 3.5m;
            checkout.CalculateTotal(basketItems, productList);
            checkout.ProceedToPayment(credit, checkout.total);
            Assert.AreEqual(checkout.change, 0.9m);
        }

        [Test()]
        public void Completes_transaction_calculating_total_and_then_proceeds_to_payment()
        {
            credit = 3.5m;
            checkout.CompleteTransaction(basketItems, productList, credit, checkout.total);
            Assert.AreEqual(checkout.total, 2.6m);
            Assert.AreEqual(checkout.change, 0.9m);

        }
        [Test()]
        public void Sets_paid_to_true_when_credit_higher_equal_to_total()
        {
            credit = 3.5m;
            checkout.CompleteTransaction(basketItems, productList, credit, checkout.total);
            Assert.True(checkout.paid);
        }
    }
}