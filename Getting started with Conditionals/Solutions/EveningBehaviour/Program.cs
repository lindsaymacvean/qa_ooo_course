using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveningBehaviour {
  class Program {

    static bool summerTime = true;
    static bool sunnyEvening = true;
    static bool isWeekend = false;

    static void Main(string[] args) {
      if (IsWeekend())
      {
        Do("- having a lie in");
        Do("- watch sport on TV");
        Do("- go out for a meal");
      }
      else
      {
        if (IsSummerTime())
        {
          TakeShower();
          if (IsSunnyEvening())
          {
            Eat("outside");
          }
          else
          {
            Eat("inside");
          }
          Do("gardening");
        }
        else
        {
          Eat("inside");
          if (IsSunnyEvening())
          {
            Read("paper", "summerhouse");
          }
          Do("paperWork");
          TakeShower();
        }
        Read("book", "bed");
      }
    }


    #region "Methods to be called"
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
    //public static void DoGardening() {
    //  Console.WriteLine("Doing gardening");
    //}
    //public static void DoPaperWork() {
    //  Console.WriteLine("Doing paperwork");
    //}

    public static void Do(string activity) {
      Console.WriteLine("Doing {0}", activity);
    }
    public static void TakeShower() {
      Console.WriteLine("Taking  shower");
    }
    //public static void ReadPaperinSummerHouse() {
    //  Console.WriteLine("Reading paper in summerhouse");
    //}
    //public static void ReadBookInBed() {
    //  Console.WriteLine("Reading book in bed");
    //}

    public static void Read(string what, string where) {
      Console.WriteLine("Reading {0} in {1}",what,where);
    }
    #endregion
  }
}
