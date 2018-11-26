namespace P03.HouseParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        public static void Main()
        {
            int commands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            string name = string.Empty;

            for (int i = 0; i < commands; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                name = input[0];

                if (input[2] == "going!")
                {
                    if (guests.Contains(name) && i > 0)
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }

                else if (input[2] == "not")
                {
                    if (guests.Contains(name) && i > 0)
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests[i]);
            }
        }
    }
}