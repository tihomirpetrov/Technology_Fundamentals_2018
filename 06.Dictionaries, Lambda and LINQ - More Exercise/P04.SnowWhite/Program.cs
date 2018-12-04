namespace P04.SnowWhite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            Dictionary<string, int> dwarfs = new Dictionary<string, int>();
            string input = Console.ReadLine();

            while (input != "Once upon a time")
            {
                string[] tokens = input.Split("<:>").ToArray();
                string dwarfName = tokens[0];
                string dwarfHatColor = tokens[1];
                int dwarfPhysics = int.Parse(tokens[2]);
                string colorName = $"{dwarfHatColor}:{dwarfName}";

                if (!dwarfs.ContainsKey(colorName))
                {
                    dwarfs.Add(colorName, dwarfPhysics);
                }

                dwarfs[colorName] = Math.Max(dwarfs[colorName], dwarfPhysics);

                input = Console.ReadLine();
            }

            foreach (var item in dwarfs.OrderByDescending(x => x.Value)
                .ThenByDescending(x => dwarfs.Where(y => y.Key.Split(':')[0] == x.Key.Split(':')[0]).Count()))
            {
                Console.WriteLine($"({item.Key.Split(':')[0].Trim()}) {item.Key.Split(':')[1]}<-> {item.Value}");
            }
        }
    }
}