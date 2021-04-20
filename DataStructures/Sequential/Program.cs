using System;
using Utils;

namespace Sequential
{
    class Program
    {
        /// <summary>
        /// Sequential search in unordered array.
        /// Self-organizing data: the more searched elements gets closer to the beginning of the list.
        /// As a result, the searched elements are returned faster, because they are always at the begining and no need to iterate the whole array.
        /// Pareto rule 80:20 - the 80% of the searched elements are found in the 20% of the elements.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var list = new IntArray(10);
            list.GenerateRandomValues(100);
            Console.WriteLine("Before sequential search");
            list.DisplayValues();
            var array = list.ToArray();
            int searchValue = array[array.Length - 1];
            Console.WriteLine($"Searching for value {searchValue}");

            int value1 = SequentialSearch(array, searchValue);
            Console.WriteLine($"Found value {value1}");

            Display(array);
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                int foundValue = SequentialSearch(array, searchValue);
                Console.WriteLine($"Iteration {i}, value found {foundValue}");
                Console.WriteLine("New order of the array");
                Display(array);
            }

            Console.WriteLine("Operation completed");
        }

        private static int SequentialSearch(int[] array, int searchValue)
        {
            int foundValue = -1;

            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] == searchValue)
                {
                    foundValue = array[index];

                    if (index >= (array.Length * 0.2)) // 20% of the elements in the array
                    {
                        Swap(ref array[index], ref array[index - 1]);
                    }
                }
            }

            return foundValue;
        }

        private static void Swap(ref int item1, ref int item2)
        {
            int temp = item1;
            item1 = item2;
            item2 = temp;
        }

        private static void Display(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
        }
    }
}
