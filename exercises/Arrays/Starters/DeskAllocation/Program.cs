using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeskAllocation
{
    class Program
    {
        public static string[,] deskNames;

        public static string[] names =
        {"Amy","Ben","Carly","Danesha","Evy","Faroukh",
            "Greg","Heather","Ivy","Jaz","Keith","Monica",
            "Nick"
        }; // 13 names!

        public static void Main(string[] args)
        {
            // initialise and size the array at 3 rows * 4 columns
            deskNames = new string[5,1];
            AllocateAllDesks();
            DisplayDeskMap();


            SearchDesks("Jaz");
            SearchDesks("Nick");

            Console.WriteLine("Who do you want to search for?");
            string name = Console.ReadLine();
            SearchDesks(name);
            Console.ReadLine();
        }

        public static void AllocateAllDesks()
        {
            foreach (string name in names)
            {
                AllocateDesk(name);
            }
        }

        // called from AllocateAllDesks()
        public static void AllocateDesk(string name)
        {
            Func<int, int, int> callback = delegate(int row, int col)
            {
                if (deskNames[row, col] == null)
                {
                    deskNames[row, col] = name;
                    Console.WriteLine(name + " was assigned to desk " + row + ", " + col);
                    return -1;
                }
                //Console.WriteLine("The desk was already assigned to " + deskNames[row, col]);
                return 0;
            };
            LoopDesks(callback);
        }

        public static void DisplayDeskMap()
        {
            string rowNames = "|";
            Func<int, int, int> callback = delegate(int row, int col)
            {
                rowNames += deskNames[row, col].PadLeft(8) + "\t|";
                if (col == deskNames.GetUpperBound(1))
                {
                    Console.WriteLine(rowNames);
                    rowNames = "|";
                }
                return 0;
            };
            LoopDesks(callback);
        }

        public static void SearchDesks(string name)
        {
            Func<int, int, int> callback = delegate (int row, int col)
            {
                if (deskNames[row, col] == name)
                {
                    Console.WriteLine("{0} is located at desk {1}, {2}", name, row, col);
                    return 1;
                }
                else if (col == deskNames.GetUpperBound(1) && row == deskNames.GetUpperBound(0))
                {
                    Console.WriteLine("Could not find {0} at any of the desks", name);
                    return -1;
                }
                return 0;
            };
            LoopDesks(callback);
        }

        public static void ClearAllDesks()
        {

        }

        // Decided to implement a method to implement an anonymous function within the loop
        public static void LoopDesks(Func<int, int, int> callBack)
        {
            row:  for (int row = 0; row <= deskNames.GetUpperBound(0); row++)
            {
                col: for (int col = 0; col <= deskNames.GetUpperBound(1); col++)
                {
                    int result = callBack(row, col);
                    if (result != 0)
                        return;
                }
            }
        }
    }
}
