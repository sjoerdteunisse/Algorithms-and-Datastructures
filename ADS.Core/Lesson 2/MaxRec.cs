using System;
using System.Collections.Generic;
using System.Text;

namespace ADS.Core.Lesson_2
{
    public class MaxRec
    {
        public static int Execute(int[] array, int index = 0, int highestFound = 0)
        {

            if (array.Length == index)
                return highestFound;


            if (array[index] > highestFound)
                highestFound = array[index];

            return Execute(array, index + 1, highestFound);
        }
    }
}
