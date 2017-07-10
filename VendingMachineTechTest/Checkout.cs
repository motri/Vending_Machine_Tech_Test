using System;
using System.Collections;
namespace VendingMachineTechTest
{
    public class Checkout
    {
        public decimal total;

        public Checkout()
        {
            total = 0.0m;
        }

        public void calculateTotal(Hashtable basketItems, Hashtable productList)
        {
            foreach (object item in basketItems.Keys)
            {
                decimal itemQuantity;
                itemQuantity = Convert.ToDecimal(basketItems[item]);
                decimal itemPrice;
                itemPrice = Convert.ToDecimal(productList[item]);
                total += (itemQuantity * itemPrice );
            }
        }
    }
}
