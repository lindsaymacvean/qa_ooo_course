using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeapYearAlgorithm {
  class Program {
    static void Main(string[] args) {
      // implement IsLeapYear so that the output from this 4 line
      // test produces False, False, True, True
      Console.WriteLine("1900 - {0}", IsLeapYear(1900));
      Console.WriteLine("2014 - {0}", IsLeapYear(2014));

      Console.WriteLine("2012 - {0}", IsLeapYear(2012));
      Console.WriteLine("2000 - {0}", IsLeapYear(2000));

    }


    static bool IsLeapYear(int year) {

      if (year % 4 != 0) return false; // not divisible by 4

      if (year % 100 != 0) return true; // is divisble by 4 but not 100

      return (year % 400 == 0); // divisible by 4 and 100 and 400 then 'true'  
      
    }

    static bool IsLeapYearAltV1(int year) {

      bool divBy4, notDivBy100, divBy400;
      
      divBy4 = (year % 4 == 0);
      notDivBy100 = (year % 100 != 0);
      divBy400 = (year % 400 == 0);


      return divBy4 && (divBy400 || notDivBy100);

    }

    static bool IsLeapYearAltV2(int year) {

      if (year % 4 == 0)
        if (year % 100 != 0 || year % 400 == 0)
          return true;

      return false;

    }

    static bool IsLeapYearAltV3(int year) {

      // not like this!!

      return year % 4 != 0 ?  false : 
             year % 100 != 0 ? true : 
             year % 400 == 0 ? true : false; 

    }
    
    static bool IsLeapYearAltV4(int year) {


      if (year % 4 != 0)
      {
        return false;
      }
      else
      {
        if (year % 100 != 0)
        {
          return true;
        }
        else
        {
          if (year % 400 == 0)
          {
            return true;
          }
          else
          {
            return false;
          }
        }
      }
      
    }

  }
}
