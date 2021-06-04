using System;

namespace QueueWithStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new QueueWithStack<int>();
            queue.EnQueue(0);
            queue.EnQueue(1);
            queue.EnQueue(2);

            Console.WriteLine($"Values are \n {queue.DeQueue()} \n {queue.DeQueue()} \n {queue.DeQueue()}");
        }
    }
}
