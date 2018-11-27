namespace P07.StudentAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentsGrade = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsGrade.ContainsKey(student))
                {
                    studentsGrade.Add(student, new List<double>());
                }
                studentsGrade[student].Add(grade);
            }

            Dictionary<string, double> studentAverageGrade = new Dictionary<string, double>();

            foreach (var student in studentsGrade)
            {
                studentAverageGrade.Add(student.Key, student.Value.Sum() / student.Value.Count());
            }

            foreach (var student in studentAverageGrade.OrderByDescending(x => x.Value))
            {
                if (student.Value >= 4.5)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value:f2}");
                }
            }
        }
    }
}