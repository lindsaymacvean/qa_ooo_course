using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoingLunch {
  class Program {
    static void Main(string[] args) {

      Console.WriteLine("What main dish would you like?");
      string mainCourse = Console.ReadLine();

      //Console.WriteLine("How many roast potatoes?");
      //string sRoasties = Console.ReadLine();
      //int roastCount = Convert.ToInt32(sRoasties);
      
      int roastCount = GetInteger("How many roast potatoes?");

      //Console.WriteLine("How many brussel sprouts?");
      //string sBrussles = Console.ReadLine();
      //int brusselCount = Convert.ToInt32(sBrussles);
      
      int brusselCount = GetInteger("How many brussel sprouts?");

      //Console.WriteLine("Hello, your lunch is " + mainCourse);
      //Console.WriteLine("Hello, your lunch is {0}", mainCourse);
      
      Console.WriteLine("Hello, your lunch is {0} with {1} roast potatoes and {2} brussel sprouts", 
                                                      mainCourse, roastCount, brusselCount);

      Console.WriteLine("After gaining one more potato, he will have {0} roast quarters left over",Math.Max((roastCount+1) * 4 - brusselCount, 0));

      
    }
    private static int GetInteger(string message) {
      Console.WriteLine(message);
      
      //string sVal = Console.ReadLine();
      //int val = Convert.ToInt32(sVal);
      //return val;

      return Convert.ToInt32(Console.ReadLine());
    }
  }
}
