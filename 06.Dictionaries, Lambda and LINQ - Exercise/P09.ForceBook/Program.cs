namespace P09.ForceBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            Dictionary<string, string> forceUser = new Dictionary<string, string>();


            while (command != "Lumpawaroo")
            {
                string[] input = command.Split().ToArray();

                string delimeter = input[1];


                if (delimeter == "|")
                {
                    string side = input[0];
                    string user = input[2];

                    if (!forceUser.ContainsKey(user))
                    {
                        forceUser[user] = side;
                    }

                }
                if (delimeter == "->")
                {
                    string user = input[0];
                    string side = input[2];

                    if (forceUser.ContainsKey(user))
                    {
                        forceUser[user] = side;
                    }
                    else
                    {
                        forceUser[user] = side;
                    }

                    Console.WriteLine($"{user} joins the {side} side!");
                }

                command = Console.ReadLine();
            }

            var filteredNameSide = forceUser.GroupBy(x => x.Value).OrderByDescending(x => x.Count()).ThenBy(x => x.Key);

            foreach (var user in filteredNameSide)
            {
                string side = user.Key;
                var nameSideValue = user;

                Console.WriteLine($"Side: {side}, Members: {nameSideValue.Count()}");

                foreach (var item in user.OrderBy(x => x.Key))
                {
                    string name = item.Key;
                    string side2 = item.Value;
                    Console.WriteLine($"! {name}");
                }

            }
        }
    }
}