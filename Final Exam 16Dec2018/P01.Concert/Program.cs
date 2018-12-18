namespace P01.FinalExam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> bandNameMembers = new Dictionary<string, List<string>>();
            Dictionary<string, int> bandNameTime = new Dictionary<string, int>();


            while (input != "start of concert")
            {
                string[] tokens = input.Split("; ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = tokens[0];

                if (command == "Add")
                {
                    string band = tokens[1];
                    if (!bandNameMembers.ContainsKey(band))
                    {
                        bandNameMembers.Add(band, new List<string>());
                    }
                    string[] members = tokens[2].Split(", ").ToArray();
                    for (int i = 0; i < members.Length; i++)
                    {
                        string member = members[i];
                        if (!bandNameMembers[band].Contains(member))
                        {
                            bandNameMembers[band].Add(member);
                        }
                    }
                }

                if (command == "Play")
                {
                    string band = tokens[1];
                    int time = int.Parse(tokens[2]);

                    if (!bandNameTime.ContainsKey(band))
                    {
                        bandNameTime.Add(band, 0);
                    }
                    bandNameTime[band] += time;
                }

                input = Console.ReadLine();
            }

            int totalTime = bandNameTime.Values.Sum();

            Console.WriteLine($"Total time: {totalTime}");

            foreach (var item in bandNameTime.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

            string bestBand = Console.ReadLine();
            foreach (var band in bandNameMembers)
            {
                if (band.Key == bestBand)
                {
                    Console.WriteLine($"{band.Key}");
                    foreach (var item in band.Value)
                    {
                        Console.WriteLine($"=> {item}");
                    }
                }
            }
        }
    }
}