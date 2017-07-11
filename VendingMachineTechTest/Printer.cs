using System;
using System.Collections;
namespace VendingMachineTechTest
{
    public class Printer
    {
        public Printer()
        {
        }

        public void RenderTransactionOutcome(decimal change, Hashtable basketItems)
        {
            Console.WriteLine("Your items:");

            foreach (DictionaryEntry pair in basketItems)
            {
                Console.WriteLine("{0} {1}", pair.Value, pair.Key);
            }

            Console.WriteLine("Your change: {0:C}.", change);
        }

    }
}

