using System;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HeapSort algorithm");

            int[] arr = { 55, 25, 89, 34, 12, 19, 78, 95, 1, 100 };
            int n = 10, i;
            
            Console.WriteLine("Heap Sort");
            Console.Write("Initial array is: ");

            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            HeapSort.Sort(arr, 10);

            Console.Write("\nSorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
