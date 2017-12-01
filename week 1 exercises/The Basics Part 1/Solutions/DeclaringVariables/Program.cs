using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeclaringVariables {
  class Program {

    static void Main(string[] args) {
      /*
      // A number of tasks follow
      // Read them carefully and perform them sequentially
      // Do not worry about any 'green' underlines.
      // But correct any 'red' ones!
      // We recommend you delete comments as you go along.
      // (starting now with these 6 statements !! )

      // Task 1
      // Note how the 'SolutionName'/'ProjectName'/'NameSpace'
      // 'ClassName ('Program')'/'MethodName'(Main) all start with an uppercase character
      // Note though how the parameter of this Main method ('args') 
      // which is local to this method starts with a lowercase character
      // Ensure you stick to 'camelCasing' for all local variables you declare
      //                      X    X

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
      int hisAge = 21, herAge;

      // Task 4
      // Try and display ('cw' Tab-Tab) 'herAge'. 
      // It will not compile, read the error message, it is not initialised
      //Console.WriteLine(herAge);

      // Task 5
      // Comment out the line just coded above, and now initialise 'herAge' 
      // here and try displaying it again. Check the project 'builds' Ctrl-Shift-B
      herAge = 67;
      Console.WriteLine(herAge);

      // Task 6
      // After each description below declare variables of the right type 
      // with a sensible name and then initialise them with sensible values 
      // based on the description

      // The average number of children that 100 random families might have
      double aveNoChildren = 1.45;
      // The probability of you passing a serious C# exam today
      float probPassingToday = 0.000001F;
      // The amount of money you would have if you won exactly £1Billion  
      // on the lottery for 5 successive weeks
      long totalWinnings = 5000000000;
      // Your last name
      string lastName = "Flintstone";
      // The first character of your first name
      //           ---- 
      char firstInitial = 'F';
      // The price of a litre of milk
      decimal milkPrice = 0.67M;
      // Whether you had a good breakfast or not today
      bool hadDecentBreakfast = true;
      // Feel free to display any of these values on the Console
      // but typing as little as possible in doing so!!
      Console.WriteLine(aveNoChildren);
      Console.WriteLine(probPassingToday);
      Console.WriteLine(totalWinnings);
      Console.WriteLine(lastName);
      Console.WriteLine(firstInitial);
      Console.WriteLine(hadDecentBreakfast);
      
      // Task 7
      // Ensure you can find the icons on the toolbar that enable you to
      // 'comment out' & 'uncomment' a single line. Practice NOW.
      
      // Task 8
      // Write a 'block' multiline comment /* etc
      // that comments out the whole of the content of this 'Main' method  
      */

    }
  }
}
