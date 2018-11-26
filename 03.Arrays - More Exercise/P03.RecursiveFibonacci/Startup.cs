namespace P03.RecursiveFibonacci
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] fibonaciNums = new int[n];

            if (n == 1)
            {
                Console.WriteLine(1);
                return;
            }
            fibonaciNums[0] = 1;
            fibonaciNums[1] = 1;

            for (int i = 2; i < n; i++)
            {
                fibonaciNums[i] = fibonaciNums[i - 1] + fibonaciNums[i - 2];
            }
            Console.WriteLine(string.Join(" ", fibonaciNums[fibonaciNums.Length - 1]));
        }
    }
}