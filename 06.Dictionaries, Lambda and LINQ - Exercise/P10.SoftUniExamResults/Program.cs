namespace P10.SoftUniExamResults
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, int> userPoints = new Dictionary<string, int>();
            Dictionary<string, int> languageCounts = new Dictionary<string, int>();

            while (input != "exam finished")
            {
                string[] tokens = input.Split("-").ToArray();
                string username = tokens[0];
                string banned = tokens[1];

                if (tokens.Length == 2)
                {
                    userPoints.Remove(username);
                    break;
                }

                string language = tokens[1];
                int points = int.Parse(tokens[2]);

                if (!userPoints.ContainsKey(username))
                {
                    userPoints[username] = points;
                }
                else
                {
                    if (points > userPoints[username])
                    {
                        userPoints[username] = points;
                    }
                }

                if (!languageCounts.ContainsKey(language))
                {
                    languageCounts[language] = 1;
                }
                else
                {
                    languageCounts[language]++;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");
            Console.WriteLine(string.Join(Environment.NewLine, userPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Select(a => $"{a.Key} | {a.Value}")));

            Console.WriteLine("Submissions:");
            Console.WriteLine(string.Join(Environment.NewLine, languageCounts.OrderByDescending(a => a.Value).ThenBy(a => a.Key).Select(a => $"{a.Key} - {a.Value}")));

        }
    }
}