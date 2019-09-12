using System.Collections;
using System.Collections.Generic;

namespace ADS.Core.Lesson_3
{
    public class ArrayListCombiner
    {
        public List<int> Merge(List<int> arraylist1, List<int> arraylist2)
        {
            var arrPoint1 = 0;
            var arrPoint2 = 0;

            var ct = arraylist1.Count + arraylist2.Count;
            var finalArray = new List<int>();

            for (var i = 0; i < ct; i++)
            {
                //Bounds
                if (arrPoint1 < arraylist1.Count)
                {
                    if (arrPoint2 < arraylist2.Count)
                    {
                        if (arraylist1[arrPoint1] < arraylist2[arrPoint2]) // Check if array A[i] < array B[i]
                            finalArray.Add(arraylist1[arrPoint1++]);  //Put A at position i
                        else
                            finalArray.Add(arraylist2[arrPoint2++]); //Else put B at position i
                    }
                    else
                        finalArray.Add(arraylist1[arrPoint1++]); //Set array two on I, as B doesn't have anymore elements
                }
                else
                    finalArray.Add(arraylist2[arrPoint2++]); //Set array two on I, as B doesn't have anymore elements
            }

            return finalArray;
        }

        public static ArrayList Merge(ArrayList arraylist1, ArrayList arraylist2)
        {
            var arrPoint1 = 0;
            var arrPoint2 = 0;

            var ct = arraylist1.Count + arraylist2.Count;
            var finalArray = new ArrayList();

            for (var i = 0; i < ct; i++)
            {
                //Bounds
                if (arrPoint1 < arraylist1.Count)
                {
                    if (arrPoint2 < arraylist2.Count)
                    {
                        if ((arraylist1[arrPoint1] as int?) < (arraylist2[arrPoint2] as int?)) // Check if array A[i] < array B[i]
                            finalArray.Add((int) arraylist1[arrPoint1++]);  //Put A at position i
                        else
                            finalArray.Add((int) arraylist2[arrPoint2++]); //Else put B at position i
                    }
                    else
                        finalArray.Add((int) arraylist1[arrPoint1++]); //Set array two on I, as B doesn't have anymore elements
                }
                else
                    finalArray.Add((int) arraylist2[arrPoint2++]); //Set array two on I, as B doesn't have anymore elements
            }

            return finalArray;
        }

    }
}
