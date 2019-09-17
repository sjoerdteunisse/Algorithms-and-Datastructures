using System;
using System.Diagnostics;

namespace ADS.Core.Lesson_1
{
    public class Solution3
    {
        public void Fast(int length)
        {
            Console.WriteLine("fast");

            for (int i = 0; i < 10; i++)
            {
                var stopwatch = new Stopwatch();

                stopwatch.Start();
                double sum = 0;  //Space is o(1)

                //65536 ^ 256
                double exponential = Math.Pow(65536, 256);  //Space is o(1)

                sum = 50 * length * exponential; //Space is o(1)

                stopwatch.Stop();
                Console.WriteLine($"execution took {stopwatch.ElapsedTicks}ticks");
            }

        }

        public void Slow(int length)
        {
            Console.WriteLine("slow");

            for (int z = 0; z < 10; z++)
            {
                var stopwatch = new Stopwatch();

                stopwatch.Start();
                double sum = 0;  //Space is o(1)
                double exponential = 0; //Space is o(1)
                for (var i = 0; i < 50; i++)  //I Space is O(1)
                    exponential += Math.Pow(65536, 256); //Space is O(1) – Max Int size.

                for (var i = 0; i < length; i++) // Space is O(1)
                    sum += exponential; //Space is O(1)

                stopwatch.Stop();
                Console.WriteLine($"execution took {stopwatch.ElapsedTicks}ticks");
            }
        }
    }
}
