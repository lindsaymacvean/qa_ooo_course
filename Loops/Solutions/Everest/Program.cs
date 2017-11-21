using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Everest {
  class Program {
    static void Main(string[] args) {
      double height = 8850;
      double growthRate = 0.000006893;
      int yearCount = 1000;

      for (int i = 0; i < yearCount; i++)
      {
        // height += (height * growthRate); or
        height *= (1 + growthRate);
      }
      Console.WriteLine("Height of Everest in 1000 years will be {0}", height);

      //// enhancement
      //double yearlyGrowth = height * growthRate;
      //// remove loop completely
      //height += yearlyGrowth * yearCount;
      //Console.WriteLine("Height of Everest in 1000 years will be {0}", height);

    }
  }
}
