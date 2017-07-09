using System;
namespace VendingMachineTechTest
{
    public class Credit
    {
        public double total;

        public Credit()
        {
            total = 0;
        }

        public void Add(double coin)
        {
            if (coin % 0.50 == 0){
             total = +coin;   
            } else {
                Console.WriteLine("Incorrect change added.");
            }

        }
    }
}
