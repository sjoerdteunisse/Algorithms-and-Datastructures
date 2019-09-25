using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using ADS.Core.ADT;

namespace ADS.Core.Lesson_5
{
    public class PostfixCalculator
    {
        public static int Calculate(string postfixExpression)
        {

            var stringArray = Regex.Split(postfixExpression, @"([ +/*-])").Where(x => x != " ").Where(x => x != "").ToArray();

            IMyStack<int> stack = new MyStack<int>();

            for (int i = 0; i < stringArray.Length; i++)
            {
                if ("*+/-".Contains(stringArray[i].ToString()))
                {
                    int val1 = 0;
                    int val2 = 0;

                    switch (stringArray[i])
                    {
                        case "*":
                            val1 = stack.Peek();
                            stack.Pop();
                            val2 = stack.Peek();
                            stack.Pop();
                            stack.Push(val2 * val1);

                            break;

                        case "/":
                            val1 = stack.Peek();
                            stack.Pop();
                            val2 = stack.Peek();
                            stack.Pop();
                            stack.Push(val2 / val1);

                            break;

                        case "+":
                            val1 = stack.Peek();
                            stack.Pop();
                            val2 = stack.Peek();
                            stack.Pop();
                            stack.Push(val2 + val1);

                            break;

                        case "-":
                            val1 = stack.Peek();
                            stack.Pop();
                            val2 = stack.Peek();
                            stack.Pop();
                            stack.Push(val2 - val1);
                            break;
                    }
                }
                else
                {
                    stack.Push(Convert.ToInt32(stringArray[i]));
                }

                //return stack.Peek();

            }





            return stack.Peek();
            //return stack.Size() == 0;
        }
    }
}
