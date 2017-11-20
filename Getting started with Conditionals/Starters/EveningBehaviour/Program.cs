using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveningBehaviour {
  class Program {
    
    private static bool summerTime = false;
    private static bool sunnyEvening = false;

    static void Main(string[] args) {
      

    }


    #region "Methods to be called"
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
    #endregion
  }
}
