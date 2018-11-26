namespace P05.TopIntegers
{
    using System;
    using System.Linq;
    class Startup
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                int number = input[i];
                for (int j = i + 1; j < input.Length; j++)
                {
                    int secondNumber = input[j];
                    if (number <= secondNumber)
                    {
                        break;
                    }
                    else if (j == input.Length - 1)
                    {
                        Console.Write(number + " ");
                    }
                }
            }
            Console.WriteLine(input[input.Length - 1]);
        }
    }
}