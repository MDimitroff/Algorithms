using System;
using Utils;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new IntArray(10);
            list.GenerateRandomValues(100);
            var array = list.ToArray();
            int searchValue = array[array.Length - 1];
            Console.WriteLine($"Searching for value {searchValue}");

            int value1 = BinarySearch(array, searchValue);
            Console.WriteLine($"Found value {value1}");
            Console.ReadLine();
        }

        private static int BinarySearch(int[] array, int searchedValue)
        {
            int upperBound, lowerBound, middle;
            upperBound = array.Length - 1;
            lowerBound = 0;

            while (lowerBound <= upperBound)
            {
                middle = (lowerBound + upperBound) / 2;

                if (array[middle] == searchedValue)
                {
                    return array[middle];
                }
                else if (searchedValue < array[middle])
                {
                    upperBound = middle - 1;
                }
                else // searched value is higher
                {
                    lowerBound = middle + 1;
                }
            }

            return -1;
        }
    }
}
