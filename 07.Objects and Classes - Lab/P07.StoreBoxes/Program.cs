namespace P07.StoreBoxes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<Box> boxes = new List<Box>();
            List<Item> items = new List<Item>();

            while (input != "end")
            {
                string[] tokens = input.Split();
                string serialNumber = tokens[0];
                string item = tokens[1];
                int itemQuantity = int.Parse(tokens[2]);
                decimal itemPrice = decimal.Parse(tokens[3]);

                Box box = new Box();

                box.SerialNumber = serialNumber;
                box.Item.Name = item;
                box.ItemQuantity = itemQuantity;
                box.ItemPrice = itemPrice;

                boxes.Add(box);
                input = Console.ReadLine();
            }


            foreach (Box box in boxes.OrderByDescending(x => x.ItemPrice * x.ItemQuantity))
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.ItemPrice:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.ItemPrice * box.ItemQuantity:f2}");
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal ItemPrice { get; set; }
    }
}