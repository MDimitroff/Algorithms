using System;
using System.Collections.Generic;

namespace CustomLinkedList
{
    public class CustomLinkedList<T>
    {
        protected Node<T> header;
        public int Count;

        public CustomLinkedList()
        {
            header = new Node<T>(default);
            Count = 0;
        }

        public bool Contains(T item)
        {
            var node = Find(item);
            return node != null;
        }

        public void Insert(T item)
        {
            var newNode = new Node<T>(item);
            Count++;
            if (header.Link == null)
            {
                header.Link = newNode;
                return;
            }

            var current = header;
            while (current.Link != null)
            {
                current = current.Link;
            }

            current.Link = newNode;
        }

        public void InsertAfter(T item, T after)
        {
            var newNode = new Node<T>(item);
            var afterNode = Find(after);
            newNode.Link = afterNode.Link;
            afterNode.Link = newNode;
            Count++;
        }

        public void Remove(T item)
        {
            var current = header;
            Node<T> previousNode = null;

            while (current.Link != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Item, item))
                {
                    previousNode.Link = current.Link;
                    Count--;
                    break;
                }

                previousNode = current;
                current = current.Link;
            }
        }

        public void Clear()
        {
            header.Link = null;
            Count = 0;
        }

        public void Dump()
        {
            Console.WriteLine();
            Console.WriteLine($"List contains the following { Count } items:");
            var current = header;
            while (current.Link != null)
            {
                T item = current.Item;
                current = current.Link;

                if (EqualityComparer<T>.Default.Equals(item, default)) // skip the header
                    continue;

                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"{current.Item}");
            Console.WriteLine();
        }

        public void ReverseItems()
        {
            var values = new Stack<T>();
            var current = header;

            while (current.Link != null)
            {
                T item = current.Item;
                current = current.Link;

                if (EqualityComparer<T>.Default.Equals(item, default))
                    continue;

                values.Push(item);
            }

            values.Push(current.Item);

            Console.WriteLine("List's items in reversed order");
            while (values.Count > 0)
            {
                Console.WriteLine(values.Pop());
            }
        }

        private Node<T> Find(T item)
        {
            var currentNode = header;
            while (!EqualityComparer<T>.Default.Equals(currentNode.Item, item))
            {
                currentNode = currentNode.Link;
            }

            return currentNode;
        }

        protected class Node<V>
        {
            public V Item;
            public Node<V> Link;

            public Node()
            {
                Item = default;
                Link = null;
            }

            public Node(V item)
            {
                Item = item;
                Link = null;
            }
        }
    }
}
