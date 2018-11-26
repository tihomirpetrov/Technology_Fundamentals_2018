namespace P08.AnonymousThreat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            string commands = Console.ReadLine();

            while (commands != "3:1")
            {
                string[] tokens = commands.Split().ToArray();
                string command = tokens[0];

                if (command == "merge")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);

                    if (startIndex < 0 || startIndex >= input.Count)
                    {
                        startIndex = 0;
                    }

                    if (endIndex >= input.Count || endIndex < 0)
                    {
                        endIndex = input.Count - 1;
                    }
                    string word = string.Empty;

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        word += input[i];
                    }
                    input.RemoveRange(startIndex, endIndex - startIndex + 1);
                    input.Insert(startIndex, word);
                }
                else if (command == "divide")
                {
                    int index = int.Parse(tokens[1]);
                    int partitions = int.Parse(tokens[2]);
                    string element = input[index];
                    input.RemoveAt(index);

                    List<string> newWords = Divide(element, partitions);

                    input.InsertRange(index, newWords);
                }

                commands = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", input));
        }

        private static List<string> Divide(string element, int parts)
        {
            List<string> newWords = new List<string>();
            int partLength = element.Length / parts;
            int lastPartLength = partLength + element.Length % parts;


            for (int i = 0; i < parts; i++)
            {
                string newWord = element.Substring(i * partLength, partLength);

                if (i == parts - 1)
                {
                    newWord = element.Substring(i * partLength, lastPartLength);
                }

                newWords.Add(newWord);
            }

            return newWords;
        }
    }
}
