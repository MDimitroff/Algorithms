using System;

namespace ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6];
            array[0] = 30;
            array[1] = 24;
            array[2] = 14;
            array[3] = 99;
            array[4] = 1;
            array[5] = 3;

            array = ShellSort.Sort(array);

            Console.WriteLine("Sorted array:");

            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
