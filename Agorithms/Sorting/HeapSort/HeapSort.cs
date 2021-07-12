using System;

namespace HeapSort
{
    public class HeapSort
    {
        public int Size { get; set; }
        private int _currentSize;
        private readonly Node[] _heapArray;

        public HeapSort(int size)
        {
            Size = size;
            _heapArray = new Node[size];
            _currentSize = 0;
        }

        public void Sort()
        {
            int leftPart = Size / 2;

            for (int i = leftPart - 1; i > 0; i--)
            {
                ShiftDown(i);
            }
        }

        public void Insert(int value)
        {
            if (_currentSize == Size)
            {
                throw new ArgumentOutOfRangeException("The array went out of range");
            }

            var newNode = new Node(value);
            _heapArray[_currentSize] = newNode;
            ShiftUp(_currentSize);
            _currentSize++;
        }

        public void Remove(int value)
        {
            _currentSize--;

            _heapArray[0] = _heapArray[_currentSize];
            ShiftDown(0);
        }

        public void Dump()
        {
            foreach (var item in _heapArray)
            {
                Console.Write($"{item.Value} ");
            }
            Console.WriteLine();
        }

        private void ShiftUp(int index)
        {
            int parent = (index - 1) / 2;
            var bottom = _heapArray[index];

            while (index > 0 && _heapArray[parent].Value < bottom.Value)
            {
                _heapArray[index] = _heapArray[parent];
                index = parent;
                parent = (index - 1) / 2;
            }

            _heapArray[index] = bottom;
        }

        private void ShiftDown(int index)
        {
            int largerChild;
            var topNode = _heapArray[index];

            while (index < _currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;

                if (rightChild < _currentSize && _heapArray[leftChild].Value < _heapArray[rightChild].Value)
                {
                    largerChild = rightChild;
                }
                else
                {
                    largerChild = leftChild;
                }

                if (topNode.Value >= _heapArray[largerChild].Value)
                {
                    break;
                }

                _heapArray[index] = _heapArray[largerChild];
                index = largerChild;
            }

            _heapArray[index] = topNode;
        }

        public class Node
        {
            public int Value { get; set; }

            public Node(int key)
            {
                Value = key;
            }
        }
    }
}
