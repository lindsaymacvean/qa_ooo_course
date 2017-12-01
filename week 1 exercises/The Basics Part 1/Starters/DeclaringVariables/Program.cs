using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeclaringVariables {
  class Program {

    static void Main(string[] args) {
      Console.WriteLine("Hello World!");

      // Task 1
      // Declare a variable of type int call it 'age'. Do not intiialise it.
      int age;

      // Task 2 
      // Declare but again do not initialise, in 1 statement only
      // 2 variables of type int to store 'my age' and 'your age'
      int myAge, yourAge;

      // Task 3
      // Declare in one statement only, 2 ints called 'hisAge' and 'herAge'
      // Initialise 'hisAge' to a suitable value AT THE POINT OF DECLARATION
      int hisAge = 4, herAge;

      // Task 4
      // Try and display ('cw' Tab-Tab) 'herAge'. 
      // It will not compile, read the error message, it is not initialised
      //Console.WriteLine("\t\t"+herAge);

      // Task 5
      // Comment out the line just coded above, and now initialise 'herAge' 
      // here and try displaying it again. Check the project 'builds' Ctrl-Shift-B
      herAge = 5;

      // Task 6
      // After each description below declare variables of the right type 
      // with a sensible name and then initialise them with sensible values 
      // based on the description

      // The average number of children that 100 random families might have
      int averageAge = 1;
      
      // The probability of you passing a serious C# exam today
      decimal probabilityPass = 0.2M;
      
      // The amount of money you would have if you won exactly £1Billion  
      // on the lottery for 5 successive weeks
      decimal winnings = 5 * 18 * (decimal)Math.Pow(10, 9);
      
      // Your last name
      string lastName = "macvean";
      
      // The first character of your first name
      //           ---- 
      char firstCharFirstName = 'l';
      
      // The price of a litre of milk
      decimal priceLitreMilk = 0.95M;

      // Whether you had a good breakfast or not today
      bool goodBreakfast = true;
      
      // Feel free to display any of these values on the Console
      // but typing as little as possible in doing so!! (7 keystokes per line?)
      Console.WriteLine("");
      
      // Task 7
      // Ensure you can find the icons on the toolbar that enable you to
      // 'comment out' & 'uncomment' a single line. Practice NOW.
      // Done
      

      // Task 8
      // Write a 'block' multiline comment /* etc
      // that comments out the whole of the content of this 'Main' method  
      /*
       * This was generally easy. Discovered that decimal can actually handle more than 2 decimal places
       */
      
    
    }
  }
}
