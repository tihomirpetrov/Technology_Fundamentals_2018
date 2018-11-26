namespace P06.CalculateRectangleArea
{
    using System;
    class Program
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            CalculateRectangleArea(width, height);
        }

        private static void CalculateRectangleArea(double width, double height)
        {
            double result = width * height;
            Console.WriteLine(result);
        }
    }
}