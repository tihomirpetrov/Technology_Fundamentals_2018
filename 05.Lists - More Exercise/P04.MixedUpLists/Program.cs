namespace P04.MixedUpLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main(string[] args)
        {
            List<int> firstLineNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondLineNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> combinedNumbers = new List<int>();

            while (true)
            {
                if (firstLineNumbers.Count == 0 || secondLineNumbers.Count == 0)
                {
                    break;
                }
                combinedNumbers.Add(firstLineNumbers[0]);
                combinedNumbers.Add(secondLineNumbers[secondLineNumbers.Count - 1]);
                firstLineNumbers.RemoveAt(0);
                secondLineNumbers.RemoveAt(secondLineNumbers.Count - 1);
            }

            int startIndex = 0;
            int endIndex = 0;

            if (firstLineNumbers.Count > 0)
            {
                if (firstLineNumbers[0] > firstLineNumbers[1])
                {
                    startIndex = firstLineNumbers[1];
                    endIndex = firstLineNumbers[0];
                }
                else
                {
                    startIndex = firstLineNumbers[0];
                    endIndex = firstLineNumbers[1];
                }
            }
            else
            {
                if (secondLineNumbers[0] > secondLineNumbers[1])
                {
                    startIndex = secondLineNumbers[1];
                    endIndex = secondLineNumbers[0];
                }
                else
                {
                    startIndex = secondLineNumbers[0];
                    endIndex = secondLineNumbers[1];
                }
            }

            List<int> result = new List<int>();

            foreach (var number in combinedNumbers)
            {
                if (number > startIndex && number < endIndex)
                {
                    result.Add(number);
                }
            }

            result.Sort();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}