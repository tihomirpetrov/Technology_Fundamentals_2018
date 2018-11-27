namespace P05.Login
{
    using System;
    class Startup
    {
        public static void Main()
        {
            string username = Console.ReadLine();

            string password = string.Empty;

            for (int i = username.Length - 1; i > -1; i--)
            {
                password += username[i];
            }

            for (int i = 1; i <= 4; i++)
            {
                string input = Console.ReadLine();
                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }

                if (i == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
            }
        }
    }
}