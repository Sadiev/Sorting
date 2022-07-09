using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    //                  Best        Worst
    //Iteration         O(n)        O(n)
    //Shift items       O(1)        O(n)
    //Total             O(n)        O(n^2)
    //                  Linear      Quadratic
    internal class InsertionSort
    {
        public void sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                var current=arr[i];
                var j=i-1;
                while (j>=0 && arr[j]>current)
                {
                    arr[j+1]=arr[j];
                    j--;
                }
                arr[j+1]=current;
            }
        }
    }
}
