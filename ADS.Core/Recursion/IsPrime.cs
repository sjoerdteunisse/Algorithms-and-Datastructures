using System;

namespace ADS.Core.Recursion
{
    public class IsPrime
    {
        public static void Execute(int n, int ct=0)
        {

            if (ct == 1)
            {
                Console.WriteLine("Input is prime");
            }
            else
            {
                //terminator
                if (n % ct == 0)
                    return;
                
                Execute(n, ct - 1);//calling the function checkForPrime itself recursively
            }
        }
    }
}
