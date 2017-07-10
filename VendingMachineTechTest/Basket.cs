﻿using System;
using System.Collections;
namespace VendingMachineTechTest
{
    public class Basket
    {
        public Hashtable items;
        public Item item;
        public Basket()
        {
            items = new Hashtable();
            item = new Item();
        }

        public void AddItem(string itemName, int itemQuantity)
        {
            if (item.list.ContainsKey(itemName))
            {
                if (items.ContainsKey(itemName))
                {
                    int number;
                    number = (int)items[itemName];
                    items[itemName] = number + itemQuantity;
                }
                else
                {
                    items.Add(itemName, itemQuantity); 
                }

            } 
            else
            {
                Console.WriteLine("Item not avaliable.");
            }

        }
    }
}
