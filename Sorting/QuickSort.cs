using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    //                    Best          Worst
    //Partitioning        O(n)          O(n)
    //# of items          O(log n)      O(n)
    //Total               O(n log n)    O(n^2)
    //Space               O(log n)      O(n)
    internal class QuickSort
    {
        public void sort(int[] arr)
        { 
            sort(arr, 0, arr.Length-1);
        }
        private void sort(int[] arr, int start, int end)
        {
            if (start>=end)
            {
                return;
            }
            //Partition
            var boundary = partition(arr, start, end);
            //Sort left
            sort(arr, start, boundary-1);
            //Sort right
            sort(arr, boundary+1, end);
        }

        private int partition(int[] arr, int start, int end)
        {
            var pivot = arr[end];
            var boundary = start -1;
            for (int i = start; i <= end; i++)
            {
                if (arr[i]<=pivot)
                {
                    swap(i, ++boundary, arr);
                }
            }
            return boundary;
        }

        private void swap(int index1, int index2, int[] arr)
        {
            var temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }
}
