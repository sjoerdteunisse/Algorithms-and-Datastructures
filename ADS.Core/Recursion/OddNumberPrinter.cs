using System;

namespace ADS.Core.Recursion
{
    public class OddNumberPrinter
    {
        public static void Execute(int tillN)
        {
            if (tillN == 0)
                return;

            if (tillN % 2 == 0)
                Console.WriteLine(tillN);

            Execute(tillN - 1);
        }

        public static void EvenExecute(int tillN)
        {
            if (tillN == 0)
                return;

            if (tillN % 2 == 1)
                Console.WriteLine(tillN);

            Execute(tillN - 1);
        }
    }
}
