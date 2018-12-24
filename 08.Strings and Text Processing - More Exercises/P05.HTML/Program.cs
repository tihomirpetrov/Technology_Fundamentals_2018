namespace P05.HTML
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static void Main()
        {
            string articleTitle = Console.ReadLine();
            string articleContent = Console.ReadLine();
            string command = Console.ReadLine();
            List<string> comments = new List<string>();

            while (command != "end of comments")
            {
                if (!comments.Contains(command))
                {
                    comments.Add(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("<h1>");
            Console.WriteLine($"{articleTitle}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine($"{articleContent}");
            Console.WriteLine("</article>");

            foreach (var item in comments)
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"{item}");
                Console.WriteLine("</div>");
            }
        }
    }
}