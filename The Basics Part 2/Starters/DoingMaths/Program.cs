using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoingMaths {
  class Program {
    static void Main(string[] args) {
      // Run the code immediately to see what we have prepared for you
      // clearly there is work to do

      // Carry out the tasks below 
      // Run the code (Ctrl-F5) after each Task 
      int number = 5;
      Console.WriteLine("\nInitial Value: " + number );
      
      // Task 1 
      // - double it using the '*' operator
      // - now double it again using the '*=' operator
      number = number * 2;
      number *= 2;
      Console.WriteLine("\n1. After doubling it twice: " + number );

      // Task 2 
      // - add 3 to it using the '+' operator
      // - now add 3 to it using the '+=' operator
      number = number + 3;
      number += 3;
      Console.WriteLine("\n2. After adding 3 twice: " + number);

      // Task 3 
      // - subtract 12 from it using an appropriate 'compound' operator
      number -= 12;
      Console.WriteLine("\n3. After subtracting 12: " + number);

      // Task 4 
      // - divide the number (value should currently be 14) by 3
      // - what do you think the answer should be? -->
      number = number / 3;
      Console.WriteLine("\n4. After dividing by 3: " + number);

      // Task 5
      // - write 4 different statements that all do the same thing
      // - namely 'add 1 to the number'
      number++;
      number += 1;
      number = number + 1;
      ++number; 
      Console.WriteLine("\n5. After adding 1 four times: " + number);

      // Task 6 decrement by 1 the value of number
      --number;
      Console.WriteLine("\n6. After decrementing once: " + number);

      // Task 7 put the remainder when dividing by 3 into 'remainder'
      int remainder = 0;
      remainder = number % 3;
      Console.WriteLine("\n7. Remainder when dividing by 3 is :" + remainder);


      // Task 8 - after uncommenting the Console.WriteLine(..) below
      // decide what it will print
      /*int a = 2, b = 3, c = 5;
      double d1, d2, d3, d4;

      d1 = a + b * c / 2;
      d2 = (a + b * c) / 2;
      d3 = (a + b) * c / 2;
      d4 = (a + b) * (c / 2);
      Console.WriteLine("\n8. Values: "+d1+":"+d2+":"+d3+":"+d4);
      // Type your answers here--> 9, 8, 12, 12
      //*/

      // Task 9
      int p, q;
      p = 10;
      q = 10;
      p += q++;
      // Decide what the next line will print
      Console.WriteLine("\n9. Result is: " + (p + q)); 
      // Answer--> 31

      // Task 10
      double d7 = 4.3, d8 = 34.7;
      // Make the following statement compile
      int truncatedSum = (int)(d7 + d8);
      Console.WriteLine("\n10. Sum is " + truncatedSum);


      // Task 11
      //Console.WriteLine("\n11.");
      // Decide what the following 4 lines will print
      // The 4th one might surprise you
      Console.WriteLine("fred" + 3 + 4);  // Answer--> fred34
      Console.WriteLine(3 + 4 + "fred");  // Answer--> 7fred
      Console.WriteLine("" + 3 + 4);      // Answer--> 34
      Console.WriteLine(3 + ' ' + 4);     // Answer--> 7
      char space = (char)32;
      Console.WriteLine("this is a space"+space+".");
      
      // When you have time ...
      // Change the code of 'Task 8' to ensure floating point 
      // arithmetic is performed each time
      int a = 2, b = 3, c = 5;
      float d1, d2, d3, d4;

      d1 = (float)(a + b * c / 2.0);
      d2 = (float)((a + b * c) / 2.0);
      d3 = (float)((a + b) * c / 2.0);
      d4 = (float)((a + b) * (c / 2.0));
      Console.WriteLine("\n8. Values: "+d1+":"+d2+":"+d3+":"+d4);
      // Type your answers here--> 9.5, 8.5, 12.5, 12.5
      
    }
  }
}
