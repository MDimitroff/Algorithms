using System;

namespace CustomQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new CustomQueue<string>();
            queue.EnQueue("Sofia");
            queue.EnQueue("Varna");
            queue.EnQueue("Burgas");
            queue.EnQueue("Plovdiv");

            int queueLenght = queue.Length;
            Console.WriteLine($"Printing the queue values. Queue length {queueLenght}");

            while (queue.Length > 0)
            {
                Console.WriteLine($"{queue.DeQueue()}");
            }

            queue.Clear();
            Console.WriteLine($"Operation completed. Queue length {queue.Length}");
            Console.WriteLine("Adding many more elements to the queue to trigger resizing");

            for (int i = 0; i < 100; i++)
            {
                queue.EnQueue($"Sofia {i}");
            }

            queue.DisplayStatistics();

            while (queue.Length > 0)
            {
                Console.WriteLine($"Value: {queue.DeQueue()}");
            }
        }
    }
}
