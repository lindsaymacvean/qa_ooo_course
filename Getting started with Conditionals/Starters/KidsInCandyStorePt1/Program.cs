using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KidsInCandyStorePt1 {
  class Program {
    static void Main(string[] args) {
      int price = GetInteger("Price of a bag please");
      int money = GetInteger("How much money do you have?");
      if (price <= 0)
        ExitProgram("The price cant be zero or less");
      if (money < 0)
        ExitProgram("You can't have negative money");
      if (money < price)
        ExitProgram("You can't afford any bags of sweets");
      int numBags = money/price;
      Console.WriteLine("If the price is {0}p and you have {1}p then you will be able to buy {2} bags",
          price, money, money/price);
      Console.ReadLine();
    }

    static int GetInteger(string message) {
      Console.WriteLine(message); 
      string answer = Console.ReadLine();
      int intAnswer = Convert.ToInt32(answer);
      return intAnswer;
    }

    static void ExitProgram(string message) {
      Console.WriteLine(message);
      Console.ReadLine();
      Environment.Exit(0);
    }
  }
}
