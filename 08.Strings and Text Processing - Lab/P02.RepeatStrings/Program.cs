namespace P02.RepeatStrings
{
    using System;
    using System.Linq;
    using System.Text;

    class Program
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split().ToArray();

            StringBuilder result = new StringBuilder();

            foreach (var word in words)
            {
                int count = word.Length;

                for (int i = 0; i < count; i++)
                {
                    result.Append(word);
                }
            }

            Console.WriteLine(result);
        }
    }
}