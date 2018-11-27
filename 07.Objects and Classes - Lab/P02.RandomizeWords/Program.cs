namespace P02.RandomizeWords
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split().ToArray();
            Random rnd = new Random();

            for (int i = 0; i < words.Length - 1; i++)
            {
                int firstWord = rnd.Next(0, words.Length);
                int secondWord = rnd.Next(0, words.Length);

                string changedWord = words[firstWord];
                words[firstWord] = words[secondWord];
                words[secondWord] = changedWord;
            }
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}