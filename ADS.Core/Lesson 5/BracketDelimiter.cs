using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.XPath;
using ADS.Core.ADT;

namespace ADS.Core.Lesson_5
{
    public class BracketDelimiter
    {
        public static bool IsBalanced(string s)
        {
            IMyStack<char> stack = new MyStack<char>();

            foreach (char c in s)
            {
                if (c == '{' || c == '(' || c == '<' || c == '[')
                {
                    stack.Push(c);
                }
                // alternative to '{' is '\x007B' or '\u007B' (see ascii table)
                // alternative could be a switch
                else if (c == '}' && stack.Size() != 0 && stack.Peek() == '{'
                         || c == ')' && stack.Size() != 0 && stack.Peek() == '('
                         || c == '>' && stack.Size() != 0 && stack.Peek() == '<'
                         || c == ']' && stack.Size() != 0 && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else // the stack did not contain the corresponding opening tag
                {
                    return false;
                }

            }

            // when the complete string is checked, the stack should be empty
            return stack.Size() == 0;
        }

        




        //public static bool IsBalanced(string s)
        //    {
        //        //If a length of N is not 
        //        if (s.Length % 2 != 0)
        //            return false;

        //        //sanitize
        //        var charsToRemove = new[] { "(",")","<", "?", "}", "{", "'", ">", "/", "[", "]", "*"};
        //        var finalstring = "";
        //        for (var index = 0; index < s.Length; index++)
        //        {
        //            for (int i = 0; i < charsToRemove.Length; i++)
        //            {
        //                if (s[index].ToString().Contains(charsToRemove[i]))
        //                {
        //                    finalstring += charsToRemove[i];
        //                    break;
        //                }

        //            }
        //        }


        //        var size = finalstring.Length;
        //        var result = false;



        //        for (var i = 0; i < size; i++)
        //        {
        //            var first = finalstring[i];
        //            var last = finalstring[size - i - 1];

        //            switch (first)
        //            {
        //                case '{':
        //                    if (last == '}')
        //                        result = true;
        //                    break;

        //                case '(':
        //                    if (last == ')')
        //                        result = true;
        //                    break;

        //                case '[':
        //                    if (last == ']')
        //                        result = true;
        //                    break;

        //                case '<':
        //                    if (last == '>')
        //                        result = true;
        //                    else
        //                    {
        //                        if (finalstring.Length > i + 1)
        //                        {
        //                            if (finalstring[i + 1] == '?')
        //                            {
        //                                if (finalstring.Length > i - 2)
        //                                {
        //                                    if (finalstring[size - i - 2] == '?')
        //                                    {
        //                                        if (last == '>')
        //                                            return true;
        //                                    }

        //                                    return false;
        //                                }
        //                            }
        //                            else if (finalstring[i + 1] == '%')
        //                            {
        //                                if (finalstring.Length > i - 2)
        //                                {
        //                                    if (finalstring[size - i - 2] == '%')
        //                                    {
        //                                        if (last == '>')
        //                                            return true;
        //                                    }

        //                                    return false;
        //                                }
        //                            }
        //                        }

        //                    }

        //                    break;

        //                case '"':
        //                    if (last == '"')
        //                        result = true;
        //                    break;

        //                case '\'':
        //                    if (last == '\'')
        //                        result = true;
        //                    break;

        //                case '/':
        //                    if (finalstring.Length > i + 1)
        //                    {
        //                        if (finalstring[i + 1] == '*')
        //                        {
        //                            if (finalstring.Length > i - 2)
        //                            {
        //                                if (finalstring[size - i - 2] == '*')
        //                                {
        //                                    if(last == '/')
        //                                        return true;
        //                                }

        //                                return false;
        //                            }
        //                        }
        //                    }
        //                    break;
        //            }
        //        }

        //        return result;
        //    }

        //public static bool IsBalancedFloris(String s)
        //{

        //    var charArray = s.ToCharArray();
        //    var delimitersInString = new string[charArray.Length];


        //    var delimiters = new string[]
        //    {
        //        "(",
        //        ")",
        //        "{",
        //        "}",
        //        "[",
        //        "]",
        //        "<",
        //        ">",
        //        "\"",
        //        "\'",
        //        "<?",
        //        "?>",
        //        "/*",
        //        "*/",
        //        "<%",
        //        "%>"
        //    };

        //    var previousChar = ' ';

        //    for (int i = 0; i < charArray.Length; i++)
        //    {
        //        for (int j = 0; j < delimiters.Length; j++)
        //        {
        //            if (delimiters[j].Length == 2)
        //            {
        //                if (previousChar + charArray[i].ToString() == delimiters[j])
        //                {
        //                    delimitersInString[i] = previousChar + charArray[i].ToString();
        //                }
        //            }
        //            else
        //            {
        //                if (delimiters[j] == charArray[i].ToString())
        //                {
        //                    if (charArray.Length > i + 1 && delimiters.Contains(charArray[i].ToString() + charArray[i + 1].ToString()))
        //                    {
        //                        delimitersInString[i] = charArray[i].ToString() + charArray[i + 1].ToString();
        //                        i++;
        //                    }
        //                    else
        //                    {
        //                        delimitersInString[i] = charArray[i].ToString();
        //                    }
        //                }
        //            }


        //        }

        //        previousChar = charArray[i];
        //    }

        //    delimitersInString = delimitersInString.Where(x => !string.IsNullOrEmpty(x)).ToArray();

        //    if (delimitersInString.Length % 2 != 0)
        //        return false;

        //    bool result = false;


        //    for (var i = 0; i < delimitersInString.Length; i++)
        //    {
        //        result = delimitersInString[i] == delimiters[delimiters.IndexOf(delimitersInString , delimitersInString[0]) + 1];

        //    }


        //    return result;
        //}





    }
}
