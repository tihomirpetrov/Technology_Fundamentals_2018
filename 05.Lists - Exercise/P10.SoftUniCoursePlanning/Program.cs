namespace P10.SoftUniCoursePlanning
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            List<string> initialSchedule = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();

            while (input != "course start")
            {
                string[] command = input.Split(":").ToArray();

                if (command[0] == "Add")
                {
                    string lesson = command[1];
                    if (!initialSchedule.Contains(lesson))
                    {
                        initialSchedule.Add(lesson);
                    }
                }

                else if (command[0] == "Insert")
                {
                    string lesson = command[1];
                    if (!initialSchedule.Contains(lesson))
                    {
                        int index = int.Parse(command[2]);
                        initialSchedule.Insert(index, lesson);
                    }
                }

                else if (command[0] == "Remove")
                {
                    string lesson = command[1];
                    string exercise = $"{lesson}-Exercise";

                    if (initialSchedule.Contains(lesson))
                    {
                        initialSchedule.Remove(lesson);

                        if (initialSchedule.Contains(exercise))
                        {
                            initialSchedule.Remove(exercise);
                        }

                    }
                }

                else if (command[0] == "Swap")
                {
                    string firstLesson = command[1];
                    string secondLesson = command[2];
                    string exerciseOfFirst = $"{firstLesson}-Exercise";
                    string exerciseOfSecond = $"{secondLesson}-Exercise";
                    if (initialSchedule.Contains(firstLesson) && initialSchedule.Contains(secondLesson))
                    {
                        int indexOfFirst = initialSchedule.IndexOf(firstLesson);
                        int indexOfSecond = initialSchedule.IndexOf(secondLesson);

                        //initialSchedule.Remove(firstLesson);
                        //initialSchedule.Remove(secondLesson);
                        //initialSchedule.Insert(indexOfFirst, secondLesson);
                        //initialSchedule.Insert(indexOfSecond, firstLesson);

                        initialSchedule[indexOfFirst] = secondLesson;
                        initialSchedule[indexOfSecond] = firstLesson;

                        if (initialSchedule.Contains(exerciseOfFirst))
                        {
                            initialSchedule.Remove(exerciseOfFirst);
                            indexOfFirst = initialSchedule.IndexOf(firstLesson);
                            initialSchedule.Insert(indexOfFirst + 1, exerciseOfFirst);
                        }
                        if (initialSchedule.Contains(exerciseOfSecond))
                        {
                            initialSchedule.Remove(exerciseOfSecond);
                            indexOfSecond = initialSchedule.IndexOf(secondLesson);
                            initialSchedule.Insert(indexOfSecond + 1, exerciseOfSecond);
                        }
                    }
                }

                else if (command[0] == "Exercise")
                {
                    string lesson = command[1];
                    string exercise = $"{lesson}-Exercise";

                    if (initialSchedule.Contains(lesson))
                    {
                        int indexOfLesson = initialSchedule.IndexOf(lesson);
                        if (!initialSchedule.Contains(exercise))
                        {
                            initialSchedule.Insert(indexOfLesson + 1, exercise);
                        }
                    }
                    else
                    {
                        initialSchedule.Add(lesson);
                        initialSchedule.Add(exercise);
                    }
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < initialSchedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{initialSchedule[i]}");
            }
        }
    }
}
