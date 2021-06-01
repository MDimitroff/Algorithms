using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class HashTable<T>
    {
        private T[] innerArray { get; set; }

        public HashTable()
        {
            innerArray = new T[10007]; // Horner's rule
        }

        private int GetHashCode(string key)
        {
            char[] chars = key.ToCharArray();
            int total = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                total += 37 * total + (int)chars[i];
            }

            total = total % innerArray.Length;
            if (total < 0)
                total += innerArray.Length;

            return total;
        }

        public void Add(string key, T value)
        {
            var hash = GetHashCode(key);
            innerArray[hash] = value;
        }

        public T Get(string key)
        {
            var hash = GetHashCode(key);
            var item = innerArray[hash];

            return item;
        }

        public void ShowDistribution()
        {
            for (int i = 0; i < innerArray.Length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(innerArray[i], default(T)))
                {
                    continue;
                }

                Console.WriteLine($"[{i}] => {innerArray[i]}");
            }
        }
    }
}
