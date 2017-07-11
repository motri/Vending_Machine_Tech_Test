using System;
namespace VendingMachineTechTest
{
    public class VendingMachine
    {
        public Credit credit;
        public Basket basket;
        public Product product;
        public Checkout checkout;
        public Printer printer;

        public VendingMachine()
        {
            credit = new Credit();
            basket = new Basket();
            product = new Product();
            checkout = new Checkout();
            printer = new Printer();
        }
    }
}
