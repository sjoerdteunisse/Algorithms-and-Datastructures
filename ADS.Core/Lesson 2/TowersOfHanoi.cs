using System;

namespace ADS.Core.Lesson_2
{
    public class TowersOfHanoi
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="disks"></param>
        /// <param name="startPeg"></param>
        /// <param name="endPeg"></param>
        /// <param name="tempPeg"></param>

        //http://www.iitk.ac.in/esc101/08Jan/lecnotes/lecture32.pdf

        //Time
        //O(2^n)
        //Time complexity is O(2^n) or O(a^n)
        // where a is a constant greater than 1.
        //So it has exponential time complexity.For single increase in problem size the time
        //required is double the previous one.This is computationally very expensive.Most of the
        //    recursive programs takes exponential time that is why it is very hard to write them
        //    iteratively.

        //Space
        //Space for parameter for each call is independent of n i.e., constant. Let it be k .
        //When we do the 2nd recursive call 1st recursive call is over.So, we can reuse the space of
        //1st call for 2nd call.Hence ,
        //T(n) = T(n - 1) + k
        //    T(0) = k
        //    T(1) = 2k
        //    T(2) = 3k
        //    T(3) = 4k
        //
        //    stack size size grows for N length of problem with recursion
        //    So the space complexity is O(n). 

        //STACK:
        //INPUT: disks = 3, start= a, end = c, temp = b

        public static void Solve(int disks, char startPeg, char endPeg, char tempPeg)
        {
            if (disks > 0)
            {
                Solve(disks - 1, startPeg, tempPeg, endPeg);
                Console.WriteLine("Move disk from " + startPeg + ' ' + endPeg);
                Solve(disks - 1, tempPeg, endPeg, startPeg);
            }
        }
    }
}
