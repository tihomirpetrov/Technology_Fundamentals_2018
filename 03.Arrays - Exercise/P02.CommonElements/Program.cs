namespace P02.CommonElements
{
    using System;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            string[] firstInput = Console.ReadLine().Split().ToArray();
            string[] secondInput = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < secondInput.Length; i++)
            {
                for (int j = 0; j < firstInput.Length; j++)
                {
                    if (firstInput[j] == secondInput[i])
                    {
                        Console.Write(secondInput[i] + ' ');
                    }
                }
            }
            Console.WriteLine();
        }
    }
}