namespace P02.Articles2_0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Articles
    {
        public Articles(string name, string content, string author)
        {
            Name = name;
            Content = content;
            Author = author;
        }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

    }
    class Program
    {
        public static void Main()
        {
            int numberCommand = int.Parse(Console.ReadLine());
            List<Articles> list = new List<Articles>();

            for (int i = 0; i < numberCommand; i++)
            {
                string[] input = Console.ReadLine().Split(", ").ToArray();
                Articles current = new Articles(input[0], input[1], input[2]);
                list.Add(current);
            }

            List<Articles> sortedList = new List<Articles>();
            string command = Console.ReadLine();

            if (command == "title")
            {
                sortedList = list.OrderBy(x => x.Name).ToList();
            }
            else if (command == "content")
            {
                sortedList = list.OrderBy(x => x.Content).ToList();
            }
            else if (command == "author")
            {
                sortedList = list.OrderBy(x => x.Author).ToList();
            }
            ToStr(sortedList);
        }

        public static void ToStr(List<Articles> sortedList)
        {
            foreach (var item in sortedList)
            {
                Console.WriteLine($"{item.Name} - {item.Content}: {item.Author}");
            }
        }
    }
}