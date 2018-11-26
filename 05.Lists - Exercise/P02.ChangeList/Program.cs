namespace P02.ChangeList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        public static void Main()
        {
            List<int> listOfIntegers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "end")
            {

                int element = int.Parse(command[1]);

                if (command[0] == "Delete")
                {
                    for (int i = 0; i < listOfIntegers.Count; i++)
                    {
                        if (element == listOfIntegers[i])
                        {
                            listOfIntegers.Remove(listOfIntegers[i]);
                        }
                    }
                }

                if (command[0] == "Insert")
                {
                    int position = int.Parse(command[2]);
                    listOfIntegers.Insert(position, element);
                }

                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(" ", listOfIntegers));
        }
    }
}