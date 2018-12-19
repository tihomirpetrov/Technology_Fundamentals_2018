namespace P02.Articles
{
    using System;
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

        public void Editing(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newName)
        {
            Name = newName;
        }
        public void ToString()
        {
            Console.WriteLine($"{Name} - {Content}: {Author}");
        }

    }
    class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();
            int numberCommand = int.Parse(Console.ReadLine());

            Articles list = new Articles(input[0], input[1], input[2]);

            for (int i = 0; i < numberCommand; i++)
            {
                string[] line = Console.ReadLine().Split(": ").ToArray();
                string command = line[0];
                if (command == "Edit")
                {
                    string newContent = line[1];
                    list.Editing(newContent);
                }
                else if (command == "ChangeAuthor")
                {
                    string newAuthors = line[1];
                    list.ChangeAuthor(newAuthors);
                }
                else if (command == "Rename")
                {
                    string newName = line[1];
                    list.Rename(newName);
                }
            }
            list.ToString();
        }
    }
}