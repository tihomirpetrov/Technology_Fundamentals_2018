namespace P02.AsciiSumator
{
    using System;

    class Program
    {
        public static void Main()
        {
            char firstLineChar = char.Parse(Console.ReadLine());
            char secondLineChar = char.Parse(Console.ReadLine());
            string lastLine = Console.ReadLine();
            int sum = 0;

            if ((int)firstLineChar < (int)secondLineChar)
            {
                for (int i = 0; i < lastLine.Length; i++)
                {
                    if ((lastLine[i]) > (int)(firstLineChar) && (lastLine[i]) < (int)(secondLineChar))
                    {
                        sum += (int)(lastLine[i]);
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}