using System.Linq.Expressions;
using ADS.Core.Lesson_1;
using ADS.Core.Sorting;

namespace ADS.Core.Helpers
{
    public class Notation
    {
        
        /// <summary>
        /// O(1) O(log n) O(n) O(n log n) o(n^2) o(2^n) o(n!)
        /// </summary>
        /// <param name="array"></param>
        /// <param name="key"></param>
        /// <returns></returns>

        //Data Structure         Average cases                      Worst cases
        //                      Insert    Delete      Search        Insert  Delete  Search
        //Array/stack/queue     O(1)        O(1)        O(n)        O(1)    O(1)    O(n)
        //Linked list           O(1)        O(1)        O(n)        O(1)    O(1)    O(n)
        //Doubly linked list    O(1)        O(1)        O(n)        O(1)    O(1)    O(n)
        //Hash table            O(1)        O(1)        O(1)        O(n)    O(n)    O(n)
        //Binary search tree    O(log(n))   O(log(n))   O(log(n))   O(n)    O(n)    O(n)

        //Logarithmic search: O(log n)
        //memory O(1)
        public int ExecuteBinarySearch(int[] array, int key)
        {
            return BinarySearch.Execute(array, key);
        }

        //Best                      Average     Worst
        //Quick Sort Ω(n log (n) ) Θ(n log(n) ) O(n2 )
        public void ExecuteQuicksort(int[] array, int left, int right)
        {
            Quick.Quick_Sort(array,left,right);
        }

        //Bucket Sort best: O(n+m) avg: Θ(n+m) worst:O(n2)
        //Where N is numbers and M is buckets
        //TIME = O(n), if m<n if bucket count is smaller than number count
        //Memory O(N)- buckets increase with N Or The space complexity for Bucket Sort is O(n+k) if buckets +numbers are added as sublist of a bucket
        public void ExecuteBucketSort(int[] array)
        {
            BucketSort.Execute(array);
        }

        //Bubble Sort best: o(n) avg:Θ(n2) worst:O(n2 )
        //o1 memory
        public void ExecuteBubbleSort(int[] array)
        {
            BubbleSort.Execute(array);
        }


        //Merge Sort Ω(n log (n) ) Θ(n log(n) ) O(n log(n) )
        //Timsort Ω(n ) Θ(n log(n) ) O(n log(n) )
        //Heap Sort Ω(n log (n) ) Θ(n log(n) ) O(n log(n) )
        //Insertion Sort Ω(n ) Θ(n2 ) O(n2 )
        //Selection Sort Ω(n2 ) Θ(n2 ) O(n2 )
        //Tree Sort Ω(n log (n) ) Θ(n log(n) ) O(n2 )
        //Shell Sort Ω(n log (n) ) Θ(n (log(n) )2) O(n (log(n) )2)
        //Radix Sort Ω(nk ) Θ(nk ) O(nk )
        //Counting Sort Ω(n+k ) Θ(n+k ) O(n+k )
        //Cubesort Ω(n ) Θ(n log(n) ) O(n log(n) )
        //Smooth Sort Ω(n ) Θ(n log(n) ) O(n log(n) )
        //Tournament Sort - Θ(n log(n) ) O(n log(n) )
        //Stooge sort - - O(n log 3 /log 1.5 )
        //Gnome/Stupid sort Ω(n ) Θ(n2 ) O(n2 )
        //Comb sort Ω(n log (n) ) Θ(n2/p2) O(n2 )
        //Odd – Even sort Ω(n ) - O(n2 )
    }
}
