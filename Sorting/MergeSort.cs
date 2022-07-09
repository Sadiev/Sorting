using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    //                  Best            Worst
    //Dividing          O(log n)        O(log n)
    //Merging           O(n)            O(n)
    //Total             O(n log n)      O(n log n)
    //Space             O(n)            O(n)
    internal class MergeSort
    {
        public void sort(int[] arr)
        {
            if(arr.Length<2)
                return;
            //Divide the array into half
            var middle = arr.Length / 2;

            var left = new int[middle];
            for (var i = 0; i < middle; i++)
                left[i] = arr[i];

            var right = new int[arr.Length-middle];
            for (int i = middle; i < arr.Length; i++)
                right[i-middle] = arr[i];

            //Sort each half
            sort(left);
            sort(right);

            //Merge the result
            merge(left, right, arr);
        }

        private void merge(int[] left, int[] right, int[] result)
        {
            var i = 0;
            var j = 0;
            var k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    result[k++] = left[i++];
                }
                else
                {
                    result[k++] = right[j++];
                }
            }
            while (i<left.Length)
            {
                result[k++] = left[i++];
            }
            while (j < right.Length)
            {
                result[k++] = right[j++];
            }
        }
    }
}
