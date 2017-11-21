using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KidsInCandyStorePt3 {
  class Program {
    static void Main(string[] args) {
      decimal price = GetDecimal("Price of a bag please?");
      if (price < 0)
      {
        Console.WriteLine("Price must be a non-negative numeric value");
        return;
      }
      if (price == 0)
      {
        Console.WriteLine("They are free take loads!!");
        return;
      }
      decimal money = GetDecimal("How much money do you have?");
      if (money < 0)
      {
        Console.WriteLine("Money must be a non-negative numeric value");
        return;
      }
      if (money == 0)
      {
        Console.WriteLine("Come back with your pocket money!");
      }
      // do calculations and display
      int numBags = (int)(money / price);


      Console.WriteLine("If price is {0:C2} and you have {1:C2} you will be able to purchase {2} bag{4} and will have {3:C2} left over",
        price, money, numBags, money % price, (numBags==1)?"":"s");



    }
    

    static decimal GetDecimal(string message) {
      Console.WriteLine(message);
      string sVal = Console.ReadLine();
      decimal val;
      if (!decimal.TryParse(sVal, out val)) // ie sVal not numeric
      {
        val = -1;
      }
      return val;
    }

    //static int GetInteger(string message) {
    //  Console.WriteLine(message);
    //  string sVal = Console.ReadLine();
    //  int val;
    //  if (!int.TryParse(sVal, out val)) // ie sVal not numeric
    //  {
    //    val = -1;
    //  }
    //  return val;
    //}
  }
}
