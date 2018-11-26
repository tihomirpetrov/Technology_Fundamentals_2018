namespace P03.ZigZagArrays
{
    using System;
    using System.Linq;
    class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = new string[n];
            string[] firstArr = new string[n];
            string[] secondArr = new string[n];

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split().ToArray();
                if (i % 2 != 0)
                {
                    firstArr[i] = input[0];
                    secondArr[i] = input[1];
                }
                else if (i % 2 == 0)
                {
                    firstArr[i] = input[1];
                    secondArr[i] = input[0];
                }
            }
            Console.WriteLine(string.Join(" ", secondArr));
            Console.WriteLine(string.Join(" ", firstArr));
        }
    }
}