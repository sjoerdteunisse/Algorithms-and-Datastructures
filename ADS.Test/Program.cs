using System;

namespace ADS.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nMultiple reverse\n");
            var reversedMultiple = multipleReverse("abcd");
            Console.WriteLine(reversedMultiple);

            Console.WriteLine("\nInside Out\n");
            var resultInsideOut = insideOut(12009);
            Console.WriteLine(resultInsideOut);
        }

        /// <summary>
        /// Vraag 9:
        /// Maak een recursief programma dat een string als input krijgt en dan een string retourneert met de 1e letter 1x, de 2e letter 2x, de 3e letter 3x, .... Maar wel in omgekeerde volgorde; de laatste letter dus als eerste
        /// Signatuur: public static String multipleReverse(String s)
        /// Voorbeeld: multipleReverse("abcd") retourneert "ddddcccbba"
        /// </summary>
        /// <param name="input"></param>
        /// <param name="ct"></param>
        public static string multipleReverse(string input)
        {
            //Create a stack with the chars reversed, and add this to the other chars, constructing an array on input;
            if (input.Length > 0)
            {
                var tempInput = "";
                for (int i = 0; i < input.Length; i++)
                {
                    tempInput += input[input.Length - 1];
                }

                return tempInput + multipleReverse(input.Substring(0, input.Length - 1));
            }
            return input;
        }

        /// <summary>
        /// Maak een recursief programma dat een getal in omgekeerde volgorde retourneert.
        /// Signatuur: public static int insideOut(int n)
        /// Voorbeeld: insideOut(137) retourneert 731
        /// </summary>
        /// <param name="number">expects the number to be turned inside out</param>
        /// <returns></returns>
        public static int insideOut(int number)
        {
            if (number < 10)
                return number;

            //1234 - 4 - 3 - 2 -1 
            return number % 10 * (int)Math.Pow(10, (int)Math.Log10(number)) + insideOut(number / 10);
        }
    }
}
