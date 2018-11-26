namespace P04.TribonacciSequence
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int[] sequence = new int[num];

            if (num == 1)
            {
                Console.WriteLine(num);
            }

            else if (num == 2)
            {
                Console.WriteLine("1 1");
            }

            else if (num == 3)
            {
                Console.WriteLine("1 1 2");
            }

            else
            {
                sequence[0] = 1;
                sequence[1] = 1;
                sequence[2] = 2;

                PrintSequence(num, sequence);
            }
        }

        private static void PrintSequence(int num, int[] sequence)
        {
            for (int i = 3; i < num; i++)
            {
                sequence[i] = sequence[i - 1] + sequence[i - 2] + sequence[i - 3];
            }

            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}