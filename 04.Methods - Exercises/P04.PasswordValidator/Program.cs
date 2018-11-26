namespace P04.PasswordValidator
{
    using System;
    class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            char letter = ' ';
            bool hasTwoDigits = false;
            bool hasLetters = false;
            bool unknownChar = false;
            int counter = 0;
            int counterDigits = 0;

            if (!(input.Length >= 6 && input.Length <= 10))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            for (int i = 0; i < input.Length; i++)
            {
                letter = input[i];
                if (!(letter >= 65 && letter <= 90 || letter >= 97 && letter <= 122))
                {
                    if (letter >= 48 && letter <= 57)
                    {
                        counter++;
                    }
                    if (!(letter >= 48 && letter <= 57))
                    {
                        unknownChar = true;
                    }
                }
                else if (letter >= 65 && letter <= 90 || letter >= 97 && letter <= 122)
                {
                    counterDigits++;
                }
            }

            if (counter >= 2)
            {
                hasLetters = true;
            }

            if (counterDigits >= 2)
            {
                hasTwoDigits = true;
            }

            if (unknownChar)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (hasLetters)
            {
                if (hasTwoDigits && !unknownChar)
                {
                    Console.WriteLine("Password is valid");
                }
            }
            else
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }
    }
}