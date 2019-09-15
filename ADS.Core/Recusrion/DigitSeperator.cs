using System;
using System.Collections.Generic;
using System.Text;

namespace ADS.Core.Recusrion
{
    public class DigitSeperator
    {
        public static void Execute(int n)
        {
            if (n < 10)
            {
                Console.WriteLine(n);
                return;
            }
            //devide by 10 and recall execute to print leading N number
            Execute(n / 10);
            
            //print remainder on stack
            Console.WriteLine(n % 10);
        }
    }
}
