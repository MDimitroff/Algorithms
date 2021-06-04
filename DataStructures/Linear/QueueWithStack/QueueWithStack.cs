using System.Collections.Generic;

namespace QueueWithStack
{
    public class QueueWithStack<T>
    {
        private readonly Stack<T> _stack;
        public int Count { get; set; }

        public QueueWithStack()
        {
            _stack = new Stack<T>();
            Count = 0;
        }

        public void EnQueue(T item)
        {
            _stack.Push(item);
            Count++;
        }

        public T DeQueue()
        {
            Stack<T> stack = new Stack<T>();

            while (_stack.Count > 0)
            {
                stack.Push(_stack.Pop());
            }

            T item = stack.Pop();
            Count--;

            while (stack.Count > 0)
            {
                _stack.Push(stack.Pop());
            }

            return item;
        }
    }
}
