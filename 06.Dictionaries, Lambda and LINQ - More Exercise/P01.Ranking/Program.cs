namespace P01.Ranking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            string inputPartOne = Console.ReadLine();
            Dictionary<string, string> contestPass = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> submissionPoints = new Dictionary<string, Dictionary<string, int>>();

            while (inputPartOne != "end of contests")
            {
                string[] tokens = inputPartOne.Split(":").ToArray();
                string contest = tokens[0];
                string password = tokens[1];

                if (!contestPass.ContainsKey(contest))
                {
                    contestPass[contest] = password;
                }

                inputPartOne = Console.ReadLine();
            }

            string inputSubmissions = Console.ReadLine();

            while (inputSubmissions != "end of submissions")
            {
                string[] tokens = inputSubmissions.Split("=>").ToArray();
                string contest = tokens[0];
                string password = tokens[1];
                string user = tokens[2];
                int points = int.Parse(tokens[3]);

                if (contestPass.ContainsKey(contest) && contestPass[contest] == password)
                {

                    if (!submissionPoints.ContainsKey(user))
                    {
                        submissionPoints.Add(user, new Dictionary<string, int>());
                        submissionPoints[user].Add(contest, points);
                    }

                    else
                    {
                        if (!submissionPoints[user].ContainsKey(contest))
                        {
                            submissionPoints[user].Add(contest, points);
                        }
                        else
                        {
                            if (points > submissionPoints[user][contest])
                            {
                                submissionPoints[user][contest] = points;
                            }
                        }
                    }
                }

                inputSubmissions = Console.ReadLine();
            }

            var submissionPointsFiltered = submissionPoints.OrderByDescending(x => x.Value.Values.Sum()).Take(1);
            int bestPoints = 0;
            string bestCandidate = string.Empty;


            foreach (var candidate in submissionPointsFiltered)
            {
                bestCandidate = candidate.Key;

                foreach (var item in candidate.Value)
                {
                    bestPoints += item.Value;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestPoints} points.");
            Console.WriteLine("Ranking: ");

            foreach (var kvp in submissionPoints.OrderBy(x => x.Key))
            {
                Console.WriteLine(kvp.Key);

                foreach (var item in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}