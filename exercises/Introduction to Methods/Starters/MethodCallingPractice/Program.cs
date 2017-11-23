using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodCallingPractice {
  class Program {
    static void Main(string[] args) {

      // We want you to practice calling 7 methods hidden away in a little 
      // 'region' at the bottom of the class called "The hidden girls"
      // You don't need to look in this region to see what the methods are 
      // called as we are going to tell you, well, give you a clue anyway.

      // Each method is a common girls name, one starts with 'A', one with 
      // 'B' etc up to letter 'G' so you should be able to find
      // them in the intellisense list easily, one of the 7 is overloaded.

      // We want you to call each in turn according to the following rules
      // (these are repeated down below, so you don't need to remember them)
      // If the method takes 1 parameter pass a literal value e.g(3) or ("Jane")
      // If it takes 2 parameters pass a literal then a variable e.g(3,x)
      // If it takes 3 parameters pass a literal, a variable, 
      // and an expression an example might be MethodName(3, x, x + 3);

      // If the method is overloaded (Intellisense will show 1 of 2 etc)
      // then you must invoke each version according to the rules above
      // If the method is not void (1st word in the Intellisense box!)
      // then you simply MUST catch what is returned and DISPLAY it.
      // Final rule, you must call at least one of the methods passing 
      // something 'narrower' than what is expected allowing a safe widening 
      // conversion to happen.

      // Each method will display on the Console a string (sentence) 
      // which uses the parameters you passed to that method.

      // Here are some predefined but uninitialised variables to save you a
      // few seconds, ADD OTHERS if you want.
      int i; long l; float f; double d; char c; string s; bool b;

      // start calling 'Alice', 'Beatrice' etc running your code regularly
      // feel free to write any lines of code you need before each call
      Alice();
      Beatrice(10);
      Catherine(100, l=2);
      //A widening happens here between an integer and a float
      Dashmi("Programmer", i=2, i*3.1f);
      Console.WriteLine(Eleanor("Dashmi", 3));
      Console.WriteLine(Eleanor("UK", s="Dashmi", 3-1));
      Console.WriteLine("Fiona is younger than 66: {0}", Convert.ToString(Fiona(25)));
      Console.WriteLine(Georgina('G', s="Harrison"));

      // remember 
      // 1st param - a literal
      // 2nd param - a variable
      // 3rd param an expression
      // CATCH and display any values returned
      // decide where the widening conversion happens
      // call both versions of the 1 method of the 7 that is overloaded
      // one method returns true/false, think of an appropriate display!
      WhenYouHaveTime();
    }



    private static void WhenYouHaveTime() {
      // This project has a class called Countries.
      // It contains 5 methods that each match a Country Name.
      // Call a few of them and display what they return
      // But what question are these values the answer to?
      Console.WriteLine("When you have time...");

      Console.WriteLine("\nChile - ");
      Console.WriteLine(Countries.Chile().ToString());
      Console.WriteLine("\nRussia - ");
      Console.WriteLine(Countries.Russia().ToString());
      Console.WriteLine("\nMongolia - ");
      Console.WriteLine(Countries.Mongolia().ToString());
      Console.WriteLine("\nZimbabwe - ");
      Console.WriteLine(Countries.Zimbabwe().ToString());
      Console.WriteLine("\nFinland - ");
      Console.WriteLine(Countries.Finland().ToString());
      
    }

    #region The 'Hidden' Girls

    private static void Alice() {
      Console.WriteLine("\nI am {0} and I know nothing", "Alice");
    }
    private static void Beatrice(int age) {
      Console.WriteLine("\nI am {0} and I am {1} years old", "Beatrice", age);
    }
    private static void Catherine(double height, long numPets) {
      Console.WriteLine("\nI am {0} and I am {1} metres tall and will have {2} pets if one was to die",
                       "Catherine", height, numPets - 1);
    }
    private static void Dashmi(string jobTitle, int numOfBuses, float miles) {
      Console.WriteLine("\nI am {0} working as a {1} {3} miles from home. I use {2} buses each day",
                    "Dashmi", jobTitle, numOfBuses, miles);
    }

    private static string Eleanor(string bestFriend, int numSisters) {
      return string.Format("\n{0} best friend is called {1} and she has {2} sisters",
                        "Eleanor's", bestFriend, numSisters);
    }
    private static string Eleanor(string countryOfBirth, string bestFriend, int numSisters) {
      return string.Format("\n{0} best friend is called {1}.\nShe has {2} sisters.\nShe was born in {3}.",
                        "Eleanor's", bestFriend, numSisters, countryOfBirth);
    }

    private static bool Fiona(int currentAge) {
      return 66 > currentAge;
    }

    private static string Georgina(char upperCase, string surname) {
      return "\nThe next Prime Minister is Miss " + upperCase + "." + surname;
    }
    #endregion
  }
}
