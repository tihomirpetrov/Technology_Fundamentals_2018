namespace P04.MorseCodeTranslator
{
    using System;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string output = string.Empty;
            char letter = ' ';

            for (int i = 0; i < tokens.Length; i++)
            {
                if (tokens[i] == ".-")
                {
                    letter = 'A';
                }
                else if (tokens[i] == "-...")
                {
                    letter = 'B';
                }
                else if (tokens[i] == "-.-.")
                {
                    letter = 'C';
                }
                else if (tokens[i] == "-..")
                {
                    letter = 'D';
                }
                else if (tokens[i] == ".")
                {
                    letter = 'E';
                }
                else if (tokens[i] == "..-.")
                {
                    letter = 'F';
                }
                else if (tokens[i] == "--.")
                {
                    letter = 'G';
                }
                else if (tokens[i] == "....")
                {
                    letter = 'H';
                }
                else if (tokens[i] == "..")
                {
                    letter = 'I';
                }
                else if (tokens[i] == ".---")
                {
                    letter = 'J';
                }
                else if (tokens[i] == "-.-")
                {
                    letter = 'K';
                }
                else if (tokens[i] == ".-..")
                {
                    letter = 'L';
                }
                else if (tokens[i] == "--")
                {
                    letter = 'M';
                }
                else if (tokens[i] == "-.")
                {
                    letter = 'N';
                }
                else if (tokens[i] == "---")
                {
                    letter = 'O';
                }
                else if (tokens[i] == ".--.")
                {
                    letter = 'P';
                }
                else if (tokens[i] == "--.-")
                {
                    letter = 'Q';
                }
                else if (tokens[i] == ".-.")
                {
                    letter = 'R';
                }
                else if (tokens[i] == "...")
                {
                    letter = 'S';
                }
                else if (tokens[i] == "-")
                {
                    letter = 'T';
                }
                else if (tokens[i] == "..-")
                {
                    letter = 'U';
                }
                else if (tokens[i] == "...-")
                {
                    letter = 'V';
                }
                else if (tokens[i] == ".--")
                {
                    letter = 'W';
                }
                else if (tokens[i] == "-..-")
                {
                    letter = 'X';
                }
                else if (tokens[i] == "-.--")
                {
                    letter = 'Y';
                }
                else if (tokens[i] == "--..")
                {
                    letter = 'Z';
                }
                else if (tokens[i] == "|")
                {
                    letter = ' ';
                }

                output += letter;
            }
            Console.WriteLine(output);
        }
    }
}