namespace P01.ReverseStrings
{
    using System;

    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string reversed = String.Empty;

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversed += input[i];
                }
                Console.WriteLine($"{input} = {reversed}");

                input = Console.ReadLine();
            }
        }
    }
}