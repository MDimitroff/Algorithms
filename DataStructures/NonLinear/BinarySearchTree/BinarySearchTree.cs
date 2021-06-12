using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTree<T>
    {
        public Node<T> RootNode { get; set; }

        public BinarySearchTree()
        {
            RootNode = null;
        }

        public void Insert(T value)
        {
            var newNode = new Node<T>();
            newNode.Value = value;
            
            if (RootNode == null)
            {
                RootNode = newNode;
                return;
            }

            // Traverse the tree
            var current = RootNode;
            Node<T> parent;

            while (true)
            {
                parent = current;

                if (value is int insertedValue)
                {
                    int currentNodeValue = int.Parse(current.Value.ToString());

                    if (insertedValue < currentNodeValue)
                    {
                        current = current.LeftNode;
                        if (current == null)
                        {
                            parent.LeftNode = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.RightNode;
                        if (current == null)
                        {
                            parent.RightNode = newNode;
                            break;
                        }
                    }
                }
            }
        }

        public void DisplayNode(Node<T> node)
        {
            Console.WriteLine(node.Value);
        }

        public Node<T> Find(T item)
        {
            Node<T> current = RootNode;

            if (item is int valueToFind)
            {
                int currentValue;
                while ((currentValue = int.Parse(current.Value.ToString())) != valueToFind)
                {
                    if (valueToFind < currentValue)
                    {
                        current = current.LeftNode;
                        if (current == null)
                        {
                            return null;
                        }
                    }
                    else
                    {
                        current = current.RightNode;
                        if (current == null)
                        {
                            return null;
                        }
                    }
                }

                return current;
            }
            else
            {
                throw new ArgumentException($"The provided value for T is of an invalid type");
            }
        }

        public bool Exists(T item)
        {
            return Find(item) != null;
        }

        /// <summary>
        /// Traverses the tree in an ascending numerical order
        /// </summary>
        /// <param name="node"></param>
        public void InOrder(Node<T> node)
        {
            if (node != null)
            {
                InOrder(node.LeftNode);
                DisplayNode(node);
                InOrder(node.RightNode);
            }
        }

        public class Node<V>
        {
            public V Value { get; set; }
            public Node<V> LeftNode { get; set; }
            public Node<V> RightNode { get; set; }
        }
    }
}
