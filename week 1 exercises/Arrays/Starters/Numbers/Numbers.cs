namespace Numbers
{
    using System;
    public class Numbers
    {

        public static void Main(String[] args)
        {


            // Create and initialise an array of 8 ints
            int[] intArray = new int[] { 1, 3, 5, 7, 2, 4, 6, 8 };

            // Go off and write the PrintNumbers method
            // THEN you can Invoke it from here 
            PrintNumbers(intArray);

            int numToFind = GetInteger("What number are you looking for?");

            // Ask the user to enter a number (and ensure that it is numeric)
            // Invoke your NumberFinder method and check 
            // the return value from it to see if the number was found 
            // printing out an appropriate message
            int indexPos = FindNumber(intArray, numToFind);
            if (indexPos >= 0)
                Console.WriteLine("Num {0} found at position {1}", numToFind, indexPos);
            else
                Console.WriteLine("Number {0} not found in list", numToFind);

            Console.ReadLine();
        }  // end of Main method

        private static int GetInteger(string message)
        {
            Console.WriteLine(message);
            string sVal = Console.ReadLine();
            int val;
            if (int.TryParse(sVal, out val))
                return val;
            else
            {
                Console.WriteLine("You need to enter a number\n");
                return GetInteger(message);
            }
        }

        private static int FindNumber(int[] intArray, int numToFind)
        {
            for (int i = 0; i <= intArray.GetUpperBound(0); i++)
            {
                if (intArray[i] == numToFind)
                    return i;
            }

            return -1;
        }

        // Write the PrintNumbers method
        private static void PrintNumbers(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            
        }
    }
}
