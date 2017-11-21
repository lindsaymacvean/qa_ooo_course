using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KidsInCandyStorePt3
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal price = GetDecimal("Price of a bag please?");
            if (price > 0)
            {
                decimal money = GetDecimal("How much money do you have?");
                if (money > 0)
                {
                    decimal numBags = (money / price);
                    Console.WriteLine("If price is £{0} and you have £{1} you will be able to purchase " +
                        "{2} {4} and will have £{3} left over",
                        price, money, numBags, money % price, numBags > 1 ? "bags":"bag");
                }
                else if (money == 0) // no pocket money
                    Console.WriteLine("Come back with your pocket money!");
                else
                    Console.WriteLine("Money must be a non-negative numeric value");
            }
            else if (price == 0) // free
                Console.WriteLine("They are free take loads!!");
            else // price is less than 0
                Console.WriteLine("Price must be a non-negative numeric value");
            Console.ReadLine();
        }

        static decimal GetDecimal(string message)
        {
            Console.WriteLine(message);
            string sVal = Console.ReadLine();
            decimal val;
            if (!decimal.TryParse(sVal, out val)) // ie sVal not numeric
            {
                val = -1;
            }
            return val;
        }
    }
}
