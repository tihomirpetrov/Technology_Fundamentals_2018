namespace P01.DataTypes
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int intNum = 0;
            double doubleNum = 0;
            string input = string.Empty;
            DataTypePrint(intNum, doubleNum, input);
        }

        private static void DataTypePrint(int intNum, double doubleNum, string input)
        {
            string type = Console.ReadLine();
            int intResult = 0;
            double doubleResult = 0;
            //string input = string.Empty;

            if (type == "int")
            {
                intNum = int.Parse(Console.ReadLine());
                intResult = intNum * 2;
                Console.WriteLine(intResult);
            }

            if (type == "real")
            {
                doubleNum = double.Parse(Console.ReadLine());
                doubleResult = doubleNum * 1.5;
                Console.WriteLine($"{doubleResult:f2}");
            }

            if (type == "string")
            {
                input = Console.ReadLine();
                Console.WriteLine($"${input}$");
            }
        }
    }
}