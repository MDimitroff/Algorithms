using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merge sort");

            int[] numbers = new int[] { 10, 3, 9, 5, 8, 65, 42, 99, 45, 6 };
            MergeSort.Sort(numbers, 0, numbers.Length - 1);


            for (int i = 0; i < numbers.Length - 1; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
