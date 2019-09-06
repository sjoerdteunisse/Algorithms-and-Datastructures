using System;
using System.Diagnostics;

namespace ADS.Core.Lesson_1
{
    public class ForLoopProblem
    {
        public static void Problem()
        {
            var stopwatch = new Stopwatch();

            //for (var x = 0; x < 100; x++)
            //{

            const int n = 2000;

            stopwatch.Start();
            long sumA = 0;

            //O(n) 
            //For n length of N execute O(1) body times N
            for (var i = 0; i < n; i++)
            {
                sumA++;
            }
            //N length

            stopwatch.Stop();
            Console.WriteLine($"1: execution took: {stopwatch.ElapsedMilliseconds}ms");
            stopwatch.Restart();


            //O(n^2)
            long sumB = 0;
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    sumB++;
                }
            }
            //N + N = N^2

            stopwatch.Stop();
            Console.WriteLine($"2: execution took: {stopwatch.ElapsedMilliseconds}ms");
            stopwatch.Restart();

            // c 
            long sumC = 0;

            //This example is : O (n^3) as complexity is met within constant multiplication
            // O(n ^ c): Time complexity of nested loops is-
            // equal to the number of times the innermost statement is executed.
            // For example the following sample loops have O(n^2) time complexity
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n * n; j++)
                {
                    sumC++;
                }
            }
            // N * N > N^2 + N^1 = N^3

            stopwatch.Stop();
            Console.WriteLine($"3: execution took: {stopwatch.ElapsedMilliseconds}ms");
            stopwatch.Restart();

            //O(n^2)
            long sumD = 0;
            for (var i = 0; i < n; i++) //n1
            {
                for (var j = 0; j < i; j++) //n1
                {
                    sumD++;
                }
            }
            //n1+n1 = N^2

            stopwatch.Stop();
            Console.WriteLine($"4: execution took: {stopwatch.ElapsedMilliseconds}ms");
            stopwatch.Restart();


            //}
            //}
        }
    }
}
