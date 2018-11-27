namespace P04.Largest3Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] sortedNumbers = numbers.OrderByDescending(n => n).ToArray();
            int endIndex = 3;

            for (int i = 0; i < endIndex; i++)
            {
                if (sortedNumbers.Length < endIndex)
                {
                    endIndex = sortedNumbers.Length;
                }

                Console.Write(sortedNumbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}