using System;

namespace ADS.Core.Lesson_2
{
    public class Converter
    {
        /// <summary>
        /// Takes in a long, and returns the binary form of the number
        /// </summary>
        /// <param name="binary">Binary in the form of Long</param>
        /// <returns>int</returns>
        public static int Bin2dec(long binary)
        {
            //Check if we need to stop execution of recursion
            if (binary == 0)
                return 0;

            //Calculate the sum, based on the given binary.
            //Stack wise incrementing the stack value for each number
            //Example:
            //Binary input is 1100
            //value is checked, by binary == 0;
            //Sum value is allocated with the following steps;
            //1100 % 10 = 110
            //110 % 10 = 11
            //11 % 10 = 1 
            //1100 / 10 = 110 / 10 = 11 / 10 = 1
            //Resulting in 9
            
            var remainder = (int) binary % 10;
            var sum = remainder + 2 * Bin2dec(binary / 10);
            return sum;
        }


        public static int BinToDecimal(string binary, int i = 0)
        {
            //Keep track of the sum
            var sum = 0;

            //Exit scenario
            if (i >= binary.Length)
                return sum;

            //reverse str as i starts from left to right;
            //0011
            var s = ReverseString.Execute(binary);

            //If char at I is a 1
            if (s[i] == '1') //Add to sum: 2 ^ i where I is the position
                sum = (int)Math.Pow(2, i);
            else if (s[i] != '0') //invalid input
                throw new SystemException("invalid input");

            //Return sum + the next value; Adds value to stack
            return sum + BinToDecimal(binary, ++i);
        }

        public static string DecimalToBin(int dec)
        {
            string s = "";

            if (dec == 0)
                return s;

            s += dec % 2 + DecimalToBin(dec / 2);

            Console.Write(s);
            return "";
        }
    }
}
