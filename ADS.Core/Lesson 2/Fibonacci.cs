using System;

namespace ADS.Core.Lesson_2
{
    public class Fibonacci
    {
        //Time: O(2^n)
        //Storage O(n) -> stack size increases, will eventually break max size.
        private static int ExecuteRecursive(int n)
        {
            if (n < 2)
                return n;

            //n -1 + n-2 = result
            //1 1 2 3 5 8 13 21 34 55 89 144 233 377 610 987 1597 2584 4181...
            return ExecuteRecursive(n - 1) + ExecuteRecursive(n - 2);
        }

        /// <summary>
        /// Fibbonaci recursively, timecomplexity: O(n), spacecomplexity: O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int FibbAsFor(int n)
        {
            if (n < 2)
                return n;

            //keep track of previous
            var prev = 0;
            //keep track of next
            var next = 1;
            //iterator from 1 till n
            for (var i = 1; i < n; i++)
            {
                // 0+1 = 1, 1+1 = 2, 2+1 = 3, 3+2 = 5, 5 + 3 = 8, 8+5= 13
                var sum = prev + next;
                Console.WriteLine($"sum = {sum} prev = {prev} next = {next}");
                prev = next;
                next = sum;
            }

            return next;
        }
    }
}
