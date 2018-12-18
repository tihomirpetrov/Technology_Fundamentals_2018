namespace P05.DigitsLettersAndOther
{
    using System;

    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string numbers = string.Empty;
            string letters = string.Empty;
            string other = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 48 && input[i] <= 57)
                {
                    numbers += input[i];
                }
                else if (input[i] >= 65 && input[i] <= 90 || input[i] >= 97 && input[i] <= 122)
                {
                    letters += input[i];
                }
                else
                {
                    other += input[i];
                }
            }
            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(other);
        }
    }
}