namespace P03.CharactersInRange
{
    using System;
    class Program
    {
        public static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            var temp = ' ';

            if (firstChar > secondChar)
            {
                temp = firstChar;
                firstChar = secondChar;
                secondChar = temp;
            }

            Console.WriteLine(CharactersInRange(firstChar, secondChar));
        }

        private static char[] CharactersInRange(char firstChar, char secondChar)
        {
            char[] arr = new char[secondChar - firstChar + 1];
            int count = 0;
            for (char i = firstChar; i < secondChar; i++)
            {
                arr[count] = i;
                count++;
            }
            return arr;
        }
    }
}