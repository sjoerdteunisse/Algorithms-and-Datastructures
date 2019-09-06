namespace ADS.Core.Lesson_2
{
    public class Palindrome
    {

        //EXAMPLE:
        //INPUT: ABBA < length = 4
        //STACK-INTER
        //ITTER1: BB < remove first and last, length = 2
        //ITTER2: length = 0

        //EXAMPLE:
        //INPUT:RACECAR
        //STACK-INTER
        //ITER1: ACECA
        //ITER2: CEC
        //ITER3: E length = 1;
        //EVAL: TRUE

        /// <summary>
        /// Time complexity O(1 ^ N.length), Space complexity O(N)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsPalindrome(string input)
        {
            if (input.Length <= 1)
                return true;
            
            //first check the last char. Each palindrome has the same ending as starting char. example: ABA
            if (input[0] != input[input.Length - 1])
                return false;

            //take a char at index 1, and pop the other chars.
            //Foreach call of palindrome the stack size is increased and the if char first == last is checked.
            //When the stack is complete, the result is returned;
            return IsPalindrome(input.Substring(1, input.Length - 2));
        }
    }
}
