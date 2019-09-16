using System;

namespace ADS.Core.Lesson_4
{
    public class _2DArraySum
    {
        public static float GetHighestSum<T>(T[,] collection) where T : struct,IComparable,IComparable<T>,IConvertible,IEquatable<T>,IFormattable
        {
            var maxValue = (float)Convert.ChangeType(collection[0, 0], typeof(float));

            for (var i = 0; i < collection.GetLength(0); i++)
            {
                float value = 0;

                for (var j = 0; j < collection.GetLength(1); j++)
                {
                    value += (float)Convert.ChangeType(collection[i, j], typeof(float));
                }

                if (value > maxValue)
                {
                    maxValue = value;
                }
            }

            return maxValue;
        }

        public static float GetSum(int[] row)
        {
            float value = 0;

            for (int i = 0; i < row.Length; i++)
            {
                value += row[i];
            }

            return value;
        }
    }
}
