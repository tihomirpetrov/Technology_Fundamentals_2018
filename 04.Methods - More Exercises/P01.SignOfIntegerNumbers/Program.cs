namespace P01.SignOfIntegerNumbers
{
    using System;
    class Startup
    {
        public static void Main()
        {
            SignOfIntegerNumbers();
        }

        private static void SignOfIntegerNumbers()
        {
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else if (n == 0)
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }
    }
}