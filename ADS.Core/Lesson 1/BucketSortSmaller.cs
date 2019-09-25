using System.Linq;

namespace ADS.Core.Lesson_1
{
    class BucketSortSmaller
    {
        //Time O(N+K) N = array size, en K is bucket count
        // N>K Then time = O(n)
        public static int[] Run(int[] array)
        {
            int m = array.Max();
            int n = array.Length;
            int[][] buckets = new int[n][];

            // Place the contents of the given array into the buckets, insertion sort
            foreach (int i in array)
            {
                int index = (i * n) / (m + 1);
                buckets[index] = (buckets[index] ?? Enumerable.Empty<int>()).Concat(Enumerable.Repeat(i, 1))
                    .ToArray();
                for (int j = 1; j < buckets[index].Length; j++)
                {
                    int key = buckets[index][j];
                    int k = (j - 1);
                    while (k >= 0 && buckets[index][k] > key)
                    {
                        buckets[index][k + 1] = buckets[index][k];
                        k--;
                    }

                    buckets[index][k + 1] = key;
                }
            }

            // Fill the final bucket
            int pos = 0;
            int[] finalBucket = new int[n];
            foreach (var bucket in buckets)
            {
                if (bucket != null)
                {
                    foreach (int i in bucket)
                    {
                        finalBucket[pos] = i;
                        pos++;
                    }
                }
            }

            return finalBucket;
        }
    }
}
