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
        public Header header;

        public VendingMachine()
        {
            credit = new Credit();
            basket = new Basket();
            product = new Product();
            checkout = new Checkout();
            printer = new Printer();
            header = new Header();
        }

        public void Begin()
        {
            PrintHeader();

            string choice = Console.ReadLine();

            if (choice == "Credit" || choice == "credit")
            {
                CreditMenu();
            }
            if (choice == "Add" || choice == "add")
            {
                BasketMenu();
            }
            if (choice == "checkout" || choice == "Checkout")
            {
                CheckoutMenu();
            }
        }

        public void PrintHeader()
        {
            header.Print(product.list, credit.total, basket.items);
            Console.Write("Type Credit to add credit, Add to add item & Checkout to checkout\n");
        }

        public void CreditMenu()
        {
            Console.Write("Type amount\n");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            credit.Add(amount);
        }

        public void BasketMenu()
        {
			Console.Write("Type product name\n");
			string itemChoice = Console.ReadLine();
			Console.Write("Type amount you would like\n");
			int itemQuantity = Convert.ToInt32(Console.ReadLine());
			basket.AddItem(itemChoice, itemQuantity, product.list);
        }

        public void CheckoutMenu()
        {
			checkout.CalculateTotal(basket.items, product.list);
			checkout.ProceedToPayment(credit.total, checkout.total);
			if (checkout.paid)
			{
				printer.RenderTransactionOutcome(checkout.change, basket.items);
			}
        }
    }
}
