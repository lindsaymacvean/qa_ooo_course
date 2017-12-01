using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1900; i < 2017; i++)
            {
                if (IsLeapYear(i))
                    Console.WriteLine("{0} Leap year", i);
                else
                    Console.WriteLine("{0} Not a leap year", i);
            }

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
