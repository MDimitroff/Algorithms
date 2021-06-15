using System;

namespace CustomSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var set = new CustomSet();
            set.Add("Sofia");
            set.Add("Plovdiv");
            set.Add("Varna");

            var secondSet = new CustomSet();
            secondSet.Add("Sofia");
            secondSet.Add("Vidin");
            secondSet.Add("Burgas");

            Console.WriteLine("Set 1");
            set.Dump();

            Console.WriteLine();

            Console.WriteLine("Set 2");
            secondSet.Dump();

            var union = set.Union(secondSet);
            var intersection = set.Intersection(secondSet);
            var difference = set.Difference(secondSet);
            var difference2 = secondSet.Difference(set);
            var isSubset = set.IsSubset(secondSet);

            Console.WriteLine($"Is set 1 a subset of set 2? Anser is {isSubset}");
            Console.WriteLine("The union between set 1 and set 2 is:");
            union.Dump();
            Console.WriteLine();

            Console.WriteLine("The intersection between set 1 and set 2 is:");
            intersection.Dump();
            Console.WriteLine();

            Console.WriteLine("The difference between set 1 and set 2 is:");
            difference.Dump();
            Console.WriteLine();

            Console.WriteLine("The difference between set 2 and set 1 is:");
            difference2.Dump();
            Console.WriteLine();
        }
    }
}
