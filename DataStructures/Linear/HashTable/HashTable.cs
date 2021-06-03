using System;
using System.Collections.Generic;

namespace HashTable
{
    public class HashTable<К, T> 
    {
        private T[] innerArray { get; set; }
        public int Count { get; set; }

        public HashTable()
        {
            innerArray = new T[10007]; // Horner's rule
            Count = 0;
        }

        public T this[int index]
        {
            get => GetValue(index);
            set => SetValue(index, value);
        }

        public T this[string index]
        {
            get => GetValue(index);
            set => SetValue(index, value);
        }

        private int GetHash<K>(K key)
        {
            int index = 0;
            if (key is string str)
            {
                char[] chars = str.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    index += 37 * index + chars[i];
                }

                index = index % innerArray.Length;
                if (index < 0)
                    index += innerArray.Length;
            }
            else if (key is int integer)
            {
                integer = ((integer >> 16) ^ integer) * 0x45d9f3b;
                integer = ((integer >> 16) ^ integer) * 0x45d9f3b;
                integer = (integer >> 16) ^ integer;
                integer = integer % innerArray.Length;
                index = integer;
            }
            else
            {
                throw new NotSupportedException("Not supported key type. Key can be either string or int.");
            }

            return index;
        }

        private T GetValue<K>(K key)
        {
            var hash = GetHash(key);
            return innerArray[hash];
        }

        private void SetValue<K>(K key, T value)
        {
            var hash = GetHash(key);
            innerArray[hash] = value;
        }

        public void Add<K>(K key, T value)
        {
            var hash = GetHash(key);
            innerArray[hash] = value;
            Count++;
        }

        public T Get<K>(K key)
        {
            var hash = GetHash(key);
            var item = innerArray[hash];

            return item;
        }

        public void Remove<K>(K key)
        {
            var hash = GetHash(key);
            innerArray[hash] = default(T);
            Count--;
        }

        public void ShowDistribution()
        {
            Console.WriteLine($"HashTable size {Count}");
            Console.WriteLine("-------------------");
            for (int i = 0; i < innerArray.Length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(innerArray[i], default(T)))
                {
                    continue;
                }

                Console.WriteLine($"[{i}] => {innerArray[i]}");
            }
            Console.WriteLine("-----------------");
        }
    }
}
