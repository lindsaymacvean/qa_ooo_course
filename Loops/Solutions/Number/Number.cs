using System;

namespace FlowControl {
  public class Number {
    public static void Main() {
      long result = 1, maxValue = 9999999999;
      for (int i = 1; i < 64; i++)
      {
        result *= 2;
        if (result > maxValue)
        {
          break;
        }
        Console.Write(i.ToString().PadLeft(2) + "\t");
        Console.WriteLine(result.ToString().PadLeft(10));

        // or FYI
        //Console.WriteLine(string.Format("{0,2}{1}{2,10}", i, "\t", result));


      }
    }
  }
}
