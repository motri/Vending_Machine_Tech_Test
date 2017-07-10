using System;
using System.Collections;
namespace VendingMachineTechTest
{
    public class Basket
    {
        public Hashtable items;
        public Basket()
        {
            items = new Hashtable();
        }

        public void AddItem(string itemName, int itemQuantity)
        {
            items.Add(itemName, itemQuantity);
        }
    }
}
