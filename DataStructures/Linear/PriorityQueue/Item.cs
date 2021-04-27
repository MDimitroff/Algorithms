namespace PriorityQueue
{
    public struct Item<T> : IPriorityQueueItem<T>
    {
        public int Priority { get; set; }
        public T Value { get; set; }
    }

    public interface IPriorityQueueItem<T>
    {
        int Priority { get; set; }
        T Value { get; set; }
    }
}
