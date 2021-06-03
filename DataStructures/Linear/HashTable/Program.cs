using System;
using System.IO;
using System.Text;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashTable = new HashTable<int, string>();
            string line;

            using (var reader = new StreamReader("./Names.txt"))
            {
                int row = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    row++;
                    hashTable.Add(row, line.Trim());
                }
            }

            hashTable.ShowDistribution();
            
            var rand = new Random();
            int randomIndex = rand.Next(1, hashTable.Count);
            var name = hashTable[randomIndex];
            Console.WriteLine($"At index {randomIndex} the stored value is {name}");
            hashTable[randomIndex] = "MDI";
            name = hashTable[randomIndex];
            Console.WriteLine($"At index {randomIndex} the stored value is {name}");
            Console.WriteLine("Removing the value");
            hashTable.Remove(randomIndex);

            Console.Read();
        }
    }
}
