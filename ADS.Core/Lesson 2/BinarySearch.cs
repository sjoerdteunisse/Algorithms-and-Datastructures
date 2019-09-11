using System;
using System.Linq;

namespace ADS.Core.Lesson_2
{
    /// <summary>
    /// Binary search expects that the array is sorted
    /// </summary>
    public class BinarySearch
    {
        // Returns index of searchFor if it is present in 
        // arr[start..end], else return -1 
        public static int BinarySearchRecursiveSelf(int[] arr, int start,
            int end, int searchFor)
        {
            if (end < start)
            {
                return -1;
            }

            //Get the mid value;
            var mid = start + (end - start) / 2;

            // If the element is present at the 
            // middle itself 
            if (arr[mid] == searchFor)
                return mid;

            // If element is smaller than mid, then 
            // it can only be present in start sub-array 
            if (arr[mid] > searchFor)
            {
                return BinarySearchRecursiveSelf(arr, start, mid - 1, searchFor);
            }

            if (arr[mid] < searchFor)
            {
                // Else the element can only be present 
                // in end sub-array 
                return BinarySearchRecursiveSelf(arr, mid + 1, end, searchFor);
            }
            return -1;
        }

        /// <summary>
        /// Binary search recursively
        /// </summary>
        /// <param name="search"></param>
        /// <param name="array"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static int RecursiveV2(int search, int[] array, int start, int end)
        {

            int middle = (start + end) / 2;

            if (end < start)
            {
                return -1;
            }

            if (search < array[middle])
            {
                return RecursiveV2(search, array, start, middle - 1);
            }

            if (search > array[middle])
            {
                return RecursiveV2(search, array, middle + 1, end);
            }

            if (search == array[middle])
            {
                return middle;
            }

            return -1;
        }

        public int binarySearch(int[] sortedIntArray, int n, int arrMin = 0, int arrMax = 0)
        {
            int mid = (arrMin == 0 && arrMax == 0 ? (sortedIntArray.Length - 1) / 2 : (arrMin + arrMax) / 2);

            if (n > sortedIntArray[mid])
                return binarySearch(sortedIntArray, n, mid + 1, mid * 2 + 1);
            if (n < sortedIntArray[mid])
                return binarySearch(sortedIntArray, n, arrMin, mid);
            return mid;
        }
    }
}
