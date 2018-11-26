namespace P04.ReverseArrayOfStrings
{
    using System;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split().ToArray();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write($"{input[i]} ");
            }
        }
    }
}