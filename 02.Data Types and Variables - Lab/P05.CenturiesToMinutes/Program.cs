namespace P05.CenturiesToMinutes
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int years = n * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{n} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}