namespace P06.EqualSum
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (numbers.Length == 1)
            {
                Console.WriteLine($"0");
            }
            else
            {

                for (int i = 0; i < numbers.Length; i++)
                {
                    int leftSum = 0;
                    int rightSum = 0;
                    for (int j = 0; j < i; j++)
                    {
                        leftSum += numbers[j];
                    }
                    for (int k = i + 1; k < numbers.Length; k++)
                    {
                        rightSum += numbers[k];
                    }
                    if (leftSum == rightSum)
                    {
                        Console.WriteLine(i);
                        return;
                    }
                }
                Console.WriteLine("no");
            }
        }
    }
}