namespace P10.MultiplicationTable
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int multiply = 0;
            for (int i = 1; i <= 10; i++)
            {
                multiply = input * i;
                Console.WriteLine($"{input} X {i} = {multiply}");
            }
        }
    }
}