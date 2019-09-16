//using ADS.Core.Lesson_1;
using ADS.Core.Lesson_2;
using ADS.Core.Lesson_3;
using ADS.Core.Recursion;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using ADS.Core.Lesson_4;

namespace ADS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Printer.PrintAsc();
            //Console.WriteLine(NaturalCounter.Execute(5));
            //DigitSeperator.Execute(255);
            //Console.WriteLine(DigitCounter.Execute(12345));
            //OddNumberPrinter.Execute(20);
            IsPrime.Execute(37, 37 / 2);
            IsPalindrome.Execute("ABBA");
            Console.WriteLine(
                FactorialCalculator.Execute(8));
            //ForLoopProblem.Problem();

            char startPeg = 'A'; // start tower in output
            char endPeg = 'C'; // end tower in output
            char tempPeg = 'B'; // temporary tower in output
            int totalDisks = 1200; // number of disks
                                   //TowersOfHanoi.Solve(totalDisks, startPeg, endPeg, tempPeg);


           int[,] random = new int[,]
           {
               {200, 400},
               {2000, 4176},
               {20000, 40000},
               { 50000, 50000}
           };

            //var c = _2DArraySum.GetHighestSum(random);

            var getHighestSummedArray = new _2DArraySumAsClass<int[,]>();
            
            Console.WriteLine("Highest value"  + getHighestSummedArray.GetHighestSum(random));


            //Create linked list
            LinkedListExercise linkedListExercise = new LinkedListExercise();
            
            //Add data
            linkedListExercise.Employees.AddLast(new Employee("Bob", 5));
            linkedListExercise.Employees.AddLast(new Employee("Alice", 5000));
            
            //ShallowCopy with IClonable
            var shallowCopy = linkedListExercise.ShallowCopy();
            //Shallow copy with Collection<T>() ctor
            var shallowCopyCollection = linkedListExercise.ShallowCopyCollection();
            //Deep copy
            var deepCopy = linkedListExercise.DeepCopy();


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
            polynomial1.Add(new Term(1, 2));
            polynomial1.Add(new Term(2, 2));
            polynomial1.Add(new Term(3, 0));


            // Create second polynomial
            var polynomial2 = new Polynomial();
            polynomial2.Add(new Term(-1, 3));
            polynomial2.Add(new Term(1, 1));
            polynomial2.Add(new Term(1, 2));

            Stopwatch x = new Stopwatch();
            x.Start();
            Polynomial polyX = polynomial1.SumWorking(polynomial2);
            var termsWorking = polyX.GetAllTerms();
            x.Stop();
            Console.WriteLine(x.ElapsedTicks + "TICKS");
            x.Reset();

            x.Start();

            Polynomial polyOptimized = polynomial1.OptimizedAlgorithm(polynomial2);
            var optimzedTerms = polyX.GetAllTerms();
            x.Stop();
            Console.WriteLine(x.ElapsedTicks + "TICKS");
            x.Reset();

            // Determine the sum
            Polynomial polynomialSum = polynomial1.Sum(polynomial2);
            var terms = polynomialSum.GetAllTerms();

            for (int i = 0; i < polynomialSum.GetAllTerms().Count; i++)
            {
                Console.Write($"{terms[i].toString()}\t");

            }

            //TowersOfHanoi.Solve(64);
            //TowersOfHanoi.TowerHanoi(3);
            //-> coeff = 1 - X^ > ex3
            //2X^3
            //-5^0

            //var c = BinarySearch.binarySearchFloris(new int[] { 1,2,3,4,5,6,7,8,9,10 }, 2);

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

            int[] arr1 = new int[] { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
            int[] arr2 = new int[] { 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024 };

            int[] execute = ArrayCombiner.combineArray(arr2, arr1);

            //var intList = new ArrayList();
            //intList[1] as int? = 2;

            var res12 = ArrayListCombiner.Merge(new ArrayList() { 1, 2, 3, 4 }, new ArrayList() { 1, 2, 3, 4 });

            int max = MaxRec.Execute(new int[] { 1, 2, 3, 4, 1204 });


            Console.WriteLine();

            //Console.WriteLine(Converter.BinToDecimal("1011"));
            Console.ReadLine();
        }
    }
}
