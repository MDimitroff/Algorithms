using System;

namespace CustomStack
{
    public class CustomStack<T>
    {
        private int index;
        private readonly double resizeFactor;
        private int resizeIteration;
        private T[] array;

        public int Length => index + 1;

        public CustomStack()
        {
            index = -1;
            resizeFactor = 1.5;
            resizeIteration = 0;
            array = new T[10];
        }

        public void Push(T element)
        {
            if (index + 1 > array.Length - 1)
            {
                Resize();
            }

            index++;
            array[index] = element;
        }

        public T Pop()
        {
            var element = array[index];
            array[index] = default;
            index--;

            return element;
        }

        public T Peek()
        {
            return array[index];
        }

        public void Clear()
        {
            for (int i = 0; i <= index; i++)
            {
                array[i] = default;
            }

            index = -1;
            resizeIteration = 0;
            Resize();
        }

        public void DisplayStatistics()
        {
            Console.WriteLine($"--- Stack statistics");
            Console.WriteLine($"Items in stack {Length}");
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
        }
    }
}
