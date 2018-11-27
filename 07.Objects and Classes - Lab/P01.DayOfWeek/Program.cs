namespace P01.DayOfWeek
{
    using System;
    using System.Globalization;

    class Program
    {
        static void Main()
        {
            string date = Console.ReadLine();
            DateTime dt = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(dt.DayOfWeek);
        }
    }
}