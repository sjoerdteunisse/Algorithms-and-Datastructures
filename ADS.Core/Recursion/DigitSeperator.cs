﻿using System;

namespace ADS.Core.Recursion
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
