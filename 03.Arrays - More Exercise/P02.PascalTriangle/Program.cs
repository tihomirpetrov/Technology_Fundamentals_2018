namespace P02.PascalTriangle
{
    using System;
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] line = new int[n];
            line[0] = 1;

            for (int i = 1; i <= n; i++)
            {
                int[] row = new int[i];
                row[0] = 1;
                for (int j = 1; j < i; j++)
                {
                    row[j] = line[j] + line[j - 1];
                }
                Console.WriteLine(string.Join(" ", row));
                for (int k = 0; k < row.Length; k++)
                {
                    line[k] = row[k];
                }
            }
        }
    }
}