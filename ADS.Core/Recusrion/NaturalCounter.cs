using System;
using System.Collections.Generic;
using System.Text;

namespace ADS.Core.Recusrion
{
    public class NaturalCounter
    {
        /// <summary>
        /// add all N elements to each other. head recursion
        /// </summary>
        /// <param name="n"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public static int Execute(int n, int total =0)
        {
            
            if (n == 0)
                return total;

            total += n;
            Execute(n - 1, total);
            
            return total; 
        }
    }
}
