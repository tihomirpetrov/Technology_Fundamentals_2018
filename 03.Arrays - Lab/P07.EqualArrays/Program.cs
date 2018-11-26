namespace P07.EqualArrays
{
    using System;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            int[] firstNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            bool isTrue = false;
            for (int i = 0; i < firstNumbers.Length; i++)
            {
                if (firstNumbers[i] != secondNumbers[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    isTrue = true;
                    break;
                }
                else
                {
                    sum += firstNumbers[i];
                }
            }

            if (!isTrue)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}