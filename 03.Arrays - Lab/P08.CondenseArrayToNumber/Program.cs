namespace P08.CondenseArrayToNumber
{
    using System;
    using System.Linq;
    class Startup
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var counter = numbers.Length;
            while (counter > 1)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    numbers[i] = numbers[i] + numbers[i + 1];
                }
                counter--;
            }
            Console.WriteLine(numbers[0]);
        }
    }
}