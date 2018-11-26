namespace P09.MultiplyEvensByOdds
{
    using System;
    class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);
            number = MultiplyEvensByOdds(input, number);
        }

        private static int MultiplyEvensByOdds(string input, int number)
        {
            int lastDigit = 0;
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < input.Length; i++)
            {
                lastDigit = number % 10;
                number = number / 10;

                if (lastDigit % 2 == 0)
                {
                    sumEven += lastDigit;
                }
                else if (lastDigit % 2 != 0)
                {
                    sumOdd += lastDigit;
                }
            }
            int result = sumEven * sumOdd;
            Console.WriteLine(result);
            return number;
        }
    }
}