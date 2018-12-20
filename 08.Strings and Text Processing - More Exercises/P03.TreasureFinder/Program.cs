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

            string metalType = string.Empty;
            string coordinates = string.Empty;
            string temp = string.Empty;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < decryptedLines.Count; i++)
            {

                for (int j = 0; j < decryptedLines[i].Length; j++)
                {

                    temp = decryptedLines[i];
                    int counter = 0;
                    for (int k = 0; k < temp.Length; k++)
                    {
                        if (temp[k] == '&')
                        {
                            counter++;
                            if (temp[k] == '&' && counter > 1)
                            {
                                break;
                            }
                            metalType += temp[k + 1];
                        }
                        else if (temp[k] == '<')
                        {
                            if (temp[k] == '>')
                            {
                                break;
                            }
                            coordinates += temp[k + 1];
                        }
                    }
                }
            }

            foreach (var item in decryptedLines)
            {

                Console.WriteLine($"Found {metalType} at {coordinates}");
            }



            //Console.WriteLine(string.Join(Environment.NewLine, decryptedLines));
        }
    }
}