using System;

namespace FlowControl {
    public class Number {
        public static void Main() {
            long result = 1, maxValue = 999999999L;
            for (int i=1; i < 64; i ++)
            {
                result = result * 2;
                if (result > maxValue)
                {
                    break;
                }
                PrintFormatted(result, i);
            }

            Console.ReadLine();

        }

        private static void PrintFormatted(long result, int i)
        {
            Console.Write(i.ToString().PadLeft(2) + "\t");
            Console.WriteLine(result.ToString().PadLeft(10));
        }
    }
}
