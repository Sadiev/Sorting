using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    class BubbleSort
    {
        public void sort(int[] arr)
        {
            bool isSorted;
            for (int i = 0; i < arr.Length; i++)
            {
                isSorted = true;
                for (int j = 1; j < arr.Length - i; j++)
                {
                    if (arr[j-1] > arr[j])
                    {
                        swap(j, arr);
                        isSorted = false;
                    }
                }
                if(isSorted)
                    break;
            }
        }
        private void swap(int index, int[] arr)
        {
            var temp = arr[index];
            arr[index] = arr[index - 1];
            arr[index - 1] = temp;
        }
    }
}
