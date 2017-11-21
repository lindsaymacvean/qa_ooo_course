using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeapYearAlgorithm {
  class Program {
    static void Main(string[] args) {
      // implement IsLeapYear so that the output from this 4 line test
      // produces False, False, True, True
      Console.WriteLine("1900 - {0}", IsLeapYear(1900));
      Console.WriteLine("2014 - {0}", IsLeapYear(2014));

      Console.WriteLine("2012 - {0}", IsLeapYear(2012));
      Console.WriteLine("2000 - {0}", IsLeapYear(2000));

    }


    static bool IsLeapYear(int year) {

      return true;     // just to make it compile
      
    }

    
    

  }
}
