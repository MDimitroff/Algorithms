using System;
using Utils;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new IntArray(10);
            array.GenerateRandomValues(100);
            Console.WriteLine("Unsorted array");
            array.DisplayValues();
            var arr = array.ToArray();

            var algo = new BubbleSort();
            algo.Sort(arr);

            Console.WriteLine("Sorted array");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.ReadLine();
        }
    }
}
