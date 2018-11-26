namespace P01.SmallestOfThreeNumbers
{
    using System;
    class Program
    {
        public static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            SmallestOfThreeNumbers(firstNum, secondNum, thirdNum);
        }

        private static int SmallestOfThreeNumbers(int firstNum, int secondNum, int thirdNum)
        {
            int result = int.MaxValue;
            if (firstNum < result)
            {
                result = firstNum;
            }

            if (secondNum < firstNum)
            {
                result = secondNum;
            }

            if (thirdNum < result)
            {
                result = thirdNum;
            }

            Console.WriteLine(result);
            return result;
        }
    }
}