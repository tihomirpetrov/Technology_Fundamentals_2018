namespace P03.LongerLine
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
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());


            double distanceFirstLine = DistanceLine(x1, y1, x2, y2);
            double distanceSecondLine = DistanceLine(x3, y3, x4, y4);

            if (distanceFirstLine >= distanceSecondLine)
            {
                double centerPoint1 = ClosestDistanceToCenter(x1, y1);
                double centerPoint2 = ClosestDistanceToCenter(x2, y2);

                if (centerPoint1 <= centerPoint2)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                double centerPoint3 = ClosestDistanceToCenter(x3, y3);
                double centerPoint4 = ClosestDistanceToCenter(x4, y4);

                if (centerPoint3 <= centerPoint4)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }

        private static double ClosestDistanceToCenter(double x, double y)
        {
            double distanceCenter = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            return distanceCenter;
        }

        private static double DistanceLine(double x1, double y1, double x2, double y2)
        {
            double distanceLine = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

            return distanceLine;
        }
    }
}