using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KidsInCandyStorePt2 {
  class Program {
    static void Main(string[] args) {


      int price = GetInteger("Price of a bag please?");
      if (price > 0)
      {
        int money = GetInteger("How much money do you have?");

        if (money > 0)
        {
          int numBags = (money / price);

          Console.WriteLine("If price is {0}p and you have {1}p you will be able to purchase {2} bags",
                              price, money, numBags);
        }
        else if (money == 0) // no pocket money
        {
          Console.WriteLine("Come back with your pocket money!");
        }
        else // money is less than 0
        {
          Console.WriteLine("Money must be a non-negative numeric value");
        }
      }
      else if (price == 0) // free
      {
        Console.WriteLine("They are free take loads!!");
      }
      else // price is less than 0
      {
        Console.WriteLine("Price must be a non-negative numeric value");
      }

      Console.ReadLine();
    }
    
    static int GetInteger(string message) {
      Console.WriteLine(message);
      string sVal = Console.ReadLine();
      int val;
      if (int.TryParse(sVal, out val))
        return val;
      else {
        Console.WriteLine("You need to enter a number\n");
        return GetInteger(message);
      }
    }
  }
}
