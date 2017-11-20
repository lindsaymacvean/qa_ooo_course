using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveningBehaviour {
  class Program {
    
    private static bool summerTime = true;
    private static bool sunnyEvening = true;

    static void Main(string[] args) {

        if (summerTime)
            {
                TakeShower();
                if (sunnyEvening)
                    Eat("outside");
                else
                    Eat("inside");
                DoGardening();
            }

        if (!summerTime)
            {
                Eat("inside");
                if (sunnyEvening)
                    ReadPaperinSummerHouse();
                DoPaperWork();
                TakeShower();
            }
        ReadBookInBed();
        Console.ReadLine();
        Environment.Exit(0);

            /* His behaviour varies primarily by whether it is ‘summertime’ or not but he always ends his day by ‘reading in bed’.
    If it is ‘summertime’ he ‘takes a shower’ the moment he arrives home.
    If it is also ‘a sunny evening’ he ‘eats outside’ otherwise he ‘eats inside’.
    After eating he then ‘does some gardening’.
    When it isn’t the summertime the evening starts by ‘eating inside’.
    Then if it’s a ‘sunny evening’ he ‘reads the paper in the summerhouse’.
    Then he always ‘does a little paperwork’ before taking a late ‘shower’. */
        }


    public static bool IsSummerTime() {
      return summerTime;
    }
    public static bool IsSunnyEvening() {
      return sunnyEvening;
    }
    
    public static void Eat(string where) {
      Console.WriteLine("Eating {0}", where);

    }
    public static void DoGardening() {
      Console.WriteLine("doing gardening");
    }
    public static void DoPaperWork() {
      Console.WriteLine("doing paperWork");
    }
    public static void TakeShower() {
      Console.WriteLine("taking  shower");
    }
    public static void ReadPaperinSummerHouse() {
      Console.WriteLine("Reading the paper in the summerhouse");
    }
    public static void ReadBookInBed() {
      Console.WriteLine("Reading in bed");
    }
  }
}
