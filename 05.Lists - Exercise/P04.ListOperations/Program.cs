namespace P04.ListOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] operations = input.Split().ToArray();

                if (operations[0] == "Add")
                {
                    int number = int.Parse(operations[1]);
                    numbers.Add(number);
                }

                if (operations[0] == "Insert")
                {
                    int number = int.Parse(operations[1]);
                    int index = int.Parse(operations[2]);
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, number);
                    }
                }

                if (operations[0] == "Remove")
                {
                    int index = int.Parse(operations[1]);
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }

                if (operations[0] == "Shift" && operations[1] == "left")
                {
                    int count = int.Parse(operations[2]);

                    count = count % numbers.Count;
                    for (int i = 0; i < count; i++)
                    {
                        numbers.Add(numbers[0]);
                        numbers.RemoveAt(0);
                    }
                }


                if (operations[0] == "Shift" && operations[1] == "right")
                {
                    int count = int.Parse(operations[2]);

                    count = count % numbers.Count;
                    for (int i = 0; i < count; i++)
                    {
                        numbers.Insert(0, numbers[numbers.Count - 1]);
                        numbers.RemoveAt(numbers.Count - 1);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}