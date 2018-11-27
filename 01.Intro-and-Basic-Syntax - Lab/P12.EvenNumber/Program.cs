namespace P12.EvenNumber
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            while (true)
            {
                if (input % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(input)}");
                    return;
                }
                else
                {
                    Console.WriteLine($"Please write an even number.");
                }
                input = int.Parse(Console.ReadLine());
            }
        }
    }
}