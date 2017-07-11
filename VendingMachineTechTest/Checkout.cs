using System;
using System.Collections;
namespace VendingMachineTechTest
{
    public class Checkout
    {
        public decimal total;
        public decimal change;
        public bool paid;

        public Checkout()
        {
            total = 0.0m;
            paid = false;
        }

        public void CompleteTransaction(Hashtable basketItems, Hashtable productList, decimal credit, decimal total)
        {
            this.CalculateTotal(basketItems, productList);
            total = this.total;
            this.ProceedToPayment(credit, total);
        }

        public void CalculateTotal(Hashtable basketItems, Hashtable productList)
        {
            foreach (object item in basketItems.Keys)
            {
                decimal itemQuantity;
                itemQuantity = Convert.ToDecimal(basketItems[item]);
                decimal itemPrice;
                itemPrice = Convert.ToDecimal(productList[item]);
                total += (itemQuantity * itemPrice);
            }
        }

        public void ProceedToPayment(decimal credit, decimal total)
        {
            if (credit < total)
            {
                Console.WriteLine("Not enough credit, please add coins.");
            }
            else
            {
                paid = true;
                change = credit - total;
                credit = 0.0m;
            }
        }
    }
}
