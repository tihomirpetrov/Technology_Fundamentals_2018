namespace P03.WordSynonyms
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonymos = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!synonymos.ContainsKey(word))
                {
                    synonymos.Add(word, new List<string>());
                }

                var existingWords = synonymos[word];
                existingWords.Add(synonym);
            }

            foreach (var synonym in synonymos)
            {
                string wordKVP = synonym.Key;
                List<string> synonymKVP = synonym.Value;

                Console.WriteLine($"{wordKVP} - {(string.Join(", ", synonymKVP))}");
            }
        }
    }
}