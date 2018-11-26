namespace P05.PoundsToDollars
{
    using System;
    class Startup
    {
        public static void Main()
        {
            decimal gbp = decimal.Parse(Console.ReadLine());
            decimal dollars = gbp * 1.31M;
            Console.WriteLine($"{dollars:f3}");
        }
    }
}