using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class SelectionSort
    {
        //              Best        Worst
        //Passes        O(n)        O(n)
        //Comparisons   O(n)        O(n)
        //Total         O(n^2)      O(n^2)
        //              Quadratic   Quadratic
        public void sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var minIndex=Array.IndexOf(arr, arr.Skip(i).ToArray().Min());
                swap(minIndex, i, arr);
            }
        }

        private void swap(int index1, int index2, int[] arr)
        { 
            var temp=arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }
}
