using System;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HeapSort algorithm");

            var heap = new HeapSort(size: 9);
            var random = new Random();

            for (int i = 0; i < 9; i++)
            {
                int value = random.Next(1, 100);
                heap.Insert(value);
            }

            Console.WriteLine("Before sorting the values:");
            heap.Dump();
            Console.WriteLine("After sorting the values:");
            heap.Sort();
            heap.Dump();
        }
    }
}
