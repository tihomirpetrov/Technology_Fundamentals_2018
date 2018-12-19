namespace P07.OrderByAge
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
    class StartUp
    {
        public static void Main()
        {
            List<Person> list = new List<Person>();
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);

                Person currenPerson = new Person(name, id, age);
                list.Add(currenPerson);

                command = Console.ReadLine();
            }
            list = list.OrderBy(x => x.Age).ToList();

            foreach (var person in list)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}