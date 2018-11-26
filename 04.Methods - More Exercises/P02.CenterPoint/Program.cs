﻿namespace P02.CenterPoint
{
    using System;
    class Startup
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine(ClosestCenterPoint(x1, y1, x2, y2));
        }

        private static string ClosestCenterPoint(double x1, double y1, double x2, double y2)
        {
            string coordinates = string.Empty;

            if (Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2)) <= Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2)))
            {
                coordinates = $"({x1}, {y1})";
            }
            else
            {
                coordinates = $"({x2}, {y2})";
            }

            return coordinates;
        }
    }
}