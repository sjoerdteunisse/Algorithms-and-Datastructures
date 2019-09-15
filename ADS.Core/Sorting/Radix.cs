using System;
using System.Collections.Generic;
using System.Text;

namespace ADS.Core.Sorting
{
    /// <summary>
    /// The Radix Sort Algorithm
    /// 1) Do following for each digit i where i varies from least significant digit to the most significant digit.
    /// ………….a) Sort input array using counting sort (or any stable sort) according to the i’th digit.
    /// 
    /// Example:
    /// Original, unsorted list:
    /// 
    /// 170, 45, 75, 90, 802, 24, 2, 66
    /// Sorting by least significant digit (1s place) gives: [*Notice that we keep 802 before 2, because 802 occurred before 2 in the original list, and similarly for pairs 170 &amp; 90 and 45 &amp; 75.]
    /// 
    /// 170, 90, 802, 2, 24, 45, 75, 66
    /// 
    /// 
    /// Sorting by next digit (10s place) gives: [*Notice that 802 again comes before 2 as 802 comes before 2 in the previous list.]
    /// 
    /// 802, 2, 24, 45, 66, 170, 75, 90
    /// Sorting by most significant digit (100s place) gives:
    /// 
    /// 2, 24, 45, 66, 75, 90, 170, 802
    /// </summary>
    public class Radix
    {
        public static int GetMax(int[] arr, int n)
        {
            var mx = arr[0];
            for (var i = 1; i < n; i++)
                if (arr[i] > mx)
                    mx = arr[i];

            return mx;
        }
        public static void CountSort(int[] arr, int n, int exp)
        {
            var output = new int[n]; // output array  
            int i;
            var count = new int[10];

            //initializing all elements of count to 0 
            for (i = 0; i < 10; i++)
                count[i] = 0;

            // Store count of occurrences in count[]  
            for (i = 0; i < n; i++)
                count[(arr[i] / exp) % 10]++;

            // Change count[i] so that count[i] now contains actual  
            //  position of this digit in output[]  
            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];

            // Build the output array  
            for (i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }

            // Copy the output array to arr[], so that arr[] now  
            // contains sorted numbers according to current digit  
            for (i = 0; i < n; i++)
                arr[i] = output[i];
        }

        // The main function to that sorts arr[] of size n using   
        // Radix Sort  
        public static void Radixsort(int[] arr, int n)
        {
            // Find the maximum number to know number of digits  
            var m = GetMax(arr, n);

            // Do counting sort for every digit. Note that instead  
            // of passing digit number, exp is passed. exp is 10^i  
            // where i is current digit number  
            for (var exp = 1; m / exp > 0; exp *= 10)
                CountSort(arr, n, exp);
        }

        // A utility function to print an array  
        public static void Print(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }


        //int[] arr = { 172, 802, 24, 2, 66 };
        //int n = arr.Length;
        //Radixsort(arr, n);
        //Print(arr, n);

    }
}
