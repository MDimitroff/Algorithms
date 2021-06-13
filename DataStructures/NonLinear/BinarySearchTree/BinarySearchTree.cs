using System;

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
            
            while (true)
            {
                if (value is int insertedValue)
                {
                    int currentNodeValue = int.Parse(current.Value.ToString());

                    if (insertedValue < currentNodeValue)
                    {
                        if (current.LeftNode == null)
                        {
                            current.LeftNode = newNode;
                            break;
                        }

                        current = current.LeftNode;
                    }
                    else
                    {
                        if (current.RightNode == null)
                        {
                            current.RightNode = newNode;
                            break;
                        }

                        current = current.RightNode;
                    }
                }
            }
        }

        public void Delete(T item)
        {
            var found = Find(item);
            var current = found.node;
            var parent = found.parent;
            bool isLeftNode = found.isLeftNode;

            if (current == null)
                return;

            // Deleting a node that is a leaf node
            if (current.LeftNode == null && current.RightNode == null)
            {
                if (current == RootNode)
                {
                    RootNode = null;
                }
                else if (isLeftNode)
                {
                    parent.LeftNode = null;
                }
                else
                {
                    parent.RightNode = null;
                }
            }
            // Deleting a node with one children
            else if (current.RightNode == null)
            {
                if (current == RootNode)
                {
                    RootNode = current.LeftNode;
                }
                else if (isLeftNode)
                {
                    parent.LeftNode = current.LeftNode;
                }
                else
                {
                    parent.RightNode = current.RightNode;
                }
            }
            // Deleting a node with one children
            else if (current.LeftNode == null)
            {
                if (current == RootNode)
                {
                    RootNode = current.RightNode;
                }
                else if (isLeftNode)
                {
                    parent.LeftNode = parent.RightNode;
                }
                else
                {
                    parent.RightNode = current.RightNode;
                }
            }
            else // Deleting a node with two or more children
            {
                var successor = GetSuccessor(current);
                if (current == RootNode)
                {
                    RootNode = successor;
                }
                else if (isLeftNode)
                {
                    parent.LeftNode = successor;
                }
                else
                {
                    parent.RightNode = successor;
                }

                successor.LeftNode = current.LeftNode;
            }
        }

        public T FindMin()
        {
            var current = RootNode;

            while (current.LeftNode != null)
            {
                current = current.LeftNode;
            }

            return current.Value;
        }

        public T FindMax()
        {
            var current = RootNode;

            while (current.RightNode != null)
            {
                current = current.RightNode;
            }

            return current.Value;
        }

        public bool Exists(T item)
        {
            var result = Find(item);

            return result.node != null;
        }

        public void DisplayBinarySearchTree()
        {
            InOrder(RootNode);
        }

        private void DisplayNode(Node<T> node)
        {
            Console.WriteLine(node.Value);
        }

        private (Node<T> node, Node<T> parent, bool isLeftNode) Find(T item)
        {
            Node<T> current = RootNode;
            Node<T> parent = null;
            bool isLeftNode = false;

            if (item is int valueToFind)
            {
                int currentValue;
                while ((currentValue = int.Parse(current.Value.ToString())) != valueToFind)
                {
                    parent = current;
                    if (valueToFind < currentValue)
                    {
                        isLeftNode = true;
                        current = current.LeftNode;
                        if (current == null)
                        {
                            return (null, null, false);
                        }
                    }
                    else
                    {
                        isLeftNode = false;
                        current = current.RightNode;
                        if (current == null)
                        {
                            return (null, null, false);
                        }
                    }
                }

                return (current, parent, isLeftNode);
            }
            else
            {
                throw new ArgumentException($"The provided value for T is of an invalid type");
            }
        }

        private Node<T> GetSuccessor(Node<T> deletingNode)
        {
            var successorParent = deletingNode;
            var successor = deletingNode;
            var current = deletingNode.RightNode;

            while (current != null)
            {
                successorParent = current;
                successor = current;
                current = current.LeftNode;
            }

            if (successor != deletingNode.RightNode)
            {
                successorParent.LeftNode = successor.RightNode;
                successor.RightNode = deletingNode.RightNode;
            }

            return successor;
        }

        /// <summary>
        /// Traverses the tree in an ascending numerical order
        /// </summary>
        /// <param name="node"></param>
        private void InOrder(Node<T> node)
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
