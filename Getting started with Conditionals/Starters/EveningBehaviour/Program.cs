using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveningBehaviour {
  class Program {
    
    private static bool summerTime = true;
    private static bool sunnyEvening = true;
    private static bool isWeekend = true;

    static void Main(string[] args) {
        
        if (!IsWeekend()) {
            if (IsSummerTime()) {
                TakeShower();
                if (sunnyEvening)
                    Eat("outside");
                else
                    Eat("inside");
                DoActivity("Gardening");
            }

            if (!IsSummerTime()) {
                Eat("inside");
                if (sunnyEvening)
                    Read("Paper", "summerhouse");
                DoActivity("Paperwork");
                TakeShower();
            }

            Read("book", "bed");
        }

        if (IsWeekend()) {
            string[] activity = {"boating", "cleaning", "polishing"};
            Random rnd = new Random();
            DoActivity(activity[rnd.Next(0, activity.Length)]);
            DoActivity(activity[rnd.Next(0, activity.Length)]);
            DoActivity(activity[rnd.Next(0, activity.Length)]);
        }

        TeethClean();
        Console.ReadLine();

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
    public static bool IsWeekend() {
      return isWeekend;
    }
    
    public static void Eat(string where) {
      Console.WriteLine("Eating {0}", where);
    }
    public static void DoActivity(string activity) {
      Console.WriteLine("doing {0}", activity);
    }
    public static void TakeShower() {
      Console.WriteLine("taking  shower");
    }
    public static void Read(string what, string where) {
      Console.WriteLine("Reading {0} in the {1}", what, where);
    }

    public static void TeethClean() {
      Console.WriteLine("Cleaning teeth");
    }
  }
}
