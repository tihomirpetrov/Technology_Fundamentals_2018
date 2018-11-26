namespace P03.RoundingNumbers
{
    using System;
    using System.Linq;
    class Startup
    {
        public static void Main()
        {
            string[] realNumbers = Console.ReadLine().Split().ToArray();
            double[] roundNumbers = new double[realNumbers.Length];
            for (int i = 0; i < realNumbers.Length; i++)
            {
                roundNumbers[i] = double.Parse(realNumbers[i]);
            }
            for (int i = 0; i < realNumbers.Length; i++)
            {
                Console.WriteLine($"{roundNumbers[i]} => {Math.Round(roundNumbers[i], 0, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}