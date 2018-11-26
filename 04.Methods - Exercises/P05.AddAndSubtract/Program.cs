namespace P05.AddAndSubtract
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;
            int c = 1;

            Startup myStartup = new Startup();
            SumAndSubtract(firstNum, secondNum, thirdNum);
            Testche(a, b, c);
        }

        private static void Testche(int firstNum, int secondNum, int thirdNum)
        {
            SumAndSubtract(firstNum, secondNum, thirdNum);
        }

        private static int SumAndSubtract(int firstNum, int secondNum, int thirdNum)
        {
            int result = (firstNum + secondNum) - thirdNum;
            Console.WriteLine(result);
            return result;
        }
    }
}