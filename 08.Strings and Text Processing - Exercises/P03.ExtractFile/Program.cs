namespace P03.ExtractFile
{
    using System;
    using System.IO;

    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string fileName = Path.GetFileNameWithoutExtension(input);
            string fileExtension = Path.GetExtension(input);
            fileExtension = fileExtension.Replace(".", string.Empty);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}