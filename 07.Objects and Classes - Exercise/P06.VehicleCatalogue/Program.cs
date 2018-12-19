namespace P06.VehicleCatalogue
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

    }
    class StartUp
    {
        public static void Main()
        {
            List<Vehicle> list = new List<Vehicle>();
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] input = command.Split();
                string type = input[0].ToLower();
                if (type == "car")
                {
                    type = "Car";
                }
                if (type == "truck")
                {
                    type = "Truck";
                }
                string model = input[1];
                string color = input[2];
                int horsePower = int.Parse(input[3]);

                Vehicle current = new Vehicle(type, model, color, horsePower);
                list.Add(current);
                command = Console.ReadLine();
            }

            string line = Console.ReadLine();
            while (line != "Close the Catalogue")
            {
                string model = line;
                foreach (var item in list)
                {
                    if (item.Model == model)
                    {
                        Console.WriteLine($"Type: {item.Type}");
                        Console.WriteLine($"Model: {item.Model}");
                        Console.WriteLine($"Color: {item.Color}");
                        Console.WriteLine($"Horsepower: {item.HorsePower}");
                    }
                }

                line = Console.ReadLine();
            }

            List<Vehicle> cars = list.Where(x => x.Type == "Car").ToList();
            if (cars.Count > 0)
            {
                double horsePowerCar = cars.Average(x => x.HorsePower);
                Console.WriteLine($"Cars have average horsepower of: {horsePowerCar:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            List<Vehicle> trucks = list.Where(x => x.Type == "Truck").ToList();
            if (trucks.Count > 0)
            {
                double horsePowerTrucks = trucks.Average(x => x.HorsePower);
                Console.WriteLine($"Trucks have average horsepower of: {horsePowerTrucks:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }
}