﻿namespace P06.ReplaceRepeatingChars
{
    using System;
    using System.Text;

    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    input = input.Remove(i + 1, 1);
                    i--;
                }
            }
            Console.WriteLine(input);
        }
    }
}