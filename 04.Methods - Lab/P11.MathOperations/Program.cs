namespace P11.MathOperations
{
    using System;
    class Program
    {
        public static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());
            Calculate(firstNum, @operator, secondNum);
        }

        private static double Calculate(int firstNum, string @operator, int secondNum)
        {
            double result = 0;
            if (@operator == "/")
            {
                result = firstNum / secondNum;
                Console.WriteLine(result);
            }

            if (@operator == "*")
            {
                result = firstNum * secondNum;
                Console.WriteLine(result);
            }

            if (@operator == "+")
            {
                result = firstNum + secondNum;
                Console.WriteLine(result);
            }

            if (@operator == "-")
            {
                result = firstNum - secondNum;
                Console.WriteLine(result);
            }

            return result;
        }
    }
}