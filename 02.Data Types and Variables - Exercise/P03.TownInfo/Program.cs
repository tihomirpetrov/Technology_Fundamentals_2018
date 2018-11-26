namespace P03.TownInfo
{
    using System;
    class Startup
    {
        public static void Main()
        {
            string city = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());
            Console.WriteLine($"Town {city} has population of {population} and area {area} square km.");
        }
    }
}