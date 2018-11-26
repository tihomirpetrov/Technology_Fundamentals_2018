namespace P01.SumDigits
{
    using System;
    class Startup
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            int n = int.Parse(number);
            int sum = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}