namespace P07.MergingLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            List<int> firstNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int bigger = 0;
            int smaller = 0;

            if (firstNumbers.Count >= secondNumbers.Count)
            {
                bigger = firstNumbers.Count;
                smaller = secondNumbers.Count;
            }
            else
            {
                bigger = secondNumbers.Count;
                smaller = firstNumbers.Count;
            }

            for (int i = 0; i < smaller; i++)
            {
                result.Add(firstNumbers[i]);
                result.Add(secondNumbers[i]);
            }

            for (int i = smaller; i < bigger; i++)
            {
                if (bigger == firstNumbers.Count)
                {
                    result.Add(firstNumbers[i]);
                }
                else
                {
                    result.Add(secondNumbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}