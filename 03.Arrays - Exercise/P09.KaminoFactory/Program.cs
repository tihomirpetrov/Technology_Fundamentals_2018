namespace P09.KaminoFactory
{
    using System;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            if (length < 1 && length > 100 || input == "Clone them!")
            {
                return;
            }
            int longestSubSequence = 0;
            int bestIndex = int.MaxValue;
            int bestSum = 0;
            int[] bestSequence = new int[length];
            int counter = 0;
            int bestCounter = 1;

            while (input != "Clone them!")
            {
                counter++;

                int[] dnaSequence = input.Split("!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int subSequence = 1;
                int dnaSum = 0;

                for (int i = 0; i < dnaSequence.Length; i++)
                {
                    if (dnaSequence[i] != 0 && dnaSequence[i] != 1)
                    {
                        return;
                    }
                    dnaSum += dnaSequence[i];
                }
                if (counter == 1)
                {
                    bestSequence = dnaSequence;
                    bestSum = dnaSum;
                }
                for (int i = 0; i < dnaSequence.Length; i++)
                {
                    for (int j = i + 1; j < dnaSequence.Length; j++)
                    {
                        if (dnaSequence[i] == dnaSequence[j] && dnaSequence[i] == 1)
                        {
                            subSequence++;
                        }
                        else
                        {
                            break;
                        }
                        if (subSequence > longestSubSequence)
                        {
                            longestSubSequence = subSequence;
                            bestIndex = i;
                            bestSum = dnaSum;
                            bestSequence = dnaSequence;
                            bestCounter = counter;
                        }
                        if (subSequence == longestSubSequence && bestIndex > i)
                        {
                            bestIndex = i;
                            bestSum = dnaSum;
                            bestSequence = dnaSequence;
                            bestCounter = counter;

                        }
                        if (subSequence == longestSubSequence && bestIndex == i && dnaSum > bestSum)
                        {
                            bestSum = dnaSum;
                            bestSequence = dnaSequence;
                            bestCounter = counter;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestCounter} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestSequence));
        }
    }
}