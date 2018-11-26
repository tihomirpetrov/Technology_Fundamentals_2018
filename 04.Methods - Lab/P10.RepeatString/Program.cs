namespace P10.RepeatString
{
    using System;
    class Startup
    {
        public static void Main()
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            RepeatString(str, count);
        }

        private static string RepeatString(string str, int count)
        {
            string result = "";

            for (int i = 0; i < count; i++)
            {
                Console.Write(str, count);
            }
            Console.WriteLine();
            return result;
        }
    }
}