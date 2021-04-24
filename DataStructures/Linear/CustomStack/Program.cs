using System;

namespace CustomStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new CustomStack<string>();
            stack.Push("Sofia");
            stack.Push("Varna");
            stack.Push("Burgas");
            stack.Push("Plovdiv");

            int stackLenght = stack.Length;
            Console.WriteLine($"Printing stack values. Stack length {stackLenght}");

            for (int i = 0; i < stackLenght; i++)
            {
                Console.WriteLine($"{stack.Pop()}");
            }

            Console.WriteLine($"Operation completed. Stack length {stack.Length}");
            Console.WriteLine("Adding many more elements to the stack to trigger resizing");

            for (int i = 0; i < 100; i++)
            {
                stack.Push($"Sofia {i}");
            }

            stack.DisplayStatistics();

            while (stack.Length > 0)
            {
                Console.WriteLine($"Value: {stack.Pop()}");
            }
        }
    }
}
