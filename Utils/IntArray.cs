using System;

namespace Utils
{
    public class IntArray
    {
        private int[] innerArray;
        private int upperBound;
        private int position;

        public IntArray(int size)
        {
            innerArray = new int[size];
            upperBound = --size;
            position = 0;
        }

        public void Insert(int item)
        {
            if (position + 1 > upperBound)
            {
                throw new InvalidOperationException("Array's capacity is full.");
            }

            innerArray[++position] = item;
        }

        public void DisplayValues()
        {
            for (int i = 0; i <= upperBound; i++)
            {
                Console.Write($"{innerArray[i]} ");
            }

            Console.WriteLine();
        }

        public void Clear()
        {
            for (int i = 0; i <= upperBound; i++)
            {
                innerArray[0] = 0;
            }

            position = 0;
        }

        public void GenerateRandomValues(int seed)
        {
            var rand = new Random();
            for (int i = 0; i <= upperBound; i++)
            {
                innerArray[i] = rand.Next(seed);
            }

            position = upperBound;
        }

        public int[] ToArray()
        {
            return innerArray;
        }
    }
}
