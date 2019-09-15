using System;
using System.Collections.Generic;
using System.Text;

namespace ADS.Core.Sorting
{
    /// <summary>
    /// Counting Sort	Ω(n+k)	Θ(n+k)	O(n+k)	O(k)
    /// For simplicity, consider the data in the range 0 to 9. 
    /// Input data: 1, 4, 1, 2, 7, 5, 2
    /// 1) Take a count array to store the count of each unique object.
    /// Index:     0  1  2  3  4  5  6  7  8  9
    /// Count:     0  2  2  0   1  1  0  1  0  0
    /// 
    /// 2) Modify the count array such that each element at each index 
    /// stores the sum of previous counts. 
    /// Index:     0  1  2  3  4  5  6  7  8  9
    /// Count:     0  2  4  4  5  6  6  7  7  7
    /// 
    /// The modified count array indicates the position of each object in 
    /// the output sequence.
    /// 
    /// 3) Output each object from the input sequence followed by 
    /// decreasing its count by 1.
    /// Process the input data: 1, 4, 1, 2, 7, 5, 2. Position of 1 is 2.
    /// Put data 1 at index 2 in output. Decrease count by 1 to place 
    /// next data 1 at an index 1 smaller than this index.
    /// </summary>
    public class Count
    {
        public static void Execute(char[] arr)
        {
            var n = arr.Length;

            // The output character array that 
            // will have sorted arr 
            var output = new char[n];

            // Create a count array to store  
            // count of inidividul characters  
            // and initialize count array as 0 
            var count = new int[256];

            for (var i = 0; i < 256; ++i)
                count[i] = 0;

            // store count of each character 
            for (var i = 0; i < n; ++i)
                ++count[arr[i]];

            // Change count[i] so that count[i]  
            // now contains actual position of  
            // this character in output array 
            for (var i = 1; i <= 255; ++i)
                count[i] += count[i - 1];

            // Build the output character array 
            // To make it stable we are operating in reverse order. 
            for (var i = n - 1; i >= 0; i--)
            {
                output[count[arr[i]] - 1] = arr[i];
                --count[arr[i]];
            }

            // Copy the output array to arr, so 
            // that arr now contains sorted  
            // characters 
            for (var i = 0; i < n; ++i)
                arr[i] = output[i];
        }

    }
}
