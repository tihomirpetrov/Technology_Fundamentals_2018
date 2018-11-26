namespace P02.CharsToString
{
    using System;
    class Startup
    {
        public static void Main()
        {
            string firstLetter = Console.ReadLine();
            string secondLetter = Console.ReadLine();
            string thirdLetter = Console.ReadLine();
            Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
        }
    }
}