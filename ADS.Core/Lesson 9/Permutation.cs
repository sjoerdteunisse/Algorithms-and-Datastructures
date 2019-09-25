using System;
using System.Collections.Generic;
using System.Threading;

namespace ADS.Core.Lesson_9
{
    public class Permutation
    {
        private static int permutations = 0;
        public static int GetPermutationCount
        {
            get { return permutations; }
        }

        //public static void Permutations<E>(List<E> items, int start = 0)
        //{
        //    if (items.Count == start)
        //    {
        //        permutations++;

        //        for (int i = 0; i < items.Count; i++)
        //        {
        //            Console.WriteLine(items[i] + "; ");
        //        }
        //    }

        //    for (int i = 0; i < items.Count; i++)
        //    {
        //        List<E> tmp = new List<E>(items);
        //        Swap(tmp, start, i);
        //        Permutations(tmp, start + 1);
        //    }

        //}

       

        public static void Permutations<E>(List<E> items, int start =0)
        {
            if (start == items.Count)
            {
                permutations++;

                Console.Write("[ ");
                items.ForEach(delegate (E item)
                {
                    Console.Write(item + "; ");
                });
                Console.WriteLine("]");
            }
            for (int i = start; i < items.Count; i++)
            {
                List<E> tmp = new List<E>(items);
                Swap(tmp, start, i);
                Permutations(tmp, start + 1);
            }
        }
        private static void Swap<E>(List<E> items, int i, int j)
        {
            E tmp = items[i];
            items[i] = items[j];
            items[j] = tmp;
        }
    }
}
