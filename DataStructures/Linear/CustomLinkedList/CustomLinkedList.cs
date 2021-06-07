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

        public void Add(T item)
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

        public void Dump()
        {
            Console.WriteLine();
            Console.WriteLine($"List contains the following { Count } items:");
            var current = header;
            while (current.Link != null)
            {
                T item = current.Item;
                current = current.Link;

                if (EqualityComparer<T>.Default.Equals(item, default))
                    continue;

                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"{current.Item}");
            Console.WriteLine();
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
