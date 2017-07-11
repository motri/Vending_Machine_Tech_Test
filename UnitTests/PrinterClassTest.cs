using System;
using System.Collections;
using System.IO;
using NUnit.Framework;
using VendingMachineTechTest;
namespace UnitTests
{
    [TestFixture]
    public class PrinterClassTest
    {
        Printer printer;
        Hashtable basketItems;

        [SetUp]
        public void SetUp()
        {
            printer = new Printer();
            basketItems = new Hashtable
            {
                { "Water", 3 },
                { "Crisps", 2 }
            };
        }
        [Test]
        public void The_class_can_be_instantiated()
        {
            Assert.IsInstanceOf<Printer>(printer);
        }

        [Test]
        public void Print_processed_order_and_change()
        {
            using (StringWriter outcome = new StringWriter())
                
            {
                Console.SetOut(outcome);
                printer.RenderTransactionOutcome(0.6m, basketItems);
                Assert.AreEqual("Your items:\n2 Crisps\n3 Water\nYour change: 0,60 €.\n", outcome.ToString());

            }
        }
    }
}
