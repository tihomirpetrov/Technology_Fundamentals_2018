namespace P07.MathPower
{
    using System;
    class Program
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int powerNumber = int.Parse(Console.ReadLine());

            RaiseToPower(number, powerNumber);
        }

        public static double RaiseToPower(double number, int powerNumber)
        {
            double result = 1;

            for (int i = 0; i < powerNumber; i++)
            {
                result *= number;
            }
            Console.WriteLine(result);

            return result;
        }
    }
}