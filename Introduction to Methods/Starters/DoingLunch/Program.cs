using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoingLunch {
  class Program {
    static void Main(string[] args) {

      Console.WriteLine("What main dish would you like?");
      string mainCourse = Console.ReadLine();

      int roastPotatoes = GetInteger("How many roast potatoes?");
      
      int brusselSprouts = GetInteger("How many brussel sprouts?");

      // Put the display here!
      Console.WriteLine("Hello your lunch is {0} with {1} roast potatoes and {2} brussel sprouts.", 
      mainCourse, roastPotatoes, brusselSprouts);

      int remainingRoastPotatoes = RemainingRoastPotato(roastPotatoes, brusselSprouts);
            Console.WriteLine("After adding an exra potato, cutting them into quarters and eating one brussel" +
                " sprout with every quarter; there will be {0} quarters of roast potatoes left.", 
                remainingRoastPotatoes);
      Console.ReadLine();
    }

    static int GetInteger(string message) {
       Console.WriteLine(message);
       return Convert.ToInt32(Console.ReadLine());
    }

    static int RemainingRoastPotato(int roastPotatoes, int brusselSprouts) {
       roastPotatoes = roastPotatoes + 1;
       int roastPotatoQuarters = roastPotatoes * 4;
       Console.WriteLine(roastPotatoQuarters);
       roastPotatoQuarters = roastPotatoQuarters % brusselSprouts;
       // If its negative, display 0 as minimum
       return Math.Max(0, roastPotatoQuarters);
     }
  }
}
