namespace P02.CharacterMultiplier
{
    using System;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string str1 = input[0];
            string str2 = input[1];
            int totalSum = 0;
            int startIndex = Math.Min(str1.Length, str2.Length);
            int endIndex = Math.Max(str1.Length, str2.Length);

            if (str1.Length == str2.Length)
            {
                for (int i = 0; i < startIndex; i++)
                {
                    totalSum += (char)str1[i] * (char)str2[i];
                }
            }

            else if (str1.Length > str2.Length)
            {
                for (int i = 0; i < startIndex; i++)
                {
                    totalSum += (char)str1[i] * (char)str2[i];
                }
                for (int i = startIndex; i < endIndex; i++)
                {
                    totalSum += str1[i];
                }
            }
            else if (str2.Length > str1.Length)
            {
                for (int i = 0; i < startIndex; i++)
                {
                    totalSum += (char)str1[i] * (char)str2[i];
                }
                for (int i = startIndex; i < endIndex; i++)
                {
                    totalSum += str2[i];
                }
            }

            Console.WriteLine(totalSum);
        }
    }
}