using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    //Populate counts        O(n)
    //iterate counts         O(k)
    //Total                  O(n)
    //Space                  O(k)
    internal class CountSort
    {
        public void sort(int[] arr)
        {
            var counts = new int[arr.Max()+1];
            foreach (var item in arr)
            {
                counts[item]++;
            }
            var k=0;
            for (int i = 0; i < counts.Length; i++)
            {
                for (int j = 0; j < counts[i]; j++)
                {
                    arr[k++] = i;
                }
            }
        }
    }
}
