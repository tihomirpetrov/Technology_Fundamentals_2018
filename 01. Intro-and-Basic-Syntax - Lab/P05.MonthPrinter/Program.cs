﻿namespace P05.MonthPrinter
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number > 12 || number < 1)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                if (number == 1)
                {
                    Console.WriteLine("January");
                }
                else if (number == 2)
                {
                    Console.WriteLine("February");
                }
                else if (number == 3)
                {
                    Console.WriteLine("March");
                }
                else if (number == 4)
                {
                    Console.WriteLine("April");
                }
                else if (number == 5)
                {
                    Console.WriteLine("May");
                }
                else if (number == 6)
                {
                    Console.WriteLine("June");
                }
                else if (number == 7)
                {
                    Console.WriteLine("July");
                }
                else if (number == 8)
                {
                    Console.WriteLine("August");
                }
                else if (number == 9)
                {
                    Console.WriteLine("September");
                }
                else if (number == 10)
                {
                    Console.WriteLine("October");
                }
                else if (number == 11)
                {
                    Console.WriteLine("November");
                }
                else if (number == 12)
                {
                    Console.WriteLine("December");
                }
            }
        }
    }
}
