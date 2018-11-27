namespace P07.VendingMachine
{
    using System;

    class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            decimal totalMoney = 0;
            decimal price = 0;
            while (input != "Start")
            {
                decimal coin = decimal.Parse(input);

                if (coin == 0.1M || coin == 0.2M || coin == 0.5M || coin == 1 || coin == 2)
                {
                    totalMoney += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                input = Console.ReadLine();
            }
            while (input != "End")
            {
                input = Console.ReadLine();
                if (input == "Nuts")
                {
                    price = 2.0M;
                    if (totalMoney >= price)
                    {
                        totalMoney -= price;
                        Console.WriteLine("Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Water")
                {
                    price = 0.7M;
                    if (totalMoney >= price)
                    {
                        totalMoney -= price;
                        Console.WriteLine("Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Crisps")
                {
                    price = 1.5M;
                    if (totalMoney >= price)
                    {
                        totalMoney -= price;
                        Console.WriteLine("Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Soda")
                {
                    price = 0.8M;
                    if (totalMoney >= price)
                    {
                        totalMoney -= price;
                        Console.WriteLine("Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Coke")
                {
                    price = 1.0M;
                    if (totalMoney >= price)
                    {
                        totalMoney -= price;
                        Console.WriteLine("Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input != "Coke" || input != "Soda" || input != "Crisps" || input != "Water" || input != "Nuts")
                {
                    if (input == "End")
                    {
                        Console.WriteLine($"Change: {totalMoney:f2}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid product");
                    }
                }
            }
        }
    }
}