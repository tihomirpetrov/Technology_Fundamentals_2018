namespace P11.MultiplicationTable_2
{
    using System;

    class Startup
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            int multiply = 0;
            if (multiplier > 10)
            {
                multiply = input * multiplier;
                Console.WriteLine($"{input} X {multiplier} = {multiply}");
            }
            else
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    multiply = input * multiplier;
                    Console.WriteLine($"{input} X {multiplier} = {multiply}");
                    multiplier++;
                }
            }
        }
    }
}