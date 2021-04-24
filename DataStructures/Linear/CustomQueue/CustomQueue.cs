using System;

namespace CustomQueue
{
    public class CustomQueue<T>
    {
        private int upperIndex;
        private int lowerIndex;
        private readonly double resizeFactor;
        private int resizeIteration;
        private T[] array;

        public int Length => upperIndex - lowerIndex;

        public CustomQueue()
        {
            lowerIndex = 0;
            upperIndex = 0;
            resizeFactor = 1.5;
            array = new T[10];
        }

        public void EnQueue(T element)
        {
            if (upperIndex + 1 > array.Length - 1)
            {
                Resize();
            }

            array[upperIndex] = element;
            upperIndex++;
        }

        public T DeQueue()
        {
            var element = array[lowerIndex];
            array[lowerIndex] = default;
            lowerIndex++;

            return element;
        }

        public T Peek()
        {
            return array[lowerIndex];
        }

        public void Clear()
        {
            for (int i = 0; i <= upperIndex; i++)
            {
                array[i] = default;
            }

            lowerIndex = 0;
            upperIndex = 0;
            resizeIteration = 0;
            Resize();
        }

        public void DisplayStatistics()
        {
            Console.WriteLine($"--- Queue statistics");
            Console.WriteLine($"Items in the queue {Length}");
            Console.WriteLine($"Inner array length {array.Length}");
            Console.WriteLine($"Resized {resizeIteration} times");
        }

        private void Resize()
        {
            resizeIteration++;
            int currentSize = array.Length;
            int newSize = (int)Math.Floor(currentSize * (resizeFactor * resizeIteration));
            var resizedArray = new T[newSize];

            for (int i = 0; i < currentSize; i++)
            {
                resizedArray[i] = array[i];
            }

            array = resizedArray;
            lowerIndex = 0;
        }
    }
}
