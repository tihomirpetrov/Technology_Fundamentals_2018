namespace P06.MiddleCharacters
{
    using System;
    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(MiddleCharacters(input));
        }

        private static string MiddleCharacters(string input)
        {
            string result = string.Empty;

            if (input.Length % 2 == 0)
            {
                result = input[input.Length / 2 - 1].ToString() + input[input.Length / 2].ToString();
            }
            else if (input.Length % 2 != 0)
            {
                result = input[input.Length / 2].ToString();
            }

            return result;
        }
    }
}