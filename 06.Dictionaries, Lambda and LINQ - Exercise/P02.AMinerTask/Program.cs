namespace P02.AMinerTask
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, int> resource = new Dictionary<string, int>();

            while (input != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!resource.ContainsKey(input))
                {
                    resource.Add(input, 0);
                }
                resource[input] += quantity;

                input = Console.ReadLine();
            }

            foreach (var metal in resource)
            {
                Console.WriteLine($"{metal.Key} -> {metal.Value}");
            }
        }
    }
}