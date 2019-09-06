namespace ADS.Core.Lesson_1
{
    public class BubbleSort
    {
        //Bubble Sort Best:Ω(n) avg:Θ(n^2)  worst:O(n^2)  space: O(1)
        public int[] Execute(int[] array)
        {
            for (var i = 0; i < array.Length -1; i++) //Loop N times of the size of the elements
            {
                //For N element in the array, At X position loop X times to position it
                for (var j = 0; j < array.Length -1; j++) 
                {
                    //Check if the current value is bigger than the next one
                    if (array[j] > array[j + 1])
                    {
                        //Make a copy of the bigger value
                        var cpy = array[j];

                        //swap the values
                        //<< Current pos to value on right side.
                        array[j] = array[j + 1];
                        //>> Pos right, set value of copy
                        array[j + 1] = cpy;
                    }
                }
            }

            return array;
        }
    }
}
