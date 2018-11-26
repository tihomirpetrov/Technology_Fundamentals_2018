namespace P05.MultiplicationSign
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                Console.WriteLine("zero");
            }
            else if ((num1 < 0 && num2 > 0 && num3 > 0) || (num1 < 0 && num2 < 0 && num3 < 0) || (num1 > 0 && num2 > 0 && num3 < 0) || (num1 > 0 && num2 < 0 && num3 < 0))
            {
                Console.WriteLine("negative");
            }

            else
            {
                Console.WriteLine("positive");
            }
        }
    }
}