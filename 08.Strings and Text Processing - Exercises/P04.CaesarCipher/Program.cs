namespace P04.CaesarCipher
{
    using System;
    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string output = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                output += (char)(input[i] + 3);
            }
            Console.WriteLine(output);
        }
    }
}