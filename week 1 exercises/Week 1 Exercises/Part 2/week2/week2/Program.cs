using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Looping
             * Write a while loop that prints out pairs of numbers that show the current value of n 
             * and the value of n + 10 as long as n is less than 10. */
            int n = 0;
            while (n < 10)
            {
                Console.WriteLine("n is {0} and n+10 is {1}", n, n + 10);
                n++;
            }

            /* Then, write a while loop that prints out pairs of numbers that show n and 2n as long as n is less than 10.
             * You don't need to use the Math.pow function for this, just base it on the previous value and multiply it by 2.
             * Remember how scoping works when saving a value between one loop and the next. */
            n = 0;
            int e = 1;
            while (n < 10)
            {
                Console.WriteLine("n is {0} and 2^n is {1}", n, e);
                e = 2 * e;
                n++;
            }

            // Rewrite these two loops using a for loop.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("n is {0} and n+10 is {1}", i, i + 10);
            }

            e = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("n is {0} and 2^n is {1}", i, e);
                e = 2 * e;
            }

            // Which do you prefer?
            // I always prefer the for loops

            /* Conditionals
            Write an if statement that is based on a number between 1 and 7 prints out if today is a week day or a weekend. */
            int day = 7;
            weekdayOrWeekend(day);

            // Now rewrite this as a switch statement.
            switch (day)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("It's a weekday.");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("It's the weekend.");
                    break;
                default:
                    break;
            }

            /*  If you don't use the break keyword in a switch statement, 
             *  the execution continues onto the next case regardless of whether it applied. 
             *  Can you use this to make your switch statement simpler? */

            /* Write a loop which goes from 1 to 7 and prints out “today” if it’s a 
             * week day(1 – 5) or “weekend” if it’s a Saturday or Sunday(6, 7) */

            for (int i = 1; i < 8; i++)
            {
                weekdayOrWeekend(i);
            }

            Console.ReadLine();
        }

        private static void weekdayOrWeekend(int day)
        {
            if (day < 6)
                Console.WriteLine("It's a weekday.");
            else if (day > 5)
                Console.WriteLine("It's the weekend.");
        }
    }
}
