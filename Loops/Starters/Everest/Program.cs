using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Everest {
  class Program {
    static void Main(string[] args) {
        /*Mount Everest is currently 8850 metres high.  
            * Plate tectonics are currently causing the mountain to grow by a yearly factor of 0.000006893 
            * (that equates to about 6cm a year) – that is a factor not a percentage. 
            * What will the height of the mountain be in 1000 years from now if it grows at the same rate (compounded)?

            Write a program to calculate this, using the field names given below:

            height = the initial height of the mountain (8850 metres)
            growthRate = the yearly growth factor, 0.000006893
            yearCount = the number of years the mountain grows for (1000 years)
            Check your answer to make sure that it is sensible – should be a bit over 8900 metres.

            Enhancement – make a small change to your code to calculate what the height will be if the growth is 
            not compounded i.e the growth it makes in Year 1 is then the growth it makes each year 
            (it will grow by about 20cms less)
        */

        double height = 8850.0;
        double growthRate = 0.00000689;
        int yearCount = 1000;

        Console.WriteLine("|{0}|{1}", "Year".PadLeft(4), "Height".PadLeft(20));
            Console.ReadLine();
        for (int i = 0; i < yearCount; i++) {
            Console.WriteLine("|{0}|{1}|", i.ToString().PadLeft(4), 
                string.Format("{0:0.000000000000000##}", height).PadLeft(20));
            height = height + height * growthRate;
        }

        Console.WriteLine("Height of Everest in 1000 years will be {0}M", height);
        Console.ReadLine();
    }
  }
}
