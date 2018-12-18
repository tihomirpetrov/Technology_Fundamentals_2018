namespace P02.Judge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> contestUserPoints = new Dictionary<string, Dictionary<string, int>>();

            while (input != "no more time")
            {
                string[] tokens = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string username = tokens[0];
                string contest = tokens[1];
                int points = int.Parse(tokens[2]);

                if (!contestUserPoints.ContainsKey(contest))
                {
                    contestUserPoints.Add(contest, new Dictionary<string, int>());
                }
                if (!contestUserPoints[contest].ContainsKey(username))
                {
                    contestUserPoints[contest].Add(username, 0);
                }
                //if (contestUserPoints[contest][username] < points)
                //{
                //    contestUserPoints[contest][username] = points;
                //}
                points = Math.Max(points, contestUserPoints[contest][username]);
                contestUserPoints[contest][username] = points;


                input = Console.ReadLine();
            }

            foreach (var contest in contestUserPoints)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Values.Count} participants");
                int counter = 1;
                foreach (var item in contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{counter}. {item.Key} <::> {item.Value}");
                    counter++;
                }
            }

            Dictionary<string, int> individualPoints = new Dictionary<string, int>();

            Console.WriteLine("Individual standings:");
            foreach (var contest in contestUserPoints)
            {
                foreach (var item in contest.Value)
                {
                    if (!individualPoints.ContainsKey(item.Key))
                    {
                        individualPoints.Add(item.Key, 0);
                    }
                    individualPoints[item.Key] += item.Value;
                }
            }

            int counter2 = 1;
            foreach (var item in individualPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{counter2}. {item.Key} -> {item.Value}");
                counter2++;
            }
        }
    }
}