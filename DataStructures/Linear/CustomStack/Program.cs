using System;

namespace CustomStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new CustomStack<string>();
            stack.Push("Martin");
            stack.Push("Evgenia");
            stack.Push("Adrian");
            stack.Push("Alexandra");

            int stackLenght = stack.Lenght;
            Console.WriteLine($"Printing stack values. Stack length {stackLenght}");

            for (int i = 0; i < stackLenght; i++)
            {
                Console.WriteLine($"{stack.Pop()}");
            }

            Console.WriteLine($"Operation completed. Stack length {stack.Lenght}");
        }
    }
}
