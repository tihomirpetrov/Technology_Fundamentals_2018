namespace P03.LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, int> neededMaterials = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();
            neededMaterials.Add("shards", 0);
            neededMaterials.Add("fragments", 0);
            neededMaterials.Add("motes", 0);

            while (true)
            {
                string[] line = input.Split().ToArray();

                for (int i = 0; i < line.Length; i += 2)
                {
                    int quantity = int.Parse(line[i]);
                    string material = line[i + 1].ToLower();
                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        neededMaterials[material] += quantity;

                        if (neededMaterials[material] >= 250 && material == "shards")
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                            neededMaterials[material] -= 250;

                            foreach (var item in neededMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                            {
                                Console.WriteLine($"{item.Key}: {item.Value}");
                            }

                            foreach (var item in junk.OrderBy(x => x.Key))
                            {
                                Console.WriteLine($"{item.Key}: {item.Value}");
                            }
                            return;
                        }

                        else if (neededMaterials[material] >= 250 && material == "fragments")
                        {
                            Console.WriteLine("Valanyr obtained!");
                            neededMaterials[material] -= 250;

                            foreach (var item in neededMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                            {
                                Console.WriteLine($"{item.Key}: {item.Value}");
                            }

                            foreach (var item in junk.OrderBy(x => x.Key))
                            {
                                Console.WriteLine($"{item.Key}: {item.Value}");
                            }
                            return;
                        }

                        else if (neededMaterials[material] >= 250 && material == "motes")
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                            neededMaterials[material] -= 250;

                            foreach (var item in neededMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                            {
                                Console.WriteLine($"{item.Key}: {item.Value}");
                            }

                            foreach (var item in junk.OrderBy(x => x.Key))
                            {
                                Console.WriteLine($"{item.Key}: {item.Value}");
                            }
                            return;
                        }
                    }

                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk.Add(material, 0);
                        }
                        junk[material] += quantity;
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}