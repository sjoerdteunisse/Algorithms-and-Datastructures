using System;

namespace ADS.Core.Recusrion
{
    public class DigitCounter
    {
        public static int Execute(int n, int count = 0)
        {
            if (n == 0)
                return count;

            return Execute(n/10, count+1);
        }
    }
}
