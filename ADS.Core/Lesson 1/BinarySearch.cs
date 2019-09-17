namespace ADS.Core.Lesson_1
{
    public class BinarySearch
    {
        /// <summary>
        /// returns the position of the search value in the array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public static int Execute(int[] array, int searchValue)
        {
            //set min
            var min = 0;
            //set max according to the length
            var max = array.Length - 1;

            //loop through
            while (min <= max)
            {
                //get the mid 
                var mid = (min + max) / 2;
                //check if search == mid
                if (searchValue == array[mid])
                    return mid;
                else if (searchValue < array[mid]) // else flip max
                    max = mid - 1;
                else //Iterate min to make the array search(array) smaller
                    min = mid+1;
            }

            return -1;
        }
    }
}
