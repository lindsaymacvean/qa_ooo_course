using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeapYearAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What year is it?");
            int year = Convert.ToInt32(Console.ReadLine());
            if (IsLeapYear(year))
                Console.WriteLine("It's a leap year");
            else
                Console.WriteLine("It's not a leap year\n");
            // implement IsLeapYear so that the output from this 4 line test
            // produces False, False, True, True
            Console.WriteLine("1900 - {0}", IsLeapYear(1900));
            Console.WriteLine("2014 - {0}", IsLeapYear(2014));

            Console.WriteLine("2012 - {0}", IsLeapYear(2012));
            Console.WriteLine("2000 - {0}", IsLeapYear(2000));


            Console.ReadLine();

        }


        static bool IsLeapYear(int year)
        {
            /* There is a leap year every year whose number is 
             * perfectly divisible by four - except for years 
             * which are both divisible by 100 and not divisible by 400.
             */
            
            if ((year % 100) == 0 && (year % 400) != 0)
                return false;
            if ((year % 4) == 0)
                return true;
            return false;
        }




    }
}
