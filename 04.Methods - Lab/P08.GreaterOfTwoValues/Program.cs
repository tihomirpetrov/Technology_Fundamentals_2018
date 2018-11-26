namespace P08.GreaterOfTwoValues
{
    using System;
    class Startup
    {
        static void Main()
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                int max = GetMax(firstNumber, secondNumber);
                Console.WriteLine(max);
            }

            if (type == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                char max = GetMax(firstChar, secondChar);
                Console.WriteLine(max);
            }

            if (type == "string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                string max = GetMax(firstString, secondString);
                Console.WriteLine(max);
            }
        }

        private static int GetMax(int firstNumber, int secondNumber)
        {
            int max = 0;
            if (firstNumber >= secondNumber)
            {
                max = firstNumber;
            }
            else
            {
                max = secondNumber;
            }
            return max;
        }

        private static char GetMax(char firstChar, char secondChar)
        {
            char max = (char)0x00;
            if (firstChar >= secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }

        private static string GetMax(string firstString, string secondString)
        {
            if (firstString.CompareTo(secondString) >= 0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }
    }
}