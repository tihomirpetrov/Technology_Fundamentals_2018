namespace P04.Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Students
    {
        public Students(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
    class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            List<Students> students = new List<Students>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                Students currentStudent = new Students(input[0], input[1], double.Parse(input[2]));
                students.Add(currentStudent);
            }
            foreach (var item in students.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}: {item.Grade:f2}");
            }
        }
    }
}
