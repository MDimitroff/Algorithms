using CustomQueue;
using System.Linq;

namespace PriorityQueue
{
    public class PriorityQueue<T, U> : CustomQueue<T>
        where T : struct, IPriorityQueueItem<U>
    {
        public PriorityQueue() 
            : base()
        { }

        public new T DeQueue()
        {
            int highestPriority = int.MaxValue, 
                priorityIndex = 0;
            T[] originalArray = array.Where(a => a.Value != null).ToArray();

            for (int i = 0; i < Length; i++)
            {
                if (array[i].Priority < highestPriority)
                {
                    highestPriority = array[i].Priority;
                    priorityIndex = i;
                }
            }

            Clear();

            for (int i = 0; i < originalArray.Length; i++)
            {
                if (i != priorityIndex)
                {
                    EnQueue(originalArray[i]);
                }
            }

            return originalArray[priorityIndex];
        }
    }
}
