using System;
using System.Collections.Generic;
using System.Text;

namespace ADS.Core.Sorting
{
    /// <summary>
    /// Quick sort is a comparison sort, meaning that it can sort items of any type for which a "less-than" relation (formally, a total order) is defined.
    /// </summary>
    public class Quick
    {
        private static void Quick_Sort(int[] arr, int left, int right)
        {
            if (left >= right) return;

            var pivot = Partition(arr, left, right);

            if (pivot > 1)
            {
                Quick_Sort(arr, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                Quick_Sort(arr, pivot + 1, right);
            }
        }

        private static int Partition(int[] array, int left, int right)
        {
            var pivot = array[left];

            while (true)
            {

                while (array[left] < pivot)
                {
                    left++;
                }

                while (array[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (array[left] == array[right])
                        return right;

                    var tmp = array[left];
                    array[left] = array[right];
                    array[right] = tmp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
