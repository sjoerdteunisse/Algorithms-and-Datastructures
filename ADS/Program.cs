using System;
using System.Collections.Generic;
using System.Linq;
//using ADS.Core.Lesson_1;
using ADS.Core.Lesson_2;

namespace ADS
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoopProblem.Problem();

            char startPeg = 'A'; // start tower in output
            char endPeg = 'C'; // end tower in output
            char tempPeg = 'B'; // temporary tower in output
            int totalDisks = 1200; // number of disks
            TowersOfHanoi.Solve(totalDisks, startPeg, endPeg, tempPeg);

            //var bucketSort = new BucketSort();
            //bucketSort.Execute(new[] { 8, 2, 122, 1, 99, 3, 4, 2 });

            //BubbleSort bubbleSort = new BubbleSort();
            //var res = bubbleSort.Execute(new int[]{8,2, 122, 1});

            //var x = new Solution3();
            //x.Slow(100);
            //x.Fast(100);

            //var binarySearch = new BinarySearch();
            //var array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //int pos = binarySearch.Execute(array, 10);

            //var input = "8,1,6;3,5,7;4,9,2";
            //var array = (from x in input.Split(',', ';') select int.Parse(x)).ToArray();
            //var magic = new MagicSquare();
            //magic.Execute(3);

            //magic.ExecuteCorrect(3);
            //MagicSquare.RunMagicSquare(3);


            //Binary Search recurisve.
            //int[] testArray = { 1,2,3,4,5,6,7,8,9,10,11,12};
            //var length = testArray.Length;
            //var searchFor = 10;

            //Console.WriteLine(BinarySearch.RecursiveV2(searchFor, testArray, 0, length));
            //Console.WriteLine($"Self made {BinarySearch.BinarySearchRecursiveSelf(testArray, 0, length, searchFor)}");


            //Console.WriteLine(
            //    ADS.Core.Lesson_2.Converter.DecimalToBin(10));

            //Console.WriteLine("Bin 2 dec " + ADS.Core.Lesson_2.Converter.Bin2dec(1100));
            //Console.WriteLine(ADS.Core.Lesson_2.Converter.BinToDecimal("10101"));


            //Console.WriteLine(Palindrome.IsPalindrome("racecar"));

            // Console.WriteLine(ReverseString.ExecuteV1("ban"));
            // Console.WriteLine(ReverseString.Execute("ban"));

            Console.WriteLine(Converter.BinToDecimal("1011"));
            Console.ReadLine();
        }
    }
}
