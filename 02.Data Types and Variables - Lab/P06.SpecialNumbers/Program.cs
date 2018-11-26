namespace P06.SpecialNumbers
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int number = i;
                while (number != 0)
                {
                    int lastDigit = number % 10;
                    number /= 10;
                    sum += lastDigit;

                }
                bool isSpecial = (sum == 5 || sum == 7 || sum == 11);

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}