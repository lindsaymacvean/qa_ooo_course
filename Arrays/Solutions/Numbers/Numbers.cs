using System;
namespace Numbers {
  
  public class Numbers {

    public static void Main(String[] args) {

      // Create and initialise an array of 8 ints
      int[] myNumbers = new int[] { 1, 3, 5, 2, 4, 6, 8 };
      // Invoke the PrintNumbers method (after writing it!)
      PrintNumbers(myNumbers);

      // Ask the user to enter a number (and ensure that it is numeric)
      // Invoke your NumberFinder method and check 
      // the return value from it to see if the number was found 
      // printing out an appropriate message
      int searchNum = GetInteger("Enter the number you'd like to search for: ");
      if (searchNum != 0)
      {
        int result = NumberFinder(myNumbers, searchNum);
        if (result != -1)
        {
          Console.WriteLine("Number {0} found at position {1}", searchNum, result + 1);
        }
        else
        {
          Console.WriteLine("Number {0} not found in list", searchNum);
        }
      }
      Console.ReadLine();

    }

    public static void PrintNumbers(int[] numbers) {
      foreach (int num in numbers)
      {
        Console.WriteLine(num);
      }
      Console.WriteLine();
    }

    public static int NumberFinder(int[] numbers, int numToFind) {

      for (int index = 0; index < numbers.Length; index++)
      {
        if (numbers[index] == numToFind)
        {
          return index;
        }
      }
      return -1;
    }

    static int GetInteger(string message) {
      Console.WriteLine(message);
      string sVal = Console.ReadLine();
      int val = 0;
      int.TryParse(sVal, out val);
      return val;
    }

  }

}