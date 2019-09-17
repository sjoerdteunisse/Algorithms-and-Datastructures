namespace ADS.Core.Recursion
{
    public class DigitCounter
    {
        /// <summary>
        /// O(n) memory
        /// o(n) speed - length of number;
        /// </summary>
        /// <param name="n">Digits</param>
        /// <param name="count">hidden parameter for counting</param>
        /// <returns></returns>
        public static int Execute(int n, int count = 0)
        {
            if (n == 0)
                return count;

            return Execute(n/10, count+1);
        }
    }
}
