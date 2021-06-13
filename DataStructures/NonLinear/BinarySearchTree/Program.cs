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
            bst.DisplayBinarySearchTree();

            Console.WriteLine($"Value 2 exists? {bst.Exists(2)}");
            Console.WriteLine($"Min value is {bst.FindMin()}");
            Console.WriteLine($"Max value is {bst.FindMax()}");

            Console.WriteLine("Deleting value 37");
            bst.Delete(37);
            bst.DisplayBinarySearchTree();

            Console.WriteLine("Deleting value 45");
            bst.Delete(45);
            bst.DisplayBinarySearchTree();

        }
    }
}