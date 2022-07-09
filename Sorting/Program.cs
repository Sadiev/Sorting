using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[]{8, 5, 3, 6, 1, 3, 9, 2};
            //new BubbleSort().sort(arr);
            //new SelectionSort().sort(arr);
            new InsertionSort().sort(arr);
            Console.WriteLine(String.Join(',', arr));
        }
    }
}
