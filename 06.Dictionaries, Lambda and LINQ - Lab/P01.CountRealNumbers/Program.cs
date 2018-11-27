namespace P01.CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts[number] = 1;
                }
            }

            foreach (var number in counts.Keys)
            {
                Console.WriteLine($"{number} -> {counts[number]}");
            }
        }
    }
}