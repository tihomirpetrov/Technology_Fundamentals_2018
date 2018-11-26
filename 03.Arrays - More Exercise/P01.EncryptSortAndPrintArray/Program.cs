namespace P01.EncryptSortAndPrintArray
{
    using System;
    class Program
    {
        public static void Main()
        {
            int numOfSequence = int.Parse(Console.ReadLine());
            string name = string.Empty;
            int[] nameInNums = new int[numOfSequence];

            for (int i = 0; i < numOfSequence; i++)
            {
                name = Console.ReadLine();

                char[] nameOfChars = name.ToCharArray();

                for (int j = 0; j < nameOfChars.Length; j++)
                {
                    if (nameOfChars[j] == 65 || nameOfChars[j] == 69 || nameOfChars[j] == 73 || nameOfChars[j] == 79 || nameOfChars[j] == 85 || nameOfChars[j] == 97 || nameOfChars[j] == 101 || nameOfChars[j] == 105 || nameOfChars[j] == 111 || nameOfChars[j] == 117)

                    {
                        nameInNums[i] += nameOfChars[j] * nameOfChars.Length;
                    }

                    else
                    {
                        nameInNums[i] += nameOfChars[j] / nameOfChars.Length;
                    }
                }
            }

            Array.Sort(nameInNums);

            foreach (var item in nameInNums)
            {
                Console.WriteLine(item);
            }
        }
    }
}