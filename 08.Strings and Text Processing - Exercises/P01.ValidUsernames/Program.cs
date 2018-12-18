namespace P01.ValidUsernames
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();
            string pattern = @"(^[A-Za-z0-9-_]*$)";

            Regex regex = new Regex(pattern);
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length >= 3 && input[i].Length <= 16)
                {
                    Match match = Regex.Match(input[i], pattern);
                    if (match.Success)
                    {
                        string output = match.Groups[1].Value;
                        Console.WriteLine(output);
                    }
                }
            }
        }
    }
}