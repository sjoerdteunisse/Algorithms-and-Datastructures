namespace ADS.Core.Lesson_2
{
    public class ReverseString
    {

        //Time complexity O(1), space O(n)
        public static string ExecuteV1(string input)
        {
            //Exit mechanism
            if (input.Length <= 1)
                return input;

            //Recall with string -1 length to pointer on stack.
            //And Add the first char as return value on the stack
            return ExecuteV1(input.Substring(1)) + input[0];
        }

        //public static string ReverseString(string input)
        //{
        //    if (input.Length > 0)
        //        ReverseString(input.Substring(1, input.Length - 1));
        //    return input;
        //}

        public static string Execute(string input)
        {
            //Create a stack with the chars reversed, and add this to the other chars, constructing an array on input;
            if (input.Length > 0)
                return input[input.Length - 1] + Execute(input.Substring(0, input.Length - 1));

            return input;
        }
    }
}
