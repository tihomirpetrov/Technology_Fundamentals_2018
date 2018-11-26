namespace P07.AppendArrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        public static void Main()
        {
            List<string> sequence = Console.ReadLine().Split("|").Reverse().ToList();
            List<string> result = new List<string>();

            for (int i = 0; i < sequence.Count; i++)
            {
                List<string> final = new List<string>();
                final = sequence[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                result.AddRange(final);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}