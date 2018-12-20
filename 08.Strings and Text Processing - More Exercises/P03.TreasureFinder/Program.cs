namespace P03.TreasureFinder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        public static void Main()
        {
            int[] sequenceOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string lines = Console.ReadLine();
            List<string> decryptedLines = new List<string>();

            while (lines != "find")
            {
                string decryptedLine = string.Empty;
                int counter = 0;

                for (int i = 0; i < lines.Length; i++)
                {
                    if (counter > sequenceOfNumbers.Length - 1)
                    {
                        counter = 0;
                    }

                    decryptedLine += (char)(lines[i] - sequenceOfNumbers[counter++]);
                }

                if (!decryptedLines.Contains(decryptedLine))
                {
                    decryptedLines.Add(decryptedLine);
                }

                lines = Console.ReadLine();
            }

            for (int i = 0; i < decryptedLines.Count; i++)
            {
                string metalType = string.Empty;
                string coordinates = string.Empty;

                int startCountMetal = decryptedLines[i].IndexOf('&');
                int endCountMetal = decryptedLines[i].LastIndexOf('&');
                for (int j = startCountMetal + 1; j < endCountMetal; j++)
                {
                    metalType += decryptedLines[i][j];
                }

                int startCountCoordinates = decryptedLines[i].IndexOf('<');
                int endCountCoordinates = decryptedLines[i].LastIndexOf('>');
                for (int j = startCountCoordinates + 1; j < endCountCoordinates; j++)
                {
                    coordinates += decryptedLines[i][j];
                }

                Console.WriteLine($"Found {metalType} at {coordinates}");
            }
        }
    }
}
