using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[]{8,5, 6, 1, 9, 2};
            new BubbleSort().sort(arr);
            Console.WriteLine(String.Join(',', arr));
        }
    }
}
