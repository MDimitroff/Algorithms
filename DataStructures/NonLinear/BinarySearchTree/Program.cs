using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var bst = new BinarySearchTree<int>();
            bst.Insert(23);
            bst.Insert(45);
            bst.Insert(16);
            bst.Insert(37);
            bst.Insert(3);
            bst.Insert(99);
            bst.Insert(22);

            Console.WriteLine("InOrder traversal:");
            bst.InOrder(bst.RootNode);

            Console.WriteLine($"Value exists? {bst.Exists(2)}");


        }
    }
}