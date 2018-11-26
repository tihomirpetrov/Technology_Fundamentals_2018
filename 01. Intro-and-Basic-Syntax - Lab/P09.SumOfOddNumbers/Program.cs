namespace P09.SumOfOddNumbers
{
    using System;

    class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                    Console.WriteLine(i);
                    counter++;
                }
                if (counter == n)
                {
                    Console.WriteLine($"Sum: {sum}");
                    return;
                }
            }
        }
    }
}