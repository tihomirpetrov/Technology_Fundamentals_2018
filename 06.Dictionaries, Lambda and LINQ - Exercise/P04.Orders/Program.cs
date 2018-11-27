namespace P04.Orders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            Dictionary<string, double> namePrice = new Dictionary<string, double>();
            Dictionary<string, int> nameQty = new Dictionary<string, int>();


            while (command != "buy")
            {
                string[] input = command.Split().ToArray();
                string name = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);

                if (!namePrice.ContainsKey(name))
                {
                    namePrice.Add(name, 0);
                }
                namePrice[name] = price;

                if (!nameQty.ContainsKey(name))
                {
                    nameQty.Add(name, 0);
                }
                nameQty[name] += quantity;

                command = Console.ReadLine();
            }

            foreach (var item in namePrice)
            {
                foreach (var item2 in nameQty)
                {
                    if (item.Key == item2.Key)
                    {
                        Console.WriteLine($"{item2.Key} -> {item.Value * item2.Value:f2}");
                    }
                }
            }
        }
    }
}