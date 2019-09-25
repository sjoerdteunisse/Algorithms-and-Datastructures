namespace ADS.Core.Lesson_1
{
    public class ItterativeIndex
    {
        /// <summary>
        /// time: o(n)
        /// space o(1)
        /// </summary>
        /// <param name="array"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public int IndexOf(int[] array, int key)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                    return key;
            }

            return -1;
        }
        
        /// <summary>
        /// time: O(n)
        /// space: O(n)
        /// </summary>
        /// <param name="array"></param>
        /// <param name="key"></param>
        /// <param name="pos"></param>
        /// <returns></returns>

        public int IndexOf(int[] array, int key, int pos)
        {
            if (array.Length <= pos)
            {
                return -1;
            }

            if (array[pos] == key)
                return key;

            return IndexOf(array, key, pos+1);
        }
    }
}
