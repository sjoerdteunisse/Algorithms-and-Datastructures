using System;

namespace ADS.Core.Recursion
{
    public class Printer
    {
        /// <summary>
        /// Head recursion, execute and keep on stack then do the work
        /// </summary>
        /// <param name="n"></param>
        public static void PrintAsc(int n)
        {
            if (n == 0)
                return;

            PrintAsc(n - 1);
            Console.WriteLine(n);
        }

        /// <summary>
        /// tail recursion, execute and do work, compiler optimized.
        /// </summary>
        /// <param name="n"></param>
        public static void PrintDsc(int n)
        {
            if (n == 0)
                return;

            Console.WriteLine(n);
            PrintDsc(n - 1);
        }
    }
}
