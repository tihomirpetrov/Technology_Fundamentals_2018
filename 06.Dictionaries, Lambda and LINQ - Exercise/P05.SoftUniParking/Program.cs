namespace P05.SoftUniParking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> userLicencePlate = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string command = input[0];
                string username = input[1];

                if (command == "register")
                {
                    string licensePlate = input[2];

                    if (!userLicencePlate.ContainsKey(username))
                    {
                        userLicencePlate.Add(username, licensePlate);
                        Console.WriteLine($"{username} registered {licensePlate} successfully");
                    }
                    else if (userLicencePlate.ContainsKey(username))
                    {
                        if (userLicencePlate.ContainsValue(licensePlate))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                        }
                    }
                }

                else if (command == "unregister")
                {
                    if (!userLicencePlate.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        userLicencePlate.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var user in userLicencePlate)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}