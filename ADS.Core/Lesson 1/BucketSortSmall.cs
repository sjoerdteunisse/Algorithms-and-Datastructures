using System;
using System.Collections.Generic;
using System.Text;

namespace ADS.Core.Lesson_1
{
    class BucketSortSmall
    {
        //public static int[] bucketSort(int[] array)
        //{
        //    // Find boundaries
        //    int min = array[0];
        //    int max = min;
        //    for (int i = 1; i < array.length; i++)
        //        if (array[i] > max)
        //            max = array[i];
        //        else if (array[i] < min)
        //            min = array[i];

        //    // Fill buckets
        //    int[] bucket = new int[max - min + 1];
        //    for (int j = 0; j < array.length; j++)
        //        bucket[array[j] - min]++;

        //    // Empty buckets
        //    int l = 0;
        //    int[] result = new int[array.length];
        //    for (int k = 0; k < bucket.length; k++)
        //    {
        //        // assumption that fill uses memcpy and so has constant complexity
        //       // Array.Fill
        //        Array.Fill(result, l, l + bucket[k], k + min);
        //        l += bucket[k];
        //    }
        //    return result;
        //}

    }
}
