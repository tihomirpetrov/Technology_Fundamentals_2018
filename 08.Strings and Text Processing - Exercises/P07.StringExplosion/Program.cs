namespace P07.StringExplosion
{
    using System;
    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int strength = 0;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] >= 48 && input[i] <= 57 && input[i - 1] == '>')
                {
                    strength += input[i] - 48;
                }
                if (strength > 0 && input[i] != '>')
                {
                    input = input.Remove(i, 1);
                    strength--;
                    i--;
                }
            }
            Console.WriteLine(input);
        }
    }
}