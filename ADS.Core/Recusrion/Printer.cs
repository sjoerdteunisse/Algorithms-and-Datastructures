using System;
using System.Collections.Generic;
using System.Text;

namespace ADS.Core.Recusrion
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
            else
                Console.WriteLine(n);

            PrintDsc(n - 1);
        }
    }
}
