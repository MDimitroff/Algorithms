using System;

namespace PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new Item<string>[]
            {
                new Item<string> { Priority = 2, Value = "Ruse" },
                new Item<string> { Priority = 1, Value = "Sofia" },
                new Item<string> { Priority = 0, Value = "Varna" },
                new Item<string> { Priority = 1, Value = "Burgas" },
                new Item<string> { Priority = 0, Value = "Plovdiv" },
                new Item<string> { Priority = 2, Value = "Vidin" }
            };

            var priorityQueue = new PriorityQueue<Item<string>, string>();
            foreach (var item in items)
            {
                priorityQueue.EnQueue(item);
            }

            while (priorityQueue.Length > 0)
            {
                var element = priorityQueue.DeQueue();
                Console.WriteLine($"Queue element: {element.Value} with priority {element.Priority}");
            }
        }
    }
}
