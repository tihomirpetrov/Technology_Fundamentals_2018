namespace P02.Grades
{
    using System;
    class Startup
    {
        public static void Main()
        {
            PrintGrade();
        }

        private static void PrintGrade()
        {
            double n = double.Parse(Console.ReadLine());

            if (n >= 2 && n <= 2.99)
            {
                Console.WriteLine("Fail");
            }

            if (n >= 3 && n <= 3.49)
            {
                Console.WriteLine("Poor");
            }

            if (n >= 3.50 && n <= 4.49)
            {
                Console.WriteLine("Good");
            }

            if (n >= 4.50 && n <= 5.49)
            {
                Console.WriteLine("Very good");
            }

            if (n >= 5.50 && n <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}