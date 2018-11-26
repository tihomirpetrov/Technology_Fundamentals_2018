namespace P02.CircleArea
{
    using System;
    class Startup
    {
        public static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine($"{area:f12}");
        }
    }
}