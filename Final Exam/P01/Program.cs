namespace P01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> wordDefinitions = new Dictionary<string, List<string>>();
            string[] input = Console.ReadLine().Split(" | ");

            for (int i = 0; i < input.Length; i++)
            {
                string[] line = input[i].Split(": ");
                string definition = line[1];
                string word = line[0];

                if (!wordDefinitions.ContainsKey(word))
                {
                    wordDefinitions.Add(word, new List<string>());
                }
                wordDefinitions[word].Add(definition);
            }

            string[] input2 = Console.ReadLine().Split(" | ");

            for (int i = 0; i < input2.Length; i++)
            {
                string name = input2[i];

                foreach (var def in wordDefinitions)
                {
                    if (def.Key == name)
                    {
                        Console.WriteLine(def.Key);
                        foreach (var item in def.Value.OrderByDescending(x => x.Length))
                        {
                            Console.WriteLine($" -{item}");
                        }
                    }
                }
            }

            string input3 = Console.ReadLine();

            if (input3 == "List")
            {
                foreach (var def in wordDefinitions.OrderBy(x => x.Key))
                {
                    Console.Write(def.Key + " ");
                }
                Console.WriteLine();
            }

            //if (input3 == "End")
            //{
            //    return;
            //}
        }
    }
}
