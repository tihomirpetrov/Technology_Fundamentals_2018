namespace P05.Orders
{
    using System;
    class Startup
    {
        public static void Main()
        {
            string drink = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            PrintOrder(drink, quantity);
        }

        private static void PrintOrder(string drink, int quantity)
        {
            double price = 0;
            if (drink == "coffee")
            {
                price = 1.50 * quantity;
            }

            if (drink == "water")
            {
                price = 1.00 * quantity;
            }

            if (drink == "coke")
            {
                price = 1.40 * quantity;
            }

            if (drink == "snacks")
            {
                price = 2.00 * quantity;
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}