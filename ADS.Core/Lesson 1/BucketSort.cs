using System.Collections.Generic;

namespace ADS.Core.Lesson_1
{
    public class BucketSort
    {
        //The average time complexity for Bucket Sort is O(n + k).
        //The worst time complexity is O(n²).

        //Create N Buckets for X size of elements where X is the largest amount; 
        //given X is has X elements contained, ensure X amount of buckets are created;
        //Foreach bucket, representing an array of integers.
        public static int[] Execute(int[] array)
        {
            //Set smallest and largest to the 0th position in the array
            var largest = array[0];
            var smallest = array[0];

           //Loop to find the biggest, and smallest numbers.
            foreach (var element in array)
            {
                //if element is smaller than smallest, set to a new value
                if (element < smallest)
                    smallest = element;

                //if element is bigger than larger, set to a new value
                if (element > largest)
                    largest = element;
            }

            //Construct a list for a size of X buckets,
            //where X = the largest integer - the smallest + 1
            //For example, 122 - 1 + 1; X = 122
            var bucketList = new List<int>[largest - smallest + 1];

            //Create a new array of integers within the list,
            //Done for the total length of X buckets
            for (var i = 0; i < bucketList.Length; i++)
            {
                bucketList[i] = new List<int>();
            }

            //Add all elements in the according buckets
            //For Bucket[X - smallest].Add(element) Where element is from the array.
            foreach (var element in array)
            {
                bucketList[element - smallest].Add(element);
            }

            //Reconstructing the buckets to an array;
            //Keep track of each iteration
            var iteration = 0;
            //Construct a new array for the sorted elements; 
            //Length is known by the passed array
            var finalArray = new int[array.Length];
            //iterate through all bucket list items to check if the have values;
            foreach (var element in bucketList)
            {
                //Check if the bucket list sub list (bucket) - has values
                if (element.Count <= 0)
                    continue;

                //For N elements in the sub list (bucket) add to final array
                foreach (var subElement in element)
                {
                    //add value from bucket list
                    finalArray[iteration] = subElement;

                    //Up iteration for array value access
                    iteration++;
                }
            }

            return finalArray;
        }
    }
}
