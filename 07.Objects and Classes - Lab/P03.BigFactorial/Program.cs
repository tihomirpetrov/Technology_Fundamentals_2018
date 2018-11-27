namespace P03.BigFactorial
{
    using System;
    using System.Numerics;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}