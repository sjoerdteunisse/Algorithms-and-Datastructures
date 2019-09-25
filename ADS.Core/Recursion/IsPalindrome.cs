using System;

namespace ADS.Core.Recursion
{
    public class IsPalindrome
    {
        public static void Execute(string input)
        {
            if (input.Length <= 1)
                Console.WriteLine("Input is Palindrome");
            else
            {
                if (input[0] != input[input.Length - 1])
                    Console.WriteLine("Input is not Palindrome");
                else
                {
                    Execute(input.Substring(1, input.Length-2));
                }
            }
        }
    }
}
