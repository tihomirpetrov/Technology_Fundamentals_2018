namespace P07.TriplesOfLatinLetters
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (char first = 'a'; first < 'a' + n; first++)
            {
                for (char second = 'a'; second < 'a' + n; second++)
                {
                    for (char third = 'a'; third < 'a' + n; third++)
                    {
                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }
        }
    }
}