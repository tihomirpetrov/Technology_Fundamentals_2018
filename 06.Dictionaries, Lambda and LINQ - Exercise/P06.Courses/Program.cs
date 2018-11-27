namespace P06.Courses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> courseStudent = new Dictionary<string, List<string>>();


            while (command != "end")
            {
                string[] input = command.Split(" : ").ToArray();
                string courseName = input[0];
                string studentName = input[1];

                if (!courseStudent.ContainsKey(courseName))
                {
                    courseStudent.Add(courseName, new List<string>());
                }
                if (!courseStudent[courseName].Contains(studentName))
                {
                    courseStudent[courseName].Add(studentName);
                }


                command = Console.ReadLine();
            }

            foreach (var course in courseStudent.OrderByDescending(x => x.Value.Count()))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count()}");

                foreach (var student in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}