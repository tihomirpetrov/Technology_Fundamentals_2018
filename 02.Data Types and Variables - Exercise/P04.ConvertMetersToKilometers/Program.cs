namespace P04.ConvertMetersToKilometres
{
    using System;
    class Startup
    {
        public static void Main()
        {
            double meters = int.Parse(Console.ReadLine());
            double km = meters / 1000;
            Console.WriteLine($"{km:f2}");
        }
    }
}