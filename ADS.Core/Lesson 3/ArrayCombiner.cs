namespace ADS.Core.Lesson_3
{
    public class ArrayCombiner
    {
        public int[] Execute(int[] arrayOne, int[] arrayTwo)
        {
            int arrPoint1 = 0;
            int arrPoint2 = 0;

            int ct = arrayOne.Length + arrayTwo.Length;
            var final = new int[ct];

            for (var i = 0; i < ct; i++)
            {
                //Bounds
                if (arrPoint1 < arrayOne.Length)
                {
                    //Bounds
                    if (arrPoint2 < arrayTwo.Length)
                    {
                        if (arrayOne[arrPoint1] < arrayTwo[arrPoint2]) // Check if array A[i] < array B[i]
                            final[i] = arrayOne[arrPoint1++]; //Put A at position i
                        else
                            final[i] = arrayTwo[arrPoint2++]; //Else put B at position i
                    }
                    else
                        final[i] = arrayOne[arrPoint1++]; //Set array one I , as A doesn't have anymore elements
                }
                else
                    final[i] = arrayTwo[arrPoint2++]; //Set array two on I, as B doesn't have anymore elements
            }

            return final;
        }

        public static int[] combineArray(int[] a, int[] b)
        {
            int[] newArr = new int[a.Length + b.Length];

            int posB = 0;
            int posA = 0;

            for (var i = 0; i < a.Length + b.Length; i++)
            {
                if (posA < a.Length)
                {
                    if (posB < b.Length)
                    {
                        if (a[posA] > b[posB])
                        {
                            newArr[i] = b[posB++];
                        }
                        else if (a[posA] <= b[posB])
                        {
                            newArr[i] = a[posA++];
                        }
                    }
                    else
                    {
                        newArr[i] = a[posA++]; //Set array one I , as A doesn't have anymore elements
                    }
                }
                else
                {
                    newArr[i] = b[posB++]; //Set array one I , as B doesn't have anymore elements
                }
            }

            return newArr;
        }
    }
}
