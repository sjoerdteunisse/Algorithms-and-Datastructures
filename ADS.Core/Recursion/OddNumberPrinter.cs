using System;

namespace ADS.Core.Recursion
{
    public class OddNumberPrinter
    {

        //Even 2.4
        public static void ExecuteEven(int tillN)
        {
            if (tillN == 0)
                return;

            if (tillN % 2 == 0)
                Console.WriteLine(tillN);

            ExecuteEven(tillN - 1);
        }

        public static void ExecuteOdd(int tillN)
        {
            if (tillN == 0)
                return;

            if (tillN % 2 == 1)
                Console.WriteLine(tillN);

            ExecuteOdd(tillN - 1);
        }
    }
}