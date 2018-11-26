namespace P04.ArrayRotation
{
    using System;
    using System.Linq;
    class Startup
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int firstNumber = input[0];
                for (int j = 0; j < input.Length - 1; j++)
                {
                    input[j] = input[j + 1];
                }
                input[input.Length - 1] = firstNumber;
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}