namespace P01.CountCharsInAString
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        public static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();

            Dictionary<char, int> charsOfText = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                if (letter != ' ')
                {
                    if (!charsOfText.ContainsKey(letter))
                    {
                        charsOfText.Add(letter, 0);
                    }
                    charsOfText[letter]++;
                }
            }

            foreach (var letter in charsOfText)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}