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
            deskNames = new string[4,3];
            AllocateAllDesks("frontLeft");
            DisplayDeskMap();

            deskNames = new string[2,4];
            AllocateAllDesks("frontRight");
            DisplayDeskMap();

            deskNames = new string[5, 1];
            AllocateAllDesks("backLeft");
            DisplayDeskMap();

            deskNames = new string[2, 2];
            AllocateAllDesks("backRight");
            DisplayDeskMap();

            SearchDesks("Jaz");
            SearchDesks("Nick");

            Console.WriteLine("Who do you want to search for?");
            string name = Console.ReadLine();
            SearchDesks(name);
            Console.ReadLine();
        }

        public static void AllocateAllDesks(string direction)
        {
            foreach (string name in names)
            {
                AllocateDesk(name, direction);
            }
        }

        // called from AllocateAllDesks()
        public static void AllocateDesk(string name, string direction)
        {
            Func<int, int, int> callback = delegate(int row, int col)
            {
                if (deskNames[row, col] == null)
                {
                    deskNames[row, col] = name;
                    Console.WriteLine(name + " was assigned to desk " + row + ", " + col);
                    return -1;
                }
                //Console.WriteLine("The desk {0},{1} was already assigned to {2}", row, col, deskNames[row, col]);
                return 0;
            };

            if (direction == "frontRight")
                LoopDesksFromFrontRight(callback);
            if (direction == "frontLeft")
                LoopDesksFromFrontLeft(callback);
            if (direction == "backLeft")
                LoopDesksFromBackLeft(callback);
            if (direction == "backRight")
                LoopDesksFromBackRight(callback);
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
            LoopDesksFromFrontLeft(callback);
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
                    //Console.WriteLine("Could not find {0} at any of the desks", name);
                    return -1;
                }
                return 0;
            };
            LoopDesksFromFrontLeft(callback);
        }

        public static void ClearAllDesks()
        {

        }

        // Decided to implement a method to implement an anonymous function within the loop
        public static void LoopDesksFromFrontLeft(Func<int, int, int> callBack)
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

        public static void LoopDesksFromBackLeft(Func<int, int, int> callBack)
        {
            row: for (int row = deskNames.GetUpperBound(0); row >= 0; row--)
            {
                col: for (int col = 0; col <= deskNames.GetUpperBound(1); col++)
                {
                    int result = callBack(row, col);
                    if (result != 0)
                        return;
                }
            }
        }

        public static void LoopDesksFromFrontRight(Func<int, int, int> callBack)
        {
            row: for (int row = 0; row <= deskNames.GetUpperBound(0); row++)
            {
                col: for (int col = deskNames.GetUpperBound(1); col >= 0; col--)
                {
                    int result = callBack(row, col);
                    if (result != 0)
                        return;
                }
            }
        }

        public static void LoopDesksFromBackRight(Func<int, int, int> callBack)
        {
            row: for (int row = deskNames.GetUpperBound(0); row >= 0; row--)
            {
                col: for (int col = deskNames.GetUpperBound(1); col >= 0; col--)
                {
                    int result = callBack(row, col);
                    if (result != 0)
                        return;
                }
            }
        }
    }
}
