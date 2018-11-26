namespace P07.NxNMatrix
{
    using System;
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            NxNMatrix(n);
        }

        private static void NxNMatrix(int n)
        {

            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}