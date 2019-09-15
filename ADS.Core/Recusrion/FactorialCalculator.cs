using System;

namespace ADS.Core.Recusrion
{
    public class FactorialCalculator
    {
        public static int Execute(int n)
        {
            if (n == 0)
                return 1;

            return n *= Execute(n - 1);
        }
    }
}
