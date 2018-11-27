namespace P05.WordFilter
{
    using System;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split().Where(w => w.Length % 2 == 0).ToArray();

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}