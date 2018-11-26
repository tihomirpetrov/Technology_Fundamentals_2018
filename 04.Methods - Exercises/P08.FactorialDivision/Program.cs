namespace P08.FactorialDivision
{
    using System;
    class Startup
    {
        public static void Main()
        {
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            decimal secondNumber = decimal.Parse(Console.ReadLine());
            decimal temp = 1;

            Factorial(temp, firstNumber);
            Factorial(temp, secondNumber);

            decimal result = Factorial(temp, firstNumber) / Factorial(temp, secondNumber);
            Console.WriteLine($"{result:f2}");
        }

        private static decimal Factorial(decimal temp, decimal firstNumber)
        {
            temp = 1;

            for (decimal i = 1; i <= firstNumber; i++)
            {
                temp = temp * i;
            }

            return temp;
        }
    }
}