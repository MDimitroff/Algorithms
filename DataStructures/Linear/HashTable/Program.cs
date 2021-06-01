using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashTable = new HashTable<int>();
            var rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                hashTable.Add($"Tom-{i}", rand.Next(2, 6));
            }

            hashTable.ShowDistribution();

            Console.Read();
        }
    }
}
