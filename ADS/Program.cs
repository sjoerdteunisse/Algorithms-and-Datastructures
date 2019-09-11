//using ADS.Core.Lesson_1;
using ADS.Core.Lesson_2;
using ADS.Core.Lesson_3;
using System;
using System.Collections.Generic;

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
                                   //TowersOfHanoi.Solve(totalDisks, startPeg, endPeg, tempPeg);

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

            // ArrayCombiner arrayCombiner = new ArrayCombiner();
            //var x = arrayCombiner.Execute(new int[] { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 },
            //     new int[] { 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024 });

            //ArrayListCombiner arrayListCombiner = new ArrayListCombiner();

            // var y = arrayListCombiner.Merge(new List<int> { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 },
            //    new List<int> { 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024 });


            // Create first polynomial
            var polynomial1 = new Polynomial();
            polynomial1.Add(new Term(-1, 2));
            polynomial1.Add(new Term(-3, 1));
            polynomial1.Add(new Term(-1, 0));
            polynomial1.Add(new Term(5, 5));


            // Create second polynomial
            var polynomial2 = new Polynomial();
            polynomial2.Add(new Term(1, 3));
            polynomial2.Add(new Term(2, 2));
            polynomial2.Add(new Term(-5, 0));

           //TowersOfHanoi.Solve(64);
            //TowersOfHanoi.TowerHanoi(3);
            //-> coeff = 1 - X^ > ex3
            //2X^3
            //-5^0

            //var c = BinarySearch.binarySearchFloris(new int[] { 1,2,3,4,5,6,7,8,9,10 }, 2);

            int max = MaxRec.Execute(new int[]{1,2,3,4,1204});

            // Determine the sum
            Polynomial polynomialSum = polynomial1.Sum(polynomial2);
            var terms = polynomialSum.GetAllTerms();

            for (int i = 0; i < polynomialSum.GetAllTerms().Count; i++)
            {
                Console.Write($"{terms[i].toString()}\t");

            }
            Console.WriteLine();


            Hangman hangman = new Hangman();
            hangman.ChooseWord();

            bool val = true;
            while (val)
            {
                string input = Console.ReadLine();
                hangman.GuessWord(input);

                if (input == "exit")
                {
                    val = false;
                }

            }


            //Console.WriteLine(Converter.BinToDecimal("1011"));
            Console.ReadLine();
        }
    }
}
