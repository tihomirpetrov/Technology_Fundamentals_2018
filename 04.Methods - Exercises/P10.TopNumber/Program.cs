namespace P10.TopNumber
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int range = int.Parse(Console.ReadLine());

            for (int i = 1; i <= range; i++)
            {
                int num = i;

                bool isDivisibleBy8 = CheckIsDivisibleBy8(i);
                bool containsOddNumber = ContainsOddNumber(i);

                if (isDivisibleBy8 && containsOddNumber)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool ContainsOddNumber(int number)
        {
            while (number != 0)
            {
                int digit = number % 10;
                number /= 10;

                if (digit % 2 == 1)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool CheckIsDivisibleBy8(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int digit = number % 10;
                number /= 10;

                sum += digit;
            }

            if (sum % 8 == 0)
            {
                return true;
            }
            return false;
        }
    }
}